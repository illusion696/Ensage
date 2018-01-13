using System.Linq;
using Ensage;
using Ensage.Common.Enums;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;

namespace SupportsRage.Core
{
    public static class LotusSaveLogic
    {
        public static Item _Lotus;
        public static void OnUpdate()
        {
            if (Config._Menu.LotusSave.SavekeyDown || Config._Menu.LotusSave.ToggleEnabled)
            {
                _Lotus = Config._Hero.GetItemById(ItemId.item_lotus_orb);
                if (_Lotus != null && _Lotus.CanBeCasted())
                {
                    foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
                    {
                        var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                        if (anyAbility != null)
                        {
                            var _AId = anyAbility.Name;
                            if (Config._Menu.LotusSave.SaveFromKeys.Contains(_AId))
                            {
                                if (Config._Menu.LotusSave.SaveFrom[_AId])
                                {
                                    var _Target = EntityManager<Hero>.Entities.Where(x => x.Team == Config._Hero.Team && x.IsAlive && x.Distance2D(v) <= anyAbility.CastRange).OrderBy(x => v.FindRelativeAngle(x.Position)).FirstOrDefault();

                                    if (_Target != null)
                                    {
                                        if (_Lotus.CastRange < _Target.Distance2D(Config._Hero.Position))
                                        {
                                            var _Item2 = Config._Hero.GetItemById(ItemId.item_blink);
                                            if (_Item2 != null && _Item2.CanBeCasted())
                                            {
                                                _Item2.UseAbility(_Target.Position);
                                                _Lotus.UseAbility(_Target);
                                            }
                                        }
                                        else
                                        {
                                            _Lotus.UseAbility(_Target);
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
