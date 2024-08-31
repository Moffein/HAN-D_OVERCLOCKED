using HANDMod.Modules.Achievements;
using RoR2;
using RoR2.Achievements;
using UnityEngine;

namespace HANDMod.Content.HANDSurvivor.Achievements
{
    [RegisterAchievement("MoffeinHANDOverclockedClearGameTyphoon", "Skins.HANDOverclocked.GrandMastery", null, 15u, null)]
    public class HandGrandMasteryAchievement : BaseGrandMasteryAchievement
    {
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("HANDOverclockedBody");
        }
    }
}
