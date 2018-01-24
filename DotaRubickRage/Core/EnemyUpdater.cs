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
            //foreach (var _Hero in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsIllusion == false))
            //{
            //    //npc_dota_hero_
            //    var _Temp = _Hero.Name.Substring(14);
            //    if (Drawings.BombStack._Heroes.Contains(_Temp) == false)
            //    {
            //        Config._Renderer.TextureManager.LoadFromDota(_Temp, $"resource\\flash3\\images\\heroes\\{_Temp}.png");
            //        Drawings.BombStack._Heroes.Add(_Temp);

            //        Config._HeroesFullNames.Add(_Hero.Name);
            //    }
            //}
        }
    }
}
