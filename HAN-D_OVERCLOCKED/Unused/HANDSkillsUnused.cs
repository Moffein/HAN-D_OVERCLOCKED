#region graveyard
/*EntityStates.HANDOverclocked.BlastOff.effectPrefab = Resources.Load<GameObject>("prefabs/effects/omnieffect/omniexplosionvfx");
EntityStates.HANDOverclocked.BlastOff.jumpForce = 27f;
EntityStates.HANDOverclocked.BlastOff.forceMagnitude = 16f;
EntityStates.HANDOverclocked.BlastOff.damageCoefficient = 2.5f;
EntityStates.HANDOverclocked.BlastOff.radius = 9f;
EntityStates.HANDOverclocked.BlastOff.baseDuration = 0.2f;
EntityStates.HANDOverclocked.BlastOff.airbornVerticalForce = -2000f;
LoadoutAPI.AddSkill(typeof(EntityStates.HANDOverclocked.BlastOff));*/

/*EntityStates.HANDOverclocked.ChargeSpin.baseChargePartDuration = 0.3f;
EntityStates.HANDOverclocked.ChargeSpin.baseSpinCount = 1;
EntityStates.HANDOverclocked.ChargeSpin.maxSpinCount = 5;

EntityStates.HANDOverclocked.SpinAttack.damageCoefficient = 3f;
EntityStates.HANDOverclocked.SpinAttack.baseSwingDuration = 0.25f;
EntityStates.HANDOverclocked.SpinAttack.smallHopVelocity = 0f;
EntityStates.HANDOverclocked.SpinAttack.airVelocity = 18f;
EntityStates.HANDOverclocked.SpinAttack.groundVelocity = 24f;*/

//EntityStates.HANDOverclocked.ChargeRocketSmash.baseChargeDuration = 2f;
//LoadoutAPI.AddSkill(typeof(EntityStates.HANDOverclocked.ChargeRocketSmash));

/*EntityStates.HANDOverclocked.Overheat.damageCoefficient = 2.3f;
            EntityStates.HANDOverclocked.Overheat.radius = 9f;
            EntityStates.HANDOverclocked.Overheat.healPercent = 0.1f;
            EntityStates.HANDOverclocked.Overheat.effectPrefab = Resources.Load<GameObject>("prefabs/effects/WilloWispExplosion");
            EntityStates.HANDOverclocked.Overheat.baseDuration = 0.25f;
            EntityStates.HANDOverclocked.Overheat.soundString = "Play_clayboss_M1_explo";*/

/*EntityStates.HANDOverclocked.FireRocketSmash.effectPrefab = Resources.Load<GameObject>("prefabs/effects/omnieffect/omniexplosionvfx");
EntityStates.HANDOverclocked.FireRocketSmash.jumpForce = 27f;
EntityStates.HANDOverclocked.FireRocketSmash.forceMagnitude = 3000f;
EntityStates.HANDOverclocked.FireRocketSmash.damageCoefficientMin = 3f;
EntityStates.HANDOverclocked.FireRocketSmash.damageCoefficientMax = 12f;
EntityStates.HANDOverclocked.FireRocketSmash.radius = 9f;
EntityStates.HANDOverclocked.FireRocketSmash.baseDuration = 0.3f;
LoadoutAPI.AddSkill(typeof(EntityStates.HANDOverclocked.FireRocketSmash));*/

/*EntityStates.HANDOverclocked.ChargeSlam.baseDuration = 1.0f;
EntityStates.HANDOverclocked.Slam.baseDuration = 0.8f;
EntityStates.HANDOverclocked.Slam.damageCoefficient = 6f;
EntityStates.HANDOverclocked.Slam.baseMinDuration = 0.4f;
EntityStates.HANDOverclocked.Slam.forceMagnitude = 2000f;
EntityStates.HANDOverclocked.Slam.airbornVerticalForce = -2400f;
EntityStates.HANDOverclocked.Slam.shorthopVelocityFromHit = 24f;
EntityStates.HANDOverclocked.Slam.hitEffectPrefab = Resources.Load<GameObject>("prefabs/effects/impacteffects/ImpactToolbotDashLarge");
EntityStates.HANDOverclocked.Slam.impactEffectPrefab = Resources.Load<GameObject>("prefabs/effects/impacteffects/PodGroundImpact");
EntityStates.HANDOverclocked.Slam.swingEffectPrefab = null;
EntityStates.HANDOverclocked.Slam.returnToIdlePercentage = 0.443662f;
LoadoutAPI.AddSkill(typeof(EntityStates.HANDOverclocked.ChargeSlam));
LoadoutAPI.AddSkill(typeof(EntityStates.HANDOverclocked.Slam));*/

