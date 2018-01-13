using System.Linq;
using Ensage;
using Ensage.Common.Enums;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;

namespace SupportsRage.Core
{
    public static class GlimmerSaveLogic
    {
        public static Item _Glimmer;
        public static void OnUpdate()
        {
            if (Config._Menu.GlimmerSave.SavekeyDown || Config._Menu.GlimmerSave.ToggleEnabled)
            {
                _Glimmer = Config._Hero.GetItemById(ItemId.item_glimmer_cape);
                if (_Glimmer != null && _Glimmer.CanBeCasted())
                {
                    foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
                    {
                        var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                        if (anyAbility != null)
                        {
                            var _AId = anyAbility.Name;
                            if (Config._Menu.GlimmerSave.SaveFromKeys.Contains(_AId))
                            {
                                if (Config._Menu.GlimmerSave.SaveFrom[_AId])
                                {
                                    var _Target = EntityManager<Hero>.Entities.Where(x => x.Team == Config._Hero.Team && x.IsAlive && x.Distance2D(v) <= anyAbility.CastRange).OrderBy(x => v.FindRelativeAngle(x.Position)).FirstOrDefault();

                                    if (_Target != null)
                                    {
                                        if (_Glimmer.CastRange < _Target.Distance2D(Config._Hero.Position))
                                        {
                                            var _Item2 = Config._Hero.GetItemById(ItemId.item_blink);
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
