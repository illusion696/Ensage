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
    public static class GlimmerCUltLogic
    {
        public static Item _Glimmer;
        public static void OnUpdate()
        {
            if (Core.Config._Menu.GlimmerCUlts.GlimmerForkeyDown)
            {
                _Glimmer = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_glimmer_cape);
                if (_Glimmer != null && _Glimmer.CanBeCasted())
                {
                    foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team == Core.Config._Hero.Team && x.IsAlive && x.IsVisible))
                    {
                        var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => (x.IsInAbilityPhase || x.IsChanneling) &&
                        (x.Id == AbilityId.crystal_maiden_freezing_field || x.Id == AbilityId.witch_doctor_death_ward || x.Id == AbilityId.bane_fiends_grip));
                        if (anyAbility != null)
                        {
                            var _AId = anyAbility.Name;
                            if (Core.Config._Menu.GlimmerCUlts.GlimmerFor[_AId])
                            {
                                if (_Glimmer.CastRange < v.Distance2D(Core.Config._Hero.Position))
                                {
                                    var _Item2 = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_blink);
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
