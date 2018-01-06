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

                        Printer.Print("!!!!");
                        if (_Hero.Team == Team.Radiant)
                        {
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-1411, -4284, 256),
                            //        CampPos = new Vector3(-1858, -4138, 256),
                            //        StackPos = new Vector3(-1805, -2930, 256),
                            //        PreparePos = new Vector3(-1829, -3834, 256),
                            //        Id = 1,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-100, -3424, 384),
                            //        CampPos = new Vector3(-563, -3314, 256),
                            //        StackPos = new Vector3(-726, -4275, 384),
                            //        PreparePos = new Vector3(-859, -3217, 256),
                            //        Id = 2,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(135, -4793, 384),
                            //        CampPos = new Vector3(431, -4637, 384),
                            //        StackPos = new Vector3(751, -3479, 384),
                            //        PreparePos = new Vector3(719, -4391, 384),
                            //        Id = 3,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(5152, -4384, 256),
                            //        CampPos = new Vector3(4502, -4319, 256),
                            //        StackPos = new Vector3(3045, -3596, 269),
                            //        PreparePos = new Vector3(4165, -4129, 256),
                            //        Id = 4,
                            //        PullTime = 54,
                            //    });
                            Core.Config.GetCamps.Add( // !!!
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
                                });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-3000, 300, 384),
                            //        CampPos = new Vector3(-2858, -126, 384),
                            //        StackPos = new Vector3(-3472, -1566, 384),
                            //        PreparePos = new Vector3(-2566, -302, 384),
                            //        Id = 6,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-5121, -239, 256),
                            //        CampPos = new Vector3(-4809, -408, 256),
                            //        StackPos = new Vector3(-4658, 1403, 384),
                            //        PreparePos = new Vector3(-4573, -111, 256),
                            //        Id = 7,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-3324, 736, 256),
                            //        CampPos = new Vector3(-3824, 766, 256),
                            //        StackPos = new Vector3(-5379, 328, 384),
                            //        PreparePos = new Vector3(-4049, 620, 256),
                            //        Id = 8,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(567, -1908, 384),
                            //        CampPos = new Vector3(142, -1947, 384),
                            //        StackPos = new Vector3(945, -3544, 384),
                            //        PreparePos = new Vector3(528, -2283, 384),
                            //        Id = 9,
                            //        PullTime = 54,
                            //    });
                            Core.Config.GetCamps.Add(
                         new Models.Camp
                         {
                             TablePos = new Vector3(-4100, 3300, 256),
                             CampPos = new Vector3(-4331, 3706, 256),
                             StackPos = new Vector3(-2894, 3515, 256),
                             PreparePos = new Vector3(-4174, 3893, 256),
                             PullPus = new Vector3(-4361, 3614, 256),
                             RunPos = new Vector3(-5800, 3564, 384),
                             Id = 14,
                             PullTime = 55,
                         });
                        }
                        else
                        {
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(1700, 3400, 384),
                            //        CampPos = new Vector3(1339, 3356, 384),
                            //        StackPos = new Vector3(364, 4898, 384),
                            //        PreparePos = new Vector3(1041, 3593, 383),
                            //        Id = 10,
                            //        PullTime = 54,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-352, 3070, 256),
                            //        CampPos = new Vector3(-270, 3424, 256),
                            //        StackPos = new Vector3(-380, 4910, 384),
                            //        PreparePos = new Vector3(-551, 3556, 256),
                            //        Id = 11,
                            //        PullTime = 54,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-1184, 2208, 384),
                            //        CampPos = new Vector3(-827, 2278, 384),
                            //        StackPos = new Vector3(982, 2251, 384),
                            //        PreparePos = new Vector3(-419, 2473, 384),
                            //        Id = 12,
                            //        PullTime = 54,
                            //    });
                            Core.Config.GetCamps.Add( // !!!
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
                                    });
                            Core.Config.GetCamps.Add(
                         new Models.Camp
                         {
                             TablePos = new Vector3(-4100, 3300, 256),
                             CampPos = new Vector3(-4331, 3706, 256),
                             StackPos = new Vector3(-2894, 3515, 256),
                             PreparePos = new Vector3(-4174, 3893, 256),
                             PullPus = new Vector3(-4361, 3614, 256),
                             RunPos = new Vector3(-5871, 3687, 384),
                             Id = 14,
                             PullTime = 55,
                         });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(4200, -400, 256),
                            //        CampPos = new Vector3(3732, -631, 256),
                            //        StackPos = new Vector3(2221, -1013, 256),
                            //        PreparePos = new Vector3(3446, -697, 256),
                            //        Id = 15,
                            //        PullTime = 53,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(4696, 1120, 384),
                            //        CampPos = new Vector3(4273, 791, 384),
                            //        StackPos = new Vector3(3148, 687, 384),
                            //        PreparePos = new Vector3(4001, 745, 384),
                            //        Id = 16,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(-1940, 4669, 384),
                            //        CampPos = new Vector3(-1984, 4282, 256),
                            //        StackPos = new Vector3(-961, 5011, 384),
                            //        PreparePos = new Vector3(-1619, 4058, 256),
                            //        Id = 17,
                            //        PullTime = 55,
                            //    });
                            //Core.Config.GetCamps.Add(
                            //    new Models.Camp
                            //    {
                            //        TablePos = new Vector3(2527, 478, 384),
                            //        CampPos = new Vector3(2685, 110, 384),
                            //        StackPos = new Vector3(4425, 11, 384),
                            //        PreparePos = new Vector3(3039, 106, 384),
                            //        Id = 18,
                            //        PullTime = 54,
                            //    });
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
        

        static Double GetAttackPoint()
        {
            float _AnimationPoint = Game.FindKeyValues(Core.Config._Hero.Name + "/AttackAnimationPoint", KeyValueSource.Hero).FloatValue;
            float _APerTime = Game.FindKeyValues(Core.Config._Hero.Name + "/AttackRate", KeyValueSource.Hero).FloatValue;
            if (_APerTime <= 0)  _APerTime = Game.FindKeyValues(Core.Config._Hero.Name + "/AttackRate", KeyValueSource.Hero).IntValue;

            return _AnimationPoint / (1 + (Core.Config._Hero.AttacksPerSecond * _APerTime / 0.01 - 100) / 100);
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
                            switch (Core.Config.CampToPull.Id)
                            {

                                case 5:
                                    {
                                        if ((_Sec >= 13 && _Sec <= 17) || (_Sec >= 43 && _Sec <= 47))
                                        {
                                            Core.Config._Hero.Move(Core.Config.CampToPull.PullPus);
                                            Core.Config.Status++;
                                        }
                                    }
                                    break;
                                case 13:
                                    {
                                        if ((_Sec >= 12 && _Sec <= 16) || (_Sec >= 42 && _Sec <= 46))
                                        {
                                            Core.Config._Hero.Move(Core.Config.CampToPull.PullPus);
                                            Core.Config.Status++;
                                        }
                                    }
                                    break;
                                case 14:
                                    {
                                        if (Core.Config._Hero.Team == Team.Radiant)
                                        {
                                            if ((_Sec >= 15.5 && _Sec <= 17) || (_Sec >= 46.5 && _Sec <= 48))
                                            {
                                                Core.Config._Hero.Move(Core.Config.CampToPull.PullPus);
                                                Core.Config.Status++;
                                            }
                                        }
                                        else
                                        {
                                            if ((_Sec >= 26 && _Sec <= 28) || (_Sec >= 54.6 && _Sec <= 56.7))
                                            {
                                                Core.Config._Hero.Move(Core.Config.CampToPull.PullPus);
                                                Core.Config.Status++;
                                            }
                                        }
                                    }
                                    break;
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
                            if (Game.IsNight)
                            {
                                if (Core.Config._Hero.IsAttacking() == false)
                                {
                                    var _Target = Creeps.All.OrderBy(x => x.Distance2D(Core.Config._Hero))
                                    .FirstOrDefault(x => x.Distance2D(Core.Config._Hero) <= 600 && x.IsSpawned && x.IsAlive && x.IsNeutral);
                                    Core.Config._Hero.Attack(_Target);
                                }
                                if (Core.Config._AttackTime <= 0 && Core.Config._Hero.IsAttacking())
                                {
                                    Core.Config._AttackTime = Game.GameTime + Game.Ping / 1000;
                                }
                                else if (Core.Config._AttackTime > 0 && Game.GameTime >= Core.Config._AttackTime + GetAttackPoint())
                                {
                                    Core.Config._AttackTime = 0;
                                    Core.Config.Status = 5;
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