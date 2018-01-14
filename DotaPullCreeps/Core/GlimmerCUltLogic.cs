using System.Linq;
using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using AbilityId = Ensage.AbilityId;

namespace SupportsRage.Core
{
    public static class GlimmerCUltLogic
    {
        public static void OnUpdate()
        {
            if (Config._Menu.GlimmerCUlts.ForkeyDown || Config._Menu.GlimmerCUlts.ToggleEnabled)
            {
                if (Config._Items.Glimmer != null && Config._Items.Glimmer.CanBeCasted)
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
                                if (Config._Items.Glimmer.CastRange < v.Distance2D(Config._Hero.Position))
                                {
                                    if (Config._Items.Blink != null && Config._Items.Blink.CanBeCasted)
                                    {
                                        Config._Items.Blink.UseAbility(v.Position);
                                        Config._Items.Glimmer.UseAbility(v);
                                    }
                                }
                                else
                                {
                                    Config._Items.Glimmer.UseAbility(v);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
