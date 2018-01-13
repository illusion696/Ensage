using System.Linq;
using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;

namespace SupportsRage.Core
{
    public static class MainLogic
    {
        public static void OnUpdate()
        {
            if (Config._Menu.HotkeyDown)
            {
                Config.DoStack = true;
                Config.Status = 0;
                return;
            }
            if (Config.DoStack)
            {
                switch (Config.Status)
                {
                    case 0:
                        {
                            var _ClosestCamp = Config.GetCamps.OrderBy(x => Config._Hero.Distance2D(x.TablePos)).First();
                            Config.CampToPull = _ClosestCamp;
                            Config._Hero.Move(_ClosestCamp.PreparePos);
                            Config.Status++;
                        }
                        break;
                    case 1:
                        {
                            if (Config._Hero.Distance2D(Config.CampToPull.PreparePos) <= 25)
                            {
                                Config.Status++;
                            }
                        }
                        break;
                    case 2:
                        {
                            var _Sec = Game.GameTime;
                            while (_Sec > 60) _Sec -= 60;

                            var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Config._Hero)).
                                FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Config._Hero) <= 600);

                            if (_Target != null)
                            {
                                if (Config._Hero.IsRanged)
                                {
                                    var _SecToRun = Config._Hero.Distance2D(Config.CampToPull.RunPos) / _Target.MovementSpeed;
                                    var _SecToAttack = Config._Hero.AttackBackswing() + Config._Hero.AttackPoint();

                                    var _PullTime = Config.CampToPull.BendPullTime - _SecToRun - _SecToAttack;
                                    var _PullTime2 = Config.CampToPull.BendPullTime2 - _SecToRun - _SecToAttack;
                                    if (_PullTime < 0)
                                        _PullTime = 60 + _PullTime;
                                    if (_PullTime2 < 0)
                                        _PullTime2 = 60 + _PullTime2;

                                    if ((_Sec >= _PullTime && _Sec <= _PullTime + 1) || (_Sec >= _PullTime2 && _Sec <= _PullTime2 + 1))
                                    {
                                        Config.Status += 2;
                                    }
                                }
                                else
                                {
                                    var _SecToRun = Config._Hero.Distance2D(Config.CampToPull.RunPos) / _Target.MovementSpeed;
                                    var _SecToPull = Config._Hero.Distance2D(Config.CampToPull.PullPus) / Config._Hero.MovementSpeed;
                                    var _SecToAttack = Config._Hero.AttackBackswing() + Config._Hero.AttackPoint();

                                    var _PullTime = Config.CampToPull.BendPullTime - _SecToRun - _SecToAttack - _SecToPull - Config.CampToPull.MiliSubTime;
                                    var _PullTime2 = Config.CampToPull.BendPullTime2 - _SecToRun - _SecToAttack - _SecToPull - Config.CampToPull.MiliSubTime;

                                    if ((_Sec >= _PullTime && _Sec <= _PullTime + 1) || (_Sec >= _PullTime2 && _Sec <= _PullTime2 + 1))
                                    {
                                        Config._Hero.Move(Config.CampToPull.PullPus);
                                        Config.Status++;
                                    }
                                }
                            }
                            else
                            {
                                Config.DoStack = true;
                                Config.Status = 0;
                            }
                        }
                        break;
                    case 3:
                        {
                            if (Config._Hero.Distance2D(Config.CampToPull.PullPus) <= 25)
                            {
                                Config.Status++;
                            }
                        }
                        break;
                    case 4:
                        {
                            if (Game.IsNight || Config._Hero.IsRanged)
                            {
                                if (Config._Hero.ClassId == ClassId.CDOTA_Unit_Hero_Wisp)
                                {
                                    var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Config._Hero)).
                                        FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Config._Hero) <= 600);

                                    Config._Hero.Attack(_Target);
                                    Config._Sleeper.Sleep(1000);
                                    Config.Status = 5;
                                }
                                else
                                {
                                    if (Config._Hero.IsAttacking() == false)
                                    {
                                        var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Config._Hero)).
                                            FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Config._Hero) <= 600);

                                        Config._Hero.Attack(_Target);
                                    }
                                    if (Config._AttackTime <= 0 && (Config._Hero.IsAttacking()))
                                    {
                                        Config._AttackTime = Game.GameTime + Game.Ping / 1000;
                                    }
                                    else if (Config._AttackTime > 0 && Game.GameTime >= Config._AttackTime + Config._Hero.AttackPoint())
                                    {
                                        Config._AttackTime = 0;
                                        Config.Status = 5;
                                    }
                                }
                            }
                            else
                            {
                                Config._Hero.Move(Config.CampToPull.RunPos);
                                Config.Status = 0;
                                Config.DoStack = false;
                            }
                        }
                        break;

                    case 5:
                        {
                            if (Config._Sleeper.Sleeping)
                            {
                                return;
                            }
                            Config._Hero.Move(Config.CampToPull.RunPos);
                            Config.Status = 0;
                            Config.DoStack = false;
                        }
                        break;
                }
            }
            //if (Game.IsKeyDown(System.Windows.Input.Key.O))
            //{
            //    Core.Config.ForTest = "";
            //    Core.Config.DrawConsole = true;
            //}
            //else Core.Config.DrawConsole = false;
        }
    }
}