/*SkillDef utilitySkill = SkillDef.CreateInstance<SkillDef>();
utilitySkill.activationState = new SerializableEntityStateType(typeof(EntityStates.HANDOverclocked.BlastOff));
utilitySkill.skillNameToken = "BLASTOFF";
utilitySkill.skillName = "BlastOff";
utilitySkill.skillDescriptionToken = "Engage thrusters and <style=cIsUtility>take flight</style>, <style=cIsDamage>stunning</style> nearby enemies for <style=cIsDamage>" + EntityStates.HANDOverclocked.BlastOff.damageCoefficient.ToString("P0").Replace(" ", "") + " damage</style>.";
utilitySkill.noSprint = false;
utilitySkill.canceledFromSprinting = false;
utilitySkill.baseRechargeInterval = 5f;
utilitySkill.baseMaxStock = 1;
utilitySkill.rechargeStock = 1;
utilitySkill.isBullets = false;
utilitySkill.shootDelay = 0.1f;
utilitySkill.beginSkillCooldownOnSkillEnd = false;
utilitySkill.activationStateMachineName = "Hook";
utilitySkill.interruptPriority = EntityStates.InterruptPriority.Skill;
utilitySkill.isCombatSkill = false;
utilitySkill.mustKeyPress = true;
utilitySkill.icon = skillComponent.utility.skillFamily.variants[0].skillDef.icon;
utilitySkill.requiredStock = 1;
utilitySkill.stockToConsume = 1;
LoadoutAPI.AddSkillDef(utilitySkill);*/

/*SkillDef utilitySkill = SkillDef.CreateInstance<SkillDef>();
utilitySkill.activationState = new SerializableEntityStateType(typeof(EntityStates.HANDOverclocked.ChargeSpin));
utilitySkill.skillNameToken = "OVERDRIVE";
utilitySkill.skillName = "Overdrive";
utilitySkill.skillDescriptionToken = "todo";
utilitySkill.noSprint = false;
utilitySkill.canceledFromSprinting = false;
utilitySkill.baseRechargeInterval = 6f;
utilitySkill.baseMaxStock = 1;
utilitySkill.rechargeStock = 1;
utilitySkill.isBullets = false;
utilitySkill.shootDelay = 0.1f;
utilitySkill.beginSkillCooldownOnSkillEnd = true;
utilitySkill.activationStateMachineName = "Weapon";
utilitySkill.interruptPriority = EntityStates.InterruptPriority.Skill;
utilitySkill.isCombatSkill = false;
utilitySkill.mustKeyPress = false;
utilitySkill.icon = skillComponent.utility.skillFamily.variants[0].skillDef.icon;
utilitySkill.requiredStock = 1;
utilitySkill.stockToConsume = 1;
LoadoutAPI.AddSkillDef(utilitySkill);*/

