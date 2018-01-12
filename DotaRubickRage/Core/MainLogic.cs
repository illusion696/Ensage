using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class MainLogic
    {
        public static void OnUpdate()
        {
            if (Core.Config._Menu.HotkeyDown)
            {
                Core.Config.DoStack = true;
                Core.Config.Status = 0;
                return;
            }
            if (Core.Config.DoStack)
            {
                switch (Core.Config.Status)
                {
                    case 0:
                        {
                            var _ClosestCamp = Core.Config.GetCamps.OrderBy(x => Core.Config._Hero.Distance2D(x.TablePos)).First();
                            Core.Config.CampToPull = _ClosestCamp;
                            Core.Config._Hero.Move(_ClosestCamp.PreparePos);
                            Core.Config.Status++;
                        }
                        break;
                    case 1:
                        {
                            if (Core.Config._Hero.Distance2D(Core.Config.CampToPull.PreparePos) <= 25)
                            {
                                Core.Config.Status++;
                            }
                        }
                        break;
                    case 2:
                        {
                            var _Sec = Game.GameTime;
                            while (_Sec > 60) _Sec -= 60;

                            var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Core.Config._Hero)).
                                FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Core.Config._Hero) <= 600);

                            if (Core.Config._Hero.IsRanged)
                            {
                                var _SecToRun = Core.Config._Hero.Distance2D(Core.Config.CampToPull.RunPos) / _Target.MovementSpeed;
                                var _SecToAttack = Core.Config._Hero.AttackBackswing() + Core.Config._Hero.AttackPoint();

                                var _PullTime = Core.Config.CampToPull.BendPullTime - _SecToRun - _SecToAttack;
                                var _PullTime2 = Core.Config.CampToPull.BendPullTime2 - _SecToRun - _SecToAttack;
                                if (_PullTime < 0) _PullTime = 60 + _PullTime;
                                if (_PullTime2 < 0) _PullTime2 = 60 + _PullTime2;

                                if ((_Sec >= _PullTime && _Sec <= _PullTime + 1) || (_Sec >= _PullTime2 && _Sec <= _PullTime2 + 1))
                                {
                                    Core.Config.Status += 2;
                                }
                            }
                            else
                            {
                                var _SecToRun = Core.Config._Hero.Distance2D(Core.Config.CampToPull.RunPos) / _Target.MovementSpeed;
                                var _SecToPull = Core.Config._Hero.Distance2D(Core.Config.CampToPull.PullPus) / Core.Config._Hero.MovementSpeed;
                                var _SecToAttack = Core.Config._Hero.AttackBackswing() + Core.Config._Hero.AttackPoint();

                                var _PullTime = Core.Config.CampToPull.BendPullTime - _SecToRun - _SecToAttack - _SecToPull - Core.Config.CampToPull.MiliSubTime;
                                var _PullTime2 = Core.Config.CampToPull.BendPullTime2 - _SecToRun - _SecToAttack - _SecToPull - Core.Config.CampToPull.MiliSubTime;

                                if ((_Sec >= _PullTime && _Sec <= _PullTime + 1) || (_Sec >= _PullTime2 && _Sec <= _PullTime2 + 1))
                                {
                                    Core.Config._Hero.Move(Core.Config.CampToPull.PullPus);
                                    Core.Config.Status++;
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            if (Core.Config._Hero.Distance2D(Core.Config.CampToPull.PullPus) <= 25)
                            {
                                Core.Config.Status++;
                            }
                        }
                        break;
                    case 4:
                        {
                            if (Game.IsNight || Core.Config._Hero.IsRanged)
                            {
                                if (Core.Config._Hero.ClassId == ClassId.CDOTA_Unit_Hero_Wisp)
                                {
                                    var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Core.Config._Hero)).
                                        FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Core.Config._Hero) <= 600);

                                    Core.Config._Hero.Attack(_Target);
                                    Core.Config._Sleeper.Sleep(1000);
                                    Core.Config.Status = 5;
                                }
                                else
                                {
                                    if (Core.Config._Hero.IsAttacking() == false)
                                    {
                                        var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Core.Config._Hero)).
                                            FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Core.Config._Hero) <= 600);

                                        Core.Config._Hero.Attack(_Target);
                                    }
                                    if (Core.Config._AttackTime <= 0 && (Core.Config._Hero.IsAttacking()))
                                    {
                                        Core.Config._AttackTime = Game.GameTime + Game.Ping / 1000;
                                    }
                                    else if (Core.Config._AttackTime > 0 && Game.GameTime >= Core.Config._AttackTime + Core.Config._Hero.AttackPoint())
                                    {
                                        Core.Config._AttackTime = 0;
                                        Core.Config.Status = 5;
                                    }
                                }
                            }
                            else
                            {
                                Core.Config._Hero.Move(Core.Config.CampToPull.RunPos);
                                Core.Config.Status = 0;
                                Core.Config.DoStack = false;
                            }
                        }
                        break;

                    case 5:
                        {
                            if (Core.Config._Sleeper.Sleeping)
                            {
                                return;
                            }
                            Core.Config._Hero.Move(Core.Config.CampToPull.RunPos);
                            Core.Config.Status = 0;
                            Core.Config.DoStack = false;
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
