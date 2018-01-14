using System;
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
        private static float TimeStart;
        private static int Status;
        private static Ability _Used;
        private static Hero[] _Target;
        private static Hero _Enemy;

        public static void OnUpdate()
        {
            if (Config._Menu.LotusSave.SavekeyDown || Config._Menu.LotusSave.ToggleEnabled)
            {
                switch (Status)
                {
                    case 0:
                    {
                        _Lotus = Config._Hero.GetItemById(ItemId.item_lotus_orb);
                        if (_Lotus != null && _Lotus.CanBeCasted())
                        {
                            foreach (var v in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
                            {
                                var anyAbility = v.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                                if (anyAbility != null)
                                {
                                    _Enemy = v;
                                    var _AId = anyAbility.Name;
                                    _Used = anyAbility;
                                    if (Config._Menu.LotusSave.SaveFromKeys.Contains(_AId))
                                    {
                                        if (Config._Menu.LotusSave.SaveFrom[_AId])
                                        {
                                            if (TimeStart + 0.5 <= Game.GameTime)
                                            {
                                                _Target = EntityManager<Hero>
                                                          .Entities.Where(x => x.Team == Config._Hero.Team && x.IsAlive && x.Distance2D(v) <= anyAbility.CastRange + 300)
                                                          .ToArray();

                                                TimeStart = Game.GameTime;
                                                Status = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                        break;
                    case 1:
                    {
                        if (_Target.Any())
                        {
                            var _First = _Target.First();
                            // Core.Config.Test = _Used.GetCastDelay(_Enemy, _Target.First()) + "\r\n" + String.Join("\r\n", _Target.Select(x => x.Name + " " + _Enemy.FindRelativeAngle(x.Position)));
                            if (TimeStart + _Used.GetCastDelay(_Enemy, _First) <= Game.GameTime)
                            {
                                _Target = _Target.OrderBy(x => _Enemy.FindRelativeAngle(x.Position)).ToArray();

                                var _T = _Target.First();
                                if (_Lotus.CastRange < _T.Distance2D(Config._Hero.Position))
                                {
                                    var _Item2 = Config._Hero.GetItemById(ItemId.item_blink);
                                    if (_Item2 != null && _Item2.CanBeCasted())
                                    {
                                        _Item2.UseAbility(_T.Position);
                                        _Lotus.UseAbility(_T);
                                    }
                                }
                                else
                                {
                                    _Lotus.UseAbility(_T);
                                }

                                TimeStart = 0;
                                Status = 0;
                            }
                        }
                    }
                        break;
                }
            }
        }
    }
}