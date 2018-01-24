using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensage;
using Ensage.SDK.Extensions;

namespace RubickRage.Core.Helpers
{
    public static class TargetChecker
    {
        public static Boolean PreCheck(Hero _Enemy)
        {
            if (_Enemy.IsValid == false) return false;
            if (_Enemy.Health <= 1) return false;
            if (_Enemy.IsVisible == false) return false;
            if (_Enemy.IsAlive == false) return false;
            if (Sleeper.IsSleep(_Enemy.Name)) return false;
            if (_Enemy.HasModifiers(Config._BlockModiffers, false))
            {
                return false;
            }
            if (_Enemy.IsMagicImmune()) return false;

            return true;
        }
    }
}
