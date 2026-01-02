using System.Collections.Generic;
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

        internal static ItemIndex droneMeldStackItem = ItemIndex.None;
        internal static ItemIndex minionMeldStackItem = ItemIndex.None;

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
                foreach (CharacterMaster characterMaster in CharacterMaster.readOnlyInstancesList)
                {
                    if (characterMaster.minionOwnership && characterMaster.minionOwnership.ownerMaster == characterBody.master)
                    {
                        CharacterBody minionBody = characterMaster.GetBody();
                        if (minionBody && !minionBody.isPlayerControlled && (minionBody.bodyFlags &= CharacterBody.BodyFlags.Mechanical) == CharacterBody.BodyFlags.Mechanical)
                        {
                            int mult = 1;
                            if ((minionBody.bodyFlags & CharacterBody.BodyFlags.Mechanical) > 0 || (minionBody.bodyFlags & CharacterBody.BodyFlags.Drone) > 0 || CheckMechanicalBody(minionBody.bodyIndex))
                            {
                                droneCount++;
                                if (minionBody.inventory)
                                {
                                    if (droneMeldStackItem != ItemIndex.None) droneCount += minionBody.inventory.GetItemCountEffective(droneMeldStackItem);
                                    if (minionMeldStackItem != ItemIndex.None) droneCount += minionBody.inventory.GetItemCountEffective(minionMeldStackItem);

                                    droneCount += minionBody.inventory.GetItemCountEffective(DLC3Content.Items.DroneUpgradeHidden);
                                }
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
