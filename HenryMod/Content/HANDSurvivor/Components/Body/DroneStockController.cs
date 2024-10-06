﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using RoR2.Skills;
using RoR2;
using UnityEngine.Networking;
using HANDMod.Content.HANDSurvivor.Components.Master;
using UnityEngine;

namespace HANDMod.Content.HANDSurvivor.Components.Body
{
    public class DroneStockController : NetworkBehaviour, IOnKilledOtherServerReceiver
    {
        private int oldDroneCount = 0;
        private CharacterBody characterBody;
        private DroneStockPersist dronePersist;

        public void Start()
        {
            characterBody.skillLocator.special.RemoveAllStocks();
            if (characterBody.master)
            {
                dronePersist = characterBody.master.gameObject.GetComponent<DroneStockPersist>();
                if (!dronePersist)
                {
                    dronePersist = characterBody.master.gameObject.AddComponent<DroneStockPersist>();
                }
                else
                {
                    characterBody.skillLocator.special.stock = Mathf.Max(dronePersist.droneCount, characterBody.skillLocator.special.maxStock);
                }
            }
        }

        public void Awake()
        {
            characterBody = base.GetComponent<CharacterBody>();
        }

        public void FixedUpdate()
        {
            if (hasAuthority)
            {
                if (dronePersist)
                {
                    if (characterBody.skillLocator.special.stock > dronePersist.droneCount)
                    {
                        Util.PlaySound("Play_HOC_DroneGain", base.gameObject);
                    }
                    dronePersist.droneCount = characterBody.skillLocator.special.stock;
                }

                int droneCount = characterBody.skillLocator.special.stock;
                ReadOnlyCollection<TeamComponent> teamMembers = TeamComponent.GetTeamMembers(characterBody.teamComponent.teamIndex);
                foreach (TeamComponent tc in teamMembers)
                {
                    if (tc.body && tc.body != characterBody)
                    {
                        if ((tc.body.bodyFlags & CharacterBody.BodyFlags.Mechanical) > 0 || CheckMechanicalBody(tc.body.bodyIndex))
                        {
                            droneCount++;
                        }

                        if (tc.body.inventory)
                        {
                            ItemIndex droneMeldStackItem = ItemCatalog.FindItemIndex("DronemeldInternalStackItem");
                            if (droneMeldStackItem != ItemIndex.None)
                            {
                                droneCount += tc.body.inventory.GetItemCount(droneMeldStackItem);
                            }

                            ItemIndex minionMeldStackItem = ItemCatalog.FindItemIndex("MinionMeldInternalStackItem");
                            if (minionMeldStackItem != ItemIndex.None)
                            {
                                droneCount += tc.body.inventory.GetItemCount(minionMeldStackItem);
                            }
                        }
                    }
                }
                if (droneCount != oldDroneCount)
                {
                    CmdUpdateDronePassive(droneCount);
                }
                oldDroneCount = droneCount;
            }
        }

        public static bool CheckMechanicalBody(BodyIndex bodyIndex)
        {
            foreach (BodyIndex index in mechanicalBodies)
            {
                if (index == bodyIndex)
                {
                    return true;
                }
            }
            return false;
        }

        //Sniper comes with a non-ally drone that isn't counted as an ally.
        //You can add your survivor to this list if they don't have a Mechanical bodyflag but you want them to count. Use their BaseNameToken.
        public static List<BodyIndex> mechanicalBodies = new List<BodyIndex> { };

        public void OnKilledOtherServer(DamageReport damageReport) //This seems to be called by both OnCharacterDeath and TakeDamage, resulting in it being called twice
        {
            if (NetworkServer.active && damageReport.attacker == base.gameObject)
            {
                RpcAddSpecialStock();
            }
        }

        [ClientRpc]
        public void RpcAddSpecialStock()
        {
            if (hasAuthority && characterBody.skillLocator.special.stock < characterBody.skillLocator.special.maxStock)
            {
                characterBody.skillLocator.special.stock++;
                if (characterBody.skillLocator.special.stock == characterBody.skillLocator.special.maxStock)
                {
                    characterBody.skillLocator.special.rechargeStopwatch = 0f;
                }
            }
        }

        [Command]
        public void CmdUpdateDronePassive(int newCount)
        {
            if (NetworkServer.active)
            {
                int buffCount = characterBody.GetBuffCount(Buffs.DronePassive);
                if (buffCount < newCount)
                {
                    int diff = newCount - buffCount;
                    for (int i = 0; i < diff; i++)
                    {
                        characterBody.AddBuff(Buffs.DronePassive);
                    }
                }
                else if (buffCount > newCount)
                {
                    for (int i = 0; i < buffCount; i++)
                    {
                        characterBody.RemoveBuff(Buffs.DronePassive);
                    }
                    for (int i = 0; i < newCount; i++)
                    {
                        characterBody.AddBuff(Buffs.DronePassive);
                    }
                }
            }
        }
        public void MeleeHit()
        {
            if (characterBody.skillLocator.special.stock < characterBody.skillLocator.special.maxStock)
            {
                characterBody.skillLocator.special.rechargeStopwatch += 2f;
            }
        }
    }
}
