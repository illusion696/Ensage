using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class LotusLogic
    {
        public static int _Status;
        private static Ability _Abiility;
        private static Hero _Enemy;
        private static int _IntNut;
        private static LotusSpellConfig _Used;

        public static async Task OnUpdateTask(CancellationToken cancellationToken)
        {
            switch (_Status)
            {
                case 0:
                    {
                        foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
                        {
                            _Used = null;
                            var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                            if (anyAbility != null && Config._Menu.LotusCombo.LotusSpellConfigs.ContainsKey(anyAbility.Name))
                            {
                                _Used = Config._Menu.LotusCombo.LotusSpellConfigs[anyAbility.Name];
                            }
                            else return;

                            if (_Used == null) continue;
                            if (Config._Menu.LotusCombo.SaveFrom[anyAbility.Name] == false) continue;
                            _Abiility = anyAbility;

                            _Enemy = v;
                            _IntNut = 0;

                            if (Config._Items.Lotus != null && Config._Items.Lotus.CanBeCasted)
                            {
                                var _Target = EntityManager<Hero>.Entities.Where(x => x.Team == Config._Hero.Team && x.IsAlive).OrderBy(x => v.FindRelativeAngle(x.Position)).FirstOrDefault();

                                if (_Target != null)
                                {
                                    if (Config._Items.Lotus.CastRange < _Target.Distance2D(Config._Hero.Position))
                                    {
                                        if (Config._Items.Blink != null && Config._Items.Blink.CanBeCasted)
                                        {
                                            Config._Items.Blink.UseAbility(_Target.Position);
                                            Config._Items.Lotus.UseAbility(_Target);
                                            _Status++;
                                            break;
                                        }
                                    }
                                    else if (Config._Items.Lotus.CanBeCasted)
                                    {
                                        Config._Items.Lotus.UseAbility(_Target);
                                        _Status++;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 1:
                    {
                        if (Config._Menu.LotusCombo.LotusSpellConfigs[_Abiility.Name].Steal == false)
                        {
                            _Status = 0;
                            return;
                        }
                        _IntNut++;
                        await Task.Delay(50);
                        if (Config._Hero.GetAbilityById(_Abiility.Id) != null)
                        {
                            _Status++;
                            return;
                        }
                        if (_Abiility.CooldownLength > 0)
                        {
                            var _Steal = Config._Hero.GetAbilityById(AbilityId.rubick_spell_steal);
                            _Steal.UseAbility(_Enemy);
                            _Status++;
                        }
                        else if (_IntNut >= 50)
                        {
                            _Status = 0;
                        }
                    }
                    break;
                case 2:
                    {
                        if (_Used.ForceUse == false)
                        {
                            _Status = 0;
                            return;
                        }
                        var _Stealed = Config._Hero.GetAbilityById(_Abiility.Id);
                        if (_Stealed != null)
                        {
                            if (_Stealed.CooldownLength > 0)
                            {
                                _Status = 0;
                            }
                            await Task.Delay(50);
                            _Stealed.UseAbility(_Enemy);
                        }
                    }
                    break;
            }
        }
    }
}