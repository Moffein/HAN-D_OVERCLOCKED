using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace EntityStates.HAND_Overclocked.Special
{
    public  class FireSpeedDrone : FireSeekingDrone
    {
        public static GameObject speedDroneProjectile;

        protected override GameObject GetProjectile()
        {
            return speedDroneProjectile;
        }
    }
}