/*SkillDef utilitySkill = SkillDef.CreateInstance<SkillDef>();
utilitySkill.activationState = new SerializableEntityStateType(typeof(EntityStates.HANDOverclocked.ChargeRocketSmash));
utilitySkill.skillNameToken = "OVERDRIVE";
utilitySkill.skillName = "Overdrive";
utilitySkill.skillDescriptionToken = "todo";
utilitySkill.noSprint = false;
utilitySkill.canceledFromSprinting = false;
utilitySkill.baseRechargeInterval = 6f;
utilitySkill.baseMaxStock = 1;
utilitySkill.rechargeStock = 1;
utilitySkill.isBullets = false;
utilitySkill.shootDelay = 0.1f;
utilitySkill.beginSkillCooldownOnSkillEnd = true;
utilitySkill.activationStateMachineName = "Weapon";
utilitySkill.interruptPriority = EntityStates.InterruptPriority.Skill;
utilitySkill.isCombatSkill = false;
utilitySkill.mustKeyPress = false;
utilitySkill.icon = skillComponent.utility.skillFamily.variants[0].skillDef.icon;
utilitySkill.requiredStock = 1;
utilitySkill.stockToConsume = 1;
LoadoutAPI.AddSkillDef(utilitySkill);*/
#endregion

namespace EntityStates.HANDOverclocked
{
    public class BlastOff : BaseState
    {
        public override void OnEnter()
        {
            base.OnEnter();

            Util.PlaySound("Play_MULT_m2_main_explode", base.gameObject);

            if (base.isAuthority)
            {
                EffectManager.SpawnEffect(BlastOff.effectPrefab, new EffectData
                {
                    origin = base.transform.position,
                    scale = BlastOff.radius
                }, true);
                new BlastAttack
                {
                    attacker = base.gameObject,
                    inflictor = base.gameObject,
                    teamIndex = TeamComponent.GetObjectTeam(base.gameObject),
                    baseDamage = this.damageStat * BlastOff.damageCoefficient,
                    baseForce = BlastOff.forceMagnitude,
                    position = base.transform.position,
                    radius = BlastOff.radius,
                    procCoefficient = 1f,
                    falloffModel = BlastAttack.FalloffModel.None,
                    damageType = DamageType.Stun1s,
                    crit = RollCrit(),
                    attackerFiltering = AttackerFiltering.NeverHit
                }.Fire();
            }
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.characterMotor && base.characterDirection)
            {
                if (base.characterMotor.isGrounded)
                {
                    base.characterMotor.rootMotion += Vector3.up;
                }
                base.characterMotor.disableAirControlUntilCollision = false;
                base.characterMotor.velocity.y = BlastOff.jumpForce;
            }

            if (base.fixedAge >= BlastOff.baseDuration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                return;
            }
        }

