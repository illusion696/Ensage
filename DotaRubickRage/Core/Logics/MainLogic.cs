using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Helpers;
using System.Linq;
using System.Threading.Tasks;

namespace RubickRage.Core.Logics
{
    public static class MainLogic
    {
        public static bool DoStack;
        private static int Status;
        private static Models.Camp CampToPull;
        private static float _AttackTime;

        public static async Task OnUpdateAsync()
        {
            if (Config._Menu.HotkeyDown)
            {
                DoStack = true;
                Status = 0;
                return;
            }
            if (DoStack)
            {
                switch (Status)
                {
                    case 0:
                        {
                            var _ClosestCamp = Config.GetCamps.OrderBy(x => Config._Hero.Distance2D(x.TablePos)).First();
                            CampToPull = _ClosestCamp;
                            Config._Hero.Move(_ClosestCamp.PreparePos);
                            Status++;
                        }
                        break;
                    case 1:
                        {
                            if (Config._Hero.Distance2D(CampToPull.PreparePos) <= 25)
                            {
                                Status++;
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
                                    var _SecToRun = Config._Hero.Distance2D(CampToPull.RunPos) /
                                                    _Target.MovementSpeed;
                                    var _SecToAttack = Config._Hero.AttackBackswing() + Config._Hero.AttackPoint();

                                    var _PullTime = CampToPull.BendPullTime - _SecToRun - _SecToAttack;
                                    var _PullTime2 = CampToPull.BendPullTime2 - _SecToRun - _SecToAttack;
                                    if (_PullTime < 0) _PullTime = 60 + _PullTime;
                                    if (_PullTime2 < 0) _PullTime2 = 60 + _PullTime2;

                                    if ((_Sec >= _PullTime && _Sec <= _PullTime + 1) ||
                                        (_Sec >= _PullTime2 && _Sec <= _PullTime2 + 1))
                                    {
                                        Status += 2;
                                    }
                                }
                                else
                                {
                                    var _SecToRun = Config._Hero.Distance2D(CampToPull.RunPos) /
                                                    _Target.MovementSpeed;
                                    var _SecToPull = Config._Hero.Distance2D(CampToPull.PullPus) /
                                                     Config._Hero.MovementSpeed;
                                    var _SecToAttack = Config._Hero.AttackBackswing() + Config._Hero.AttackPoint();

                                    var _PullTime = CampToPull.BendPullTime - _SecToRun - _SecToAttack -
                                                    _SecToPull - CampToPull.MiliSubTime;
                                    var _PullTime2 = CampToPull.BendPullTime2 - _SecToRun - _SecToAttack -
                                                     _SecToPull - CampToPull.MiliSubTime;

                                    if ((_Sec >= _PullTime && _Sec <= _PullTime + 1) ||
                                        (_Sec >= _PullTime2 && _Sec <= _PullTime2 + 1))
                                    {
                                        Config._Hero.Move(CampToPull.PullPus);
                                        Status++;
                                    }
                                }
                            }
                            else
                            {
                                DoStack = true;
                                Status = 0;
                            }
                        }
                        break;
                    case 3:
                        {
                            if (Config._Hero.Distance2D(CampToPull.PullPus) <= 25)
                            {
                                Status++;
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
                                    await Task.Delay(1000);
                                    Status = 5;
                                }
                                else
                                {
                                    if (Config._Hero.IsAttacking() == false)
                                    {
                                        var _Target = EntityManager<Creep>.Entities.OrderBy(x => x.Distance2D(Config._Hero)).
                                            FirstOrDefault(x => x.IsValid && x.IsAlive && x.IsSpawned && x.IsNeutral && x.Distance2D(Config._Hero) <= 600);

                                        Config._Hero.Attack(_Target);
                                    }
                                    if (_AttackTime <= 0 && (Config._Hero.IsAttacking()))
                                    {
                                        _AttackTime = Game.GameTime + Game.Ping / 1000;
                                    }
                                    else if (_AttackTime > 0 && Game.GameTime >= _AttackTime + Config._Hero.AttackPoint())
                                    {
                                        _AttackTime = 0;
                                        Status = 5;
                                    }
                                }
                            }
                            else
                            {
                                Config._Hero.Move(CampToPull.RunPos);
                                Status = 0;
                                DoStack = false;
                            }
                        }
                        break;

                    case 5:
                        {
                            Config._Hero.Move(CampToPull.RunPos);
                            Status = 0;
                            DoStack = false;
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
