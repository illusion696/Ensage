using Ensage;
using Ensage.Common.Extensions;
using Ensage.Common.Objects.UtilityObjects;
using Ensage.SDK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportsRage.Core
{
    public static class GlimmerSaveLogic
    {
        public static Item _Glimmer;
        public static void OnUpdate()
        {
            if (Core.Config._Menu.GlimmerSave.SavekeyDown)
            {
                _Glimmer = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_glimmer_cape);
                if (_Glimmer != null && _Glimmer.CanBeCasted())
                {
                    foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team && x.IsAlive && x.IsVisible))
                    {
                        var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                        if (anyAbility != null)
                        {
                            var _AId = anyAbility.Name;
                            if (Core.Config._Menu.GlimmerSave.SaveFromKeys.Contains(_AId))
                            {
                                if (Core.Config._Menu.GlimmerSave.SaveFrom[_AId])
                                {
                                    var _Target = EntityManager<Hero>.Entities.Where(x => x.Team == Core.Config._Hero.Team && x.IsAlive).OrderBy(x => v.FindRelativeAngle(x.Position)).FirstOrDefault();

                                    if (_Target != null)
                                    {
                                        if (_Glimmer.CastRange < _Target.Distance2D(Core.Config._Hero.Position))
                                        {
                                            var _Item2 = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_blink);
                                            if (_Item2 != null && _Item2.CanBeCasted())
                                            {
                                                _Item2.UseAbility(_Target.Position);
                                                _Glimmer.UseAbility(_Target);
                                            }
                                        }
                                        else
                                        {
                                            _Glimmer.UseAbility(_Target);
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
