using System.Linq;
using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;

namespace SupportsRage.Core
{
    public static class GlimmerSaveLogic
    {
        private static float TimeStart;
        private static int Status;
        private static Ability _Used;
        private static Hero[] _Target;
        private static Hero _Enemy;

        public static void OnUpdate()
        {
            if (Config._Menu.GlimmerSave.SavekeyDown || Config._Menu.GlimmerSave.ToggleEnabled)
            {
                switch (Status)
                {
                    case 0:
                        {
                            if (Config._Items.Glimmer != null && Config._Items.Glimmer.CanBeCasted)
                            {
                                foreach (var _Hero in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
                                {
                                    var _AnyAbility = _Hero.Spellbook.Spells.FirstOrDefault(x => x.IsInAbilityPhase);
                                    if (_AnyAbility != null)
                                    {
                                        _Enemy = _Hero;
                                        var _AId = _AnyAbility.Name;
                                        _Used = _AnyAbility;
                                        if (Config._Menu.GlimmerSave.SaveFromKeys.Contains(_AId))
                                        {
                                            if (Config._Menu.GlimmerSave.SaveFrom[_AId])
                                            {
                                                if (TimeStart + 0.5 <= Game.GameTime)
                                                {
                                                    _Target = EntityManager<Hero>
                                                              .Entities.Where(x => x.Team == Config._Hero.Team && x.IsAlive && x.Distance2D(_Enemy) <= _AnyAbility.CastRange + 300)
                                                              .ToArray();

                                                    TimeStart = Game.GameTime;
                                                    Status = 1;
                                                    break;
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
                                if (TimeStart + _Used.GetCastDelay(_Enemy, _First, true) / (Config._Menu.GlimmerSave.CastTiming.Value / 10f) <= Game.GameTime)
                                {
                                    _Target = _Target.OrderBy(x => _Enemy.FindRelativeAngle(x.Position)).ToArray();

                                    var _T = _Target.First();
                                    if (Config._Items.Glimmer.CastRange < _T.Distance2D(Config._Hero.Position))
                                    {
                                        if (Config._Items.Blink != null && Config._Items.Blink.CanBeCasted)
                                        {
                                            Config._Items.Blink.UseAbility(_T.Position);
                                            Config._Items.Glimmer.UseAbility(_T);
                                        }
                                    }
                                    else
                                    {
                                        Config._Items.Glimmer.UseAbility(_T);
                                    }

                                    TimeStart = 0;
                                    Status = 0;
                                }
                                else if (TimeStart + 1 <= Game.GameTime)
                                {
                                    TimeStart = 0;
                                    Status = 0;
                                }
                            }
                            else
                            {
                                TimeStart = 0;
                                Status = 0;
                            }
                        }
                        break;
                }
            }
        }
    }
}