using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Extensions;

namespace RubickRage.Core.Logics
{
    public static class ModWatcherLogic
    {
        public static void OnUpdate()
        {
            foreach (var _Enemy in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsIllusion == false))
            {
                if (_Enemy.ClassId == ClassId.CDOTA_Unit_Hero_StormSpirit)
                {
                    if (_Enemy.HasModifier("modifier_storm_spirit_ball_lightning"))
                    {
                        Core.Config._StormLastUlt = Game.RawGameTime;
                    }
                }
            }
        }
    }
}
