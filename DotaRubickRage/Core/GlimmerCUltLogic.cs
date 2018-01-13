using System.Linq;
using Ensage;
using Ensage.Common.Enums;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using AbilityId = Ensage.AbilityId;

namespace RubickRage.Core
{
    public static class GlimmerCUltLogic
    {
        public static Item _Glimmer;
        public static void OnUpdate()
        {
            if (Config._Menu.GlimmerCUlts.ForkeyDown || Config._Menu.GlimmerCUlts.ToggleEnabled)
            {
                _Glimmer = Config._Hero.GetItemById(ItemId.item_glimmer_cape);
                if (_Glimmer != null && _Glimmer.CanBeCasted())
                {
                    foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team == Config._Hero.Team && x.IsAlive && x.IsVisible))
                    {
                        var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => (x.IsInAbilityPhase || x.IsChanneling) &&
                        (x.Id == AbilityId.crystal_maiden_freezing_field || x.Id == AbilityId.witch_doctor_death_ward || x.Id == AbilityId.bane_fiends_grip));
                        if (anyAbility != null)
                        {
                            var _AId = anyAbility.Name;
                            if (Config._Menu.GlimmerCUlts.For[_AId])
                            {
                                if (_Glimmer.CastRange < v.Distance2D(Config._Hero.Position))
                                {
                                    var _Item2 = Config._Hero.GetItemById(ItemId.item_blink);
                                    if (_Item2 != null && _Item2.CanBeCasted())
                                    {
                                        _Item2.UseAbility(v.Position);
                                        _Glimmer.UseAbility(v);
                                    }
                                }
                                else
                                {
                                    _Glimmer.UseAbility(v);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
