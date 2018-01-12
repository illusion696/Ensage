using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class LotusLogic
    {
        public static Item _Linken;
        public static int _Status = 0;
        static Ability _Abiility = null;
        static Hero _Enemy = null;
        static int _IntNut = 0;
        static Core.LotusSpellConfig _Used = null;

        public static async Task OnUpdateTask(CancellationToken cancellationToken)
        {
            switch (_Status)
            {
                case 0:
                    {
                        foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team && x.IsAlive && x.IsVisible))
                        {
                            _Used = null;
                            var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                            if (anyAbility != null && Core.Config._Menu.LotusCombo.LotusSpellConfigs.ContainsKey(anyAbility.Name))
                            {
                                _Used = Core.Config._Menu.LotusCombo.LotusSpellConfigs[anyAbility.Name];
                            }

                            if (_Used == null) continue;
                            if (Core.Config._Menu.LotusCombo.SaveFrom[anyAbility.Name] == false) continue;
                            _Abiility = anyAbility;

                            _Enemy = v;
                            _IntNut = 0;
                            var _Item = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_lotus_orb);

                            if (_Item != null && _Item.CanBeCasted())
                            {
                                var _Target = EntityManager<Hero>.Entities.Where(x => x.Team == Core.Config._Hero.Team && x.IsAlive).OrderBy(x => v.FindRelativeAngle(x.Position)).FirstOrDefault();

                                if (_Target != null)
                                {
                                    if (_Item.CastRange < _Target.Distance2D(Core.Config._Hero.Position))
                                    {
                                        var _Item2 = Core.Config._Hero.GetItemById(Ensage.Common.Enums.ItemId.item_blink);
                                        if (_Item2 != null && _Item2.CanBeCasted())
                                        {
                                            _Item2.UseAbility(_Target.Position);
                                            _Item.UseAbility(_Target);
                                            _Status++;
                                            break;
                                        }
                                    }
                                    else if (_Item.CanBeCasted())
                                    {
                                        _Item.UseAbility(_Target);
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
                        if (Core.Config._Menu.LotusCombo.LotusSpellConfigs[_Abiility.Name].Steal == false)
                        {
                            _Status = 0;
                            return;
                        }
                        _IntNut++;
                        await Task.Delay(50);
                        if (Core.Config._Hero.GetAbilityById(_Abiility.Id) != null)
                        {
                            _Status++;
                            return;
                        }
                        if (_Abiility.CooldownLength > 0)
                        {
                            var _Steal = Core.Config._Hero.GetAbilityById(AbilityId.rubick_spell_steal);
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
                        var _Stealed = Core.Config._Hero.GetAbilityById(_Abiility.Id);
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