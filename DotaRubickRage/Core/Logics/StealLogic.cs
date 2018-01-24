using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using RubickRage.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RubickRage.Core.Logics
{
    public static class StealLogic
    {
        public static int _Status;
        private static Ability _Abiility;
        private static Ability _Stolen;
        private static int _IntNut;
        private static bool CanChange;
        private static Hero _Enemy;

        public static async Task OnUpdateTask(CancellationToken cancellationToken)
        {
            switch (_Status)
            {
                case 0:
                    {
                        foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
                        {
                            var anyAbility = v.Spellbook.Spells.MaxOrDefault(x => x.LastCastClickTime);
                            if (anyAbility != null && anyAbility.LastCastClickTime > 0 && anyAbility.IsInAbilityPhase == false && Config._Menu.Steal.SpellConfigs.ContainsKey(anyAbility.Name))
                            {
                                _Abiility = anyAbility;
                                _Status = 1;
                                _Enemy = v;
                                return;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    break;
                case 1:
                    {
                        if (Config._Menu.Steal.SpellConfigs[_Abiility.Name] == false)
                        {
                            _Status = 0;
                            return;
                        }
                        if (Config._Hero.GetAbilityById(_Abiility.Id) != null)
                        {
                            if (_Abiility.CooldownLength > 0)
                            {
                                CanChange = true;
                            }
                            else
                            {
                                CanChange = false;
                            }
                        }
                        else
                        {
                            if (_Stolen != null)
                            {
                                if (_Stolen.Cooldown == 0)
                                {
                                    CanChange = true;
                                }
                                else
                                {
                                    CanChange = false;
                                }
                            }
                            else
                            {
                                CanChange = true;
                            }
                        }

                        if (CanChange)
                        {
                            var _Steal = Config._Hero.GetAbilityById(AbilityId.rubick_spell_steal);
                            if (_Steal != null && _Steal.Level > 0)
                            {
                                if (_Steal.Cooldown == 0)
                                {
                                    _Steal.UseAbility(_Enemy);
                                    await Task.Delay(50);
                                }
                                else
                                {
                                    _Stolen = _Abiility;
                                    _Status = 0;
                                    return;
                                }


                                _IntNut++;
                                if (_IntNut >= 50)
                                {
                                    _Status = 0;
                                }
                            }
                        }
                    }
                    break;
            }
        }
    }
}