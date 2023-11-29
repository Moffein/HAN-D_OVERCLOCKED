using HANDMod.Modules.Achievements;
using RoR2;
using RoR2.Achievements;
using UnityEngine;

namespace HANDMod.Content.HANDSurvivor.Achievements
{
    [RegisterAchievement("MoffeinHANDOverclockedClearGameTyphoon", "Skins.HANDOverclocked.GrandMastery", null, null)]
    public class HandGrandMasteryAchievement : BaseGrandMasteryAchievement
    {
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("HANDOverclockedBody");
        }
    }
}
