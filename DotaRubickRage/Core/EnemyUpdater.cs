using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensage;
using Ensage.SDK.Helpers;

namespace RubickRage.Core
{
    public static class EnemyUpdater
    {
        public static void OnUpdate()
        {
            foreach (var _Hero in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsIllusion == false))
            {
                if (Config._HeroesFullNames.Contains(_Hero.Name) == false)
                {
                    Core.Config._Menu.GlimmerSave.ReBind();
                    Core.Config._Menu.LinkenSave.ReBind();
                    Core.Config._Menu.LotusCombo.ReBind();
                    Core.Config._Menu.Steal.ReBind();
                    Config._HeroesFullNames.Add(_Hero.Name);
                }
            }
        }
    }
}
