using Ensage;
using Ensage.Common.Extensions;
using Ensage.Common.Objects.UtilityObjects;
using Ensage.SDK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class LinkenSaveLogic
    {
        public static Item _Linken;
        public static void OnUpdate()
        {
            if (Core.Config._Menu.LinkenSave.SavekeyDown)
            {
                _Linken = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_sphere);
                if (_Linken != null && _Linken.CanBeCasted())
                {
                    foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team && x.IsAlive && x.IsVisible))
                    {
                        var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                        if (anyAbility != null)
                        {
                            var _AId = anyAbility.Name;
                            if (Core.Config._Menu.LinkenSave.SaveFromKeys.Contains(_AId))
                            {
                                if (Core.Config._Menu.LinkenSave.SaveFrom[_AId])
                                {
                                    var _Target = EntityManager<Hero>.Entities.Where(x => x.Team == Core.Config._Hero.Team && x.IsAlive).OrderBy(x => v.FindRelativeAngle(x.Position)).FirstOrDefault();

                                    if (_Target != null)
                                    {
                                        if (_Linken.CastRange < _Target.Distance2D(Core.Config._Hero.Position))
                                        {
                                            var _Item2 = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_blink);
                                            if (_Item2 != null && _Item2.CanBeCasted())
                                            {
                                                _Item2.UseAbility(_Target.Position);
                                                _Linken.UseAbility(_Target);
                                            }
                                        }
                                        else
                                        {
                                            _Linken.UseAbility(_Target);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
