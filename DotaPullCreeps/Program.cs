using System;
using System.Linq;
using Ensage;
using Ensage.Common;
using Ensage.Common.Extensions;
using Ensage.Common.Objects;
using Ensage.SDK.Helpers;
using SharpDX;
using System.Collections.Generic;

namespace PullCreeps
{
    internal class Program
    {
        private static void Main()
        {
            Events.OnLoad += (sender, args) =>
            {
                DelayAction.Add(2000, () =>
                {
                    try
                    {
                        var _Hero = ObjectManager.LocalHero;
                        Core.Config._Hero = _Hero;

                        if (_Hero.Team == Team.Radiant)
                        {
                            Core.Config.GetCamps.Add(
                                new Models.Camp
                                {
                                    TablePos = new Vector3(5152, -4384, 256),
                                    CampPos = new Vector3(4502, -4319, 256),
                                    StackPos = new Vector3(3045, -3596, 269),
                                    PreparePos = new Vector3(4567, -3900, 256),
                                    RunPos = new Vector3(5623, -3482, 384),
                                    PullPus = new Vector3(4447, -4124, 256),
                                    Id = 4,
                                    PullTime = 54,
                                    BendPullTime = (float)34.5,
                                    BendPullTime2 = -1,
                                    MiliSubTime = (float)0.5
                                });
                            Core.Config.GetCamps.Add(
                                new Models.Camp
                                {
                                    TablePos = new Vector3(3168, -4320, 256),
                                    CampPos = new Vector3(3030, -4555, 256),
                                    StackPos = new Vector3(4499, -5096, 384),
                                    PreparePos = new Vector3(3432, -4656, 256),
                                    PullPus = new Vector3(3070, -4610, 256),
                                    RunPos = new Vector3(3447, -5884, 384),
                                    Id = 5,
                                    PullTime = 54,
                                    BendPullTime = 21,
                                    BendPullTime2 = 51,
                                    MiliSubTime = (float)0.5
                                });

                            Core.Config.GetCamps.Add(
                                new Models.Camp
                                {
                                    TablePos = new Vector3(-4100, 3300, 256),
                                    CampPos = new Vector3(-4331, 3706, 256),
                                    StackPos = new Vector3(-2894, 3515, 256),
                                    PreparePos = new Vector3(-4420, 3893, 256),
                                    PullPus = new Vector3(-4361, 3614, 256),
                                    RunPos = new Vector3(-5800, 3564, 384),
                                    Id = 14,
                                    PullTime = 55,
                                    BendPullTime = 23,
                                    BendPullTime2 = 53,
                                    MiliSubTime = (float)0.5,
                                });
                        }
                        else
                        {
                            Core.Config.GetCamps.Add(
                                new Models.Camp
                                {
                                    TablePos = new Vector3(-2498, 4921, 259),
                                    CampPos = new Vector3(-2768, 4578, 256),
                                    StackPos = new Vector3(-1923, 6042, 384),
                                    PreparePos = new Vector3(-3215, 4534, 256),
                                    PullPus = new Vector3(-2803, 4646, 256),
                                    RunPos = new Vector3(-3310, 5788, 384),
                                    Id = 13,
                                    PullTime = 53,
                                    BendPullTime = (float)18.5,
                                    BendPullTime2 = 49,
                                    MiliSubTime = (float)0.5
                                });
                            Core.Config.GetCamps.Add(
                                new Models.Camp
                                {
                                    TablePos = new Vector3(-4100, 3300, 256),
                                    CampPos = new Vector3(-4331, 3706, 256),
                                    StackPos = new Vector3(-2894, 3515, 256),
                                    PreparePos = new Vector3(-4420, 3893, 256),
                                    PullPus = new Vector3(-4361, 3614, 256),
                                    RunPos = new Vector3(-5757, 3686, 384),
                                    Id = 14,
                                    PullTime = 55,
                                    BendPullTime = 33,
                                    BendPullTime2 = 2,
                                    MiliSubTime = (float)0.5
                                });
                            Core.Config.GetCamps.Add(
                               new Models.Camp
                               {
                                   TablePos = new Vector3(5152, -4384, 256),
                                   CampPos = new Vector3(4502, -4319, 256),
                                   StackPos = new Vector3(3045, -3596, 269),
                                   PreparePos = new Vector3(4567, -3900, 256),
                                   RunPos = new Vector3(5623, -3482, 384),
                                   PullPus = new Vector3(4447, -4124, 256),
                                   Id = 4,
                                   PullTime = 54,
                                   BendPullTime = 23,
                                   BendPullTime2 = 53,
                                   MiliSubTime = (float)0.5
                               });
                        }
                        
                        Core.MenuManager.Init();

                        Game.OnIngameUpdate += OnUpdate;
                        Drawing.OnDraw += Drawings.Info.Drawing_OnDraw;

                        Game.OnWndProc += Game_OnWndProc;

                    }
                    catch (Exception ex)
                    {
                        Printer.Print(ex.ToString());
                    }
                });
            };
        }
        
        public static void OnUpdate(EventArgs args)
        {
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

                            var _Target = Creeps.All.OrderBy(x => x.Distance2D(Core.Config._Hero))
                                                      .FirstOrDefault(x => x.Distance2D(Core.Config._Hero) <= 600 && x.IsSpawned && x.IsAlive && x.IsNeutral);
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
                                    var _Target = Creeps.All.OrderBy(x => x.Distance2D(Core.Config._Hero))
                                       .FirstOrDefault(x => x.Distance2D(Core.Config._Hero) <= 600 && x.IsSpawned && x.IsAlive && x.IsNeutral);
                                    Core.Config._Hero.Attack(_Target);
                                    Core.Config._Sleeper.Sleep(1000);
                                    Core.Config.Status = 5;
                                }
                                else
                                {
                                    if (Core.Config._Hero.IsAttacking() == false)
                                    {
                                        var _Target = Creeps.All.OrderBy(x => x.Distance2D(Core.Config._Hero))
                                        .FirstOrDefault(x => x.Distance2D(Core.Config._Hero) <= 600 && x.IsSpawned && x.IsAlive && x.IsNeutral);
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

            if (Game.IsKeyDown(Core.MenuManager.Key))
            {
                Core.Config.DoStack = true;
                Core.Config.Status = 0;
            }

            //if (Game.IsKeyDown(System.Windows.Input.Key.O))
            //{
            //    Core.Config.ForTest = "";
            //    Core.Config.DrawConsole = true;
            //}
            //else Core.Config.DrawConsole = false;
        }

        private static void Game_OnWndProc(WndEventArgs args)
        {
            if (args.Msg == (ulong)Ensage.Common.Utils.WindowsMessages.WM_RBUTTONDOWN)
            {
                Core.Config.DoStack = false;
                Core.Config.Status = 0;
            }
        }
    }
}