        public static GameObject effectPrefab;
        public static float airbornVerticalForce;
        public static float jumpForce;
        public static float forceMagnitude;
        public static float damageCoefficient;
        public static float radius;
        public static float baseDuration;
    }

    public class ChargeSlam : BaseState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            Util.PlaySound("Play_MULT_m2_aim", base.gameObject);
            this.duration = ChargeSlam.baseDuration / this.attackSpeedStat;
            this.modelAnimator = base.GetModelAnimator();
            if (this.modelAnimator)
            {
                base.PlayAnimation("Gesture", "ChargeSlam", "ChargeSlam.playbackRate", this.duration);
            }
            if (base.characterBody)
            {
                base.characterBody.SetAimTimer(4f);
            }
        }

        public override void OnExit()
        {
            Util.PlaySound("Play_MULT_m2_throw", base.gameObject);
            base.OnExit();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.fixedAge >= this.duration && base.isAuthority && !base.inputBank.skill2.down)
            {
                this.outer.SetNextState(new EntityStates.HANDOverclocked.Slam());
                return;
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public static float baseDuration;
        private float duration;
        private Animator modelAnimator;
    }

    public class Slam : BaseState
    {
        private void DealDamage()
        {
            if (!this.hasSwung)
            {
                this.hasSwung = true;
                Vector3 directionFlat = base.GetAimRay().direction;
                directionFlat.y = 0;
                directionFlat.Normalize();

                for (int i = 5; i <= 23; i += 2)
                {
                    EffectManager.SpawnEffect(Slam.impactEffectPrefab, new EffectData
                    {
                        origin = base.transform.position + i * directionFlat.normalized - 1.8f * Vector3.up,
                        scale = 0.5f
                    }, true);
                }

                HANDHitResult hitCount = new HAND_OVERCLOCKED.HANDSwingAttack
                {
                    scaleForceMass = true,
                    attacker = base.gameObject,
                    inflictor = base.gameObject,
                    teamIndex = TeamComponent.GetObjectTeam(base.gameObject),
                    baseDamage = this.damageStat * Slam.damageCoefficient,
                    position = base.transform.position + 11f * directionFlat.normalized,
                    extents = new Vector3(4.2f, 6f, 23f),
                    orientation = Quaternion.LookRotation(directionFlat, Vector3.up),
                    procCoefficient = 1f,
                    crit = RollCrit(),
                    force = Vector3.zero,
                    airbornVerticalForce = Slam.airbornVerticalForce,
                    damageType = (base.characterBody.HasBuff(HAND_OVERCLOCKED.HAND_OVERCLOCKED.OverclockBuff) && Util.CheckRoll(base.characterBody.skillLocator.special.stock * HAND_OVERCLOCKED.HAND_OVERCLOCKED.ovcShockChancePerDrone)) ? DamageType.Shock5s : DamageType.Stun1s,
                    overwriteVerticalVelocity = true,
                    groundedVerticalForce = Slam.forceMagnitude,
                    hitEffectPrefab = Slam.hitEffectPrefab
                }.Fire();
                BeginHitPause();
                if (hitCount.hitCount > 0)
                {
                    //BeginHitPause();
                    /*if (NetworkServer.active)
                    {
                        int ovcCount = base.characterBody.GetBuffCount(HAND_OVERCLOCKED.HAND_OVERCLOCKED.OverclockBuff);
                        base.characterBody.ClearTimedBuffs(HAND_OVERCLOCKED.HAND_OVERCLOCKED.OverclockBuff);
                        if (ovcCount < HAND_OVERCLOCKED.HAND_OVERCLOCKED.maxOverclock)
                        {
                            ovcCount++;
                        }
                        for (int i = 0; i < ovcCount; i++)
                        {
                            base.characterBody.AddTimedBuff(HAND_OVERCLOCKED.HAND_OVERCLOCKED.OverclockBuff, HAND_OVERCLOCKED.HAND_OVERCLOCKED.overclockBaseDecay + i * HAND_OVERCLOCKED.HAND_OVERCLOCKED.overclockDecay);
                        }
                    }*/
                    hc = base.gameObject.GetComponent<HANDController>();
                    if (hc)
                    {
                        hc.MeleeHit(hitCount);
                        hc.ExtendOverclock(5f);
                    }
                }
            }
        }
        public override void OnEnter()
        {
            base.OnEnter();
            Util.PlaySound("Play_parent_attack1_slam", base.gameObject);
            this.duration = Slam.baseDuration / this.attackSpeedStat;
            this.minDuration = Slam.baseMinDuration / this.attackSpeedStat;
            this.modelAnimator = base.GetModelAnimator();
            Transform modelTransform = base.GetModelTransform();
            if (modelTransform)
            {
                ChildLocator component = modelTransform.GetComponent<ChildLocator>();
                if (component)
                {
                    this.hammerChildTransform = component.FindChild("SwingCenter");
                }
            }
            if (this.modelAnimator)
            {
                base.PlayAnimation("Gesture", "Slam", "Slam.playbackRate", this.duration);
            }
            if (base.characterBody)
            {
                base.characterBody.SetAimTimer(2f);
            }
        }

        public override void OnExit()
        {
            if (!this.hasSwung)
            {
                this.DealDamage();
                if (this.enteredHitPause)
                {
                    this.ExitHitPause();
                }
            }
            if (this.enteredHitPause && !this.exitedHitPause)
            {
                this.ExitHitPause();
            }
            base.OnExit();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (this.modelAnimator && this.modelAnimator.GetFloat("Hammer.hitBoxActive") > 0.5f)
            {
                if (!this.hasSwung)
                {
                    this.DealDamage();
                    EffectManager.SimpleMuzzleFlash(Slam.swingEffectPrefab, base.gameObject, "SwingCenter", false);
                }
            }
            if (base.fixedAge >= this.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                return;
            }
            if (base.isAuthority && this.enteredHitPause && this.hitPauseTimer > 0f)
            {
                this.hitPauseTimer -= Time.fixedDeltaTime;
                base.characterMotor.velocity = Vector3.zero;
                if (this.hitPauseTimer <= 0f)
                {
                    this.ExitHitPause();
                }
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            if (hasSwung && base.fixedAge >= this.minDuration)
            {
                return InterruptPriority.Any;
            }
            return InterruptPriority.PrioritySkill;
        }

        private void BeginHitPause()
        {
            this.enteredHitPause = true;
            this.storedVelocity = base.characterMotor.velocity;
            base.characterMotor.velocity = Vector3.zero;
            if (this.modelAnimator)
            {
                this.modelAnimator.speed = 0f;
            }
            this.hitPauseTimer = this.hitPauseDuration;
        }

        private void ExitHitPause()
        {
            this.hitPauseTimer = 0f;
            if (!base.isGrounded)
            {
                this.storedVelocity.y = Mathf.Max(this.storedVelocity.y, Slam.shorthopVelocityFromHit);
            }
            base.characterMotor.velocity = this.storedVelocity;
            this.storedVelocity = Vector3.zero;
            if (this.modelAnimator)
            {
                this.modelAnimator.speed = 1f;
            }
            this.exitedHitPause = true;
        }

        public static float baseDuration;
        public static float baseMinDuration;
        public static float returnToIdlePercentage;
        public static float damageCoefficient;
        public static float forceMagnitude;
        public static float airbornVerticalForce;

        public static GameObject impactEffectPrefab;
        public static GameObject hitEffectPrefab;
        public static GameObject swingEffectPrefab;
        private Transform hammerChildTransform;
        private Animator modelAnimator;
        private float duration;
        private float minDuration;
        private bool hasSwung;

        private Vector3 storedVelocity;
        private float hitPauseTimer = 0f;
        private float hitPauseDuration = 0.1f;
        private bool enteredHitPause = false;
        private bool exitedHitPause = false;

        private HANDController hc;

        public static float shorthopVelocityFromHit;
    }

    public class Overheat : BaseState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            Util.PlaySound(Overheat.soundString, base.gameObject);
            EffectManager.SpawnEffect(Overheat.effectPrefab, new EffectData
            {
                origin = base.transform.position,
                scale = Overheat.radius
            }, false);
            if (NetworkServer.active)
            {
                base.healthComponent.HealFraction(Overheat.healPercent, new ProcChainMask());
                new BlastAttack()
                {
                    attacker = base.gameObject,
                    inflictor = base.gameObject,
                    teamIndex = TeamComponent.GetObjectTeam(base.gameObject),
                    baseDamage = this.damageStat * Overheat.damageCoefficient,
                    baseForce = 0f,
                    position = base.transform.position,
                    radius = Overheat.radius,
                    falloffModel = BlastAttack.FalloffModel.None,
                    damageType = DamageType.IgniteOnHit,
                    attackerFiltering = AttackerFiltering.NeverHit
                }.Fire();
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.fixedAge >= Overheat.baseDuration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                return;
            }
        }

        public static float damageCoefficient;
        public static float radius;
        public static float healPercent;
        public static GameObject effectPrefab;
        public static float baseDuration;
        public static string soundString;
    }

    public class ChargeSpin : BaseState //Scrapped because being able to rapid hit with HAN-D felt plain wrong. Also charging seemed to break up his skill flow too much.
    {
        public override void OnEnter()
        {
            base.OnEnter();
            spinCount = 0;
            charge = 0;
            chargePartDuration = baseChargePartDuration / this.attackSpeedStat;
            Util.PlaySound("Play_loader_shift_activate", base.gameObject);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (spinCount < maxSpinCount)
            {
                this.charge += Time.fixedDeltaTime * this.attackSpeedStat;
                if (charge >= chargePartDuration)
                {
                    charge -= chargePartDuration;
                    spinCount++;
                    EffectManager.SpawnEffect(chargeEffectPrefab, new EffectData
                    {
                        origin = base.transform.position
                    }, true);
                    Util.PlaySound("Play_engi_M1_chargeStock", base.gameObject);
                }
            }
            if (spinCount >= baseSpinCount && (!base.inputBank || (!base.inputBank.skill3.down && base.isAuthority)))
            {
                this.outer.SetNextState(new SpinAttack { spins = spinCount });
                return;
            }
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public static float baseChargePartDuration;
        public static int baseSpinCount;
        public static int maxSpinCount;
        public static GameObject chargeEffectPrefab = Resources.Load<GameObject>("prefabs/effects/omnieffect/OmniImpactVFXLoader");

        private float charge;
        private float chargePartDuration;
        private int spinCount;
    }

    public class SpinAttack : BaseState //Hitboxes and physics were poorly done, but the ultimate reason why this was cut was because rapid hit felt wrong on HAN-D.
    {
        public override void OnEnter()
        {
            base.OnEnter();
            Util.PlaySound("Play_loader_shift_release", base.gameObject);
            //grounded = base.characterMotor.isGrounded;
            grounded = false;
            stopwatch = swingDuration;
            swingDuration = baseSwingDuration;
            modelAnimator = base.GetModelAnimator();
            if (grounded && base.characterDirection && base.inputBank)
            {
                base.characterDirection.forward = base.inputBank.aimDirection;
                groundDirection = base.characterDirection.forward * groundVelocity;
            }
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.isAuthority && this.inHitPause && this.hitPauseTimer > 0f)
            {
                this.hitPauseTimer -= Time.fixedDeltaTime;
                base.characterMotor.velocity = Vector3.zero;
                if (this.hitPauseTimer <= 0f)
                {
                    this.ExitHitPause();
                }
            }
            if (base.characterMotor && base.characterDirection)
            {
                if (!grounded)
                {
                    if (base.characterMotor.isGrounded)
                    {
                        base.characterMotor.rootMotion += Vector3.up;
                    }
                    base.characterMotor.velocity.y = SpinAttack.airVelocity;
                }
                else
                {
                    if (!inHitPause)
                    {
                        base.characterMotor.velocity.x = groundDirection.x;
                        base.characterMotor.velocity.z = groundDirection.z;
                    }
                }
            }
            stopwatch += Time.fixedDeltaTime;
            if (stopwatch >= swingDuration)
            {
                stopwatch -= swingDuration;
                if (spins > 0)
                {
                    spins--;
                    Util.PlaySound("Play_loader_m1_swing", base.gameObject);

                    if (this.modelAnimator)
                    {
                        int layerIndex = this.modelAnimator.GetLayerIndex("Gesture");
                        if (this.modelAnimator.GetCurrentAnimatorStateInfo(layerIndex).IsName("FullSwing3") || this.modelAnimator.GetCurrentAnimatorStateInfo(layerIndex).IsName("FullSwing1"))
                        {
                            base.PlayCrossfade("Gesture", "FullSwing2", "FullSwing.playbackRate", this.swingDuration / (1f - FullSwing.returnToIdlePercentage), 0.2f);
                        }
                        else if (this.modelAnimator.GetCurrentAnimatorStateInfo(layerIndex).IsName("FullSwing2"))
                        {
                            base.PlayCrossfade("Gesture", "FullSwing3", "FullSwing.playbackRate", this.swingDuration / (1f - FullSwing.returnToIdlePercentage), 0.2f);
                        }
                        else
                        {
                            base.PlayCrossfade("Gesture", "FullSwing1", "FullSwing.playbackRate", this.swingDuration / (1f - FullSwing.returnToIdlePercentage), 0.2f);
                        }
                    }
                    if (base.isAuthority)
                    {
                        directionFlat = base.GetAimRay().direction;
                        directionFlat.y = 0;
                        directionFlat.Normalize();
                        HANDHitResult hitCount = new HANDSwingAttack
                        {
                            scaleForceMass = grounded ? false : true,
                            attacker = base.gameObject,
                            inflictor = base.gameObject,
                            teamIndex = TeamComponent.GetObjectTeam(base.gameObject),
                            baseDamage = this.damageStat * SpinAttack.damageCoefficient,
                            position = base.transform.position,
                            useSphere = true,
                            radius = 10f,
                            orientation = Quaternion.LookRotation(directionFlat, Vector3.up),
                            procCoefficient = 1f,
                            crit = RollCrit(),
                            force = Vector3.zero,
                            airbornVerticalForce = 0f,
                            airbornHorizontalForceMult = 0f,
                            flyingHorizontalForceMult = 0f,
                            damageType = DamageType.Stun1s,
                            landEnemyVerticalForce = grounded ? 0f : 1000f
                        }.Fire();
                        if (hitCount.hitCount > 0)
                        {
                            Util.PlaySound("Play_MULT_shift_hit", base.gameObject);
                            if (grounded)
                            {
                                BeginHitPause();
                            }
                            base.gameObject.GetComponent<HANDController>().MeleeHit(hitCount);
                        }
                    }
                }
                else
                {
                    this.outer.SetNextStateToMain();
                    return;
                }
            }
        }
        public override void OnExit()
        {
            if (inHitPause)
            {
                this.ExitHitPause();
            }
            base.OnExit();
        }
        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }

        private void BeginHitPause()
        {
            this.inHitPause = true;
            this.storedVelocity = base.characterMotor.velocity;
            base.characterMotor.velocity = Vector3.zero;
            if (this.modelAnimator)
            {
                this.modelAnimator.speed = 0f;
            }
            this.hitPauseTimer = this.hitPauseDuration;
        }

        private void ExitHitPause()
        {
            this.hitPauseTimer = 0f;
            base.characterMotor.velocity = this.storedVelocity;
            this.storedVelocity = Vector3.zero;
            if (this.modelAnimator)
            {
                this.modelAnimator.speed = 1f;
            }
            this.inHitPause = false;
        }

        public int spins = 1;
        private bool grounded;
        private float swingDuration;
        private float stopwatch;
        private Animator modelAnimator;
        private Vector3 groundDirection;
        private Vector3 directionFlat;

        public static float damageCoefficient;
        public static float baseSwingDuration;
        public static float groundVelocity;
        public static float airVelocity;
        public static float smallHopVelocity;

        private Vector3 storedVelocity;
        private float hitPauseTimer = 0f;
        private float hitPauseDuration = 0.1f;
        private bool inHitPause = false;
    }

    public class ChargeRocketSmash : BaseState  //Scrapped because it didn't really feel different from BlastOff at all, and charging broke up HAN-D's skill flow too much.
    {
        public override void OnEnter()
        {
            base.OnEnter();
            chargeDuration = baseChargeDuration / this.attackSpeedStat;
            Util.PlaySound("Play_loader_shift_activate", base.gameObject);
            defaultCrosshairPrefab = base.characterBody.crosshairPrefab;
            base.characterBody.crosshairPrefab = specialCrosshairPrefab;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (charge < chargeDuration)
            {
                this.charge += Time.fixedDeltaTime * this.attackSpeedStat;
                if (charge >= chargeDuration)
                {
                    charge = chargeDuration;
                    EffectManager.SpawnEffect(chargeEffectPrefab, new EffectData
                    {
                        origin = base.transform.position
                    }, true);
                }
                this.chargePercent = charge / chargeDuration;
                base.characterBody.SetSpreadBloom(1.25f * (1f - chargePercent), false);
            }
            if (!base.inputBank || (!base.inputBank.skill3.down && base.isAuthority))
            {
                this.outer.SetNextState(new FireRocketSmash { chargePercent = this.chargePercent });
                return;
            }
        }

        public override void OnExit()
        {
            base.characterBody.crosshairPrefab = defaultCrosshairPrefab;
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public static float baseChargeDuration;
        public static GameObject chargeEffectPrefab = Resources.Load<GameObject>("prefabs/effects/omnieffect/OmniImpactVFXLoader");

        private float charge;
        private float chargeDuration;
        private float chargePercent;

        private GameObject defaultCrosshairPrefab;
        private GameObject specialCrosshairPrefab = Resources.Load<GameObject>("prefabs/crosshair/LoaderCrosshair");
    }

    public class FireRocketSmash : BaseState    //Hitbox was poorly done, but the ultimate reason why this was cut was because it was too similar to BlastOff.
    {
        public override void OnEnter()
        {
            base.OnEnter();

            Util.PlaySound("Play_loader_shift_release", base.gameObject);

            this.modelAnimator = base.GetModelAnimator();
            Transform modelTransform = base.GetModelTransform();
            if (modelTransform)
            {
                ChildLocator component = modelTransform.GetComponent<ChildLocator>();
                if (component)
                {
                    this.hammerChildTransform = component.FindChild("SwingCenter");
                }
            }
            if (this.modelAnimator)
            {
                int layerIndex = this.modelAnimator.GetLayerIndex("Gesture");
                if (this.modelAnimator.GetCurrentAnimatorStateInfo(layerIndex).IsName("FullSwing3") || this.modelAnimator.GetCurrentAnimatorStateInfo(layerIndex).IsName("FullSwing1"))
                {
                    base.PlayCrossfade("Gesture", "FullSwing2", "FullSwing.playbackRate", FireRocketSmash.baseDuration / (1f - FullSwing.returnToIdlePercentage), 0.2f);
                }
                else if (this.modelAnimator.GetCurrentAnimatorStateInfo(layerIndex).IsName("FullSwing2"))
                {
                    base.PlayCrossfade("Gesture", "FullSwing3", "FullSwing.playbackRate", FireRocketSmash.baseDuration / (1f - FullSwing.returnToIdlePercentage), 0.2f);
                }
                else
                {
                    base.PlayCrossfade("Gesture", "FullSwing1", "FullSwing.playbackRate", FullSwing.baseDuration / (1f - FullSwing.returnToIdlePercentage), 0.2f);
                }
            }

            if (base.isAuthority)
            {
                Vector3 directionFlat = base.GetAimRay().direction;
                directionFlat.y = 0;
                directionFlat.Normalize();
                HANDHitResult hitCount = new HANDSwingAttack
                {
                    scaleForceMass = true,
                    attacker = base.gameObject,
                    inflictor = base.gameObject,
                    teamIndex = TeamComponent.GetObjectTeam(base.gameObject),
                    baseDamage = this.damageStat * Mathf.Lerp(damageCoefficientMin, damageCoefficientMax, chargePercent),
                    position = base.transform.position,
                    useSphere = true,
                    radius = 10f,
                    orientation = Quaternion.LookRotation(directionFlat, Vector3.up),
                    procCoefficient = 1f,
                    crit = RollCrit(),
                    force = Vector3.zero,
                    airbornVerticalForce = 0f,
                    airbornHorizontalForceMult = 0f,
                    flyingHorizontalForceMult = 0f,
                    damageType = DamageType.Stun1s,
                    landEnemyVerticalForce = Mathf.Lerp(0f, forceMagnitude, chargePercent)
                }.Fire();
                if (hitCount.hitCount > 0)
                {
                    Util.PlaySound("Play_MULT_shift_hit", base.gameObject);
                    base.gameObject.GetComponent<HANDController>().MeleeHit(hitCount);
                }
            }
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.characterMotor && base.characterDirection)
            {
                if (base.characterMotor.isGrounded)
                {
                    base.characterMotor.rootMotion += Vector3.up;
                }
                base.characterMotor.disableAirControlUntilCollision = false;
                base.characterMotor.velocity.y = FireRocketSmash.jumpForce;
            }

            if (base.fixedAge >= FireRocketSmash.baseDuration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                return;
            }
        }

        public static GameObject effectPrefab;
        public static float jumpForce;
        public static float forceMagnitude;
        public static float damageCoefficientMin;
        public static float damageCoefficientMax;
        public static float radius;
        public static float baseDuration;

        public float chargePercent;

        private Transform hammerChildTransform;
        private Animator modelAnimator;
    }
}
//apolgoies for not committing sooner, i was jerkin it to a really fucking hot doujin
