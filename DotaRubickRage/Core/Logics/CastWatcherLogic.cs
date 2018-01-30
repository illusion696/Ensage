using Ensage;
using Ensage.SDK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core.Logics
{
    public static class CastWatherLogic
    {
        private static Dictionary<AbilityId, float> _CastTimes = new Dictionary<AbilityId, float>();

        public static void OnUpdate()
        {
            var _Time = Game.RawGameTime;
            foreach (var _Hero in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team && x.IsAlive && x.IsVisible))
            {
                var _QS = _Hero.Spellbook.SpellQ;
                if (_QS != null && _QS.Cooldown != 0 && _QS.CooldownLength > 0)
                {
                    if (_QS.CooldownLength - _QS.Cooldown <= 0.3)
                    {
                        if (_CastTimes.ContainsKey(_QS.Id))
                        {
                            if (_CastTimes[_QS.Id] + 0.3f < _Time)
                            {
                                _CastTimes[_QS.Id] = _Time;
                            }
                        }
                        else
                        {
                            _CastTimes.Add(_QS.Id, _Time);
                        }
                    }
                }
                var _WS = _Hero.Spellbook.SpellW;
                if (_WS != null && _WS.Cooldown != 0 && _WS.CooldownLength > 0)
                {
                    if (_WS.CooldownLength - _WS.Cooldown <= 0.3)
                    {
                        if (_CastTimes.ContainsKey(_WS.Id))
                        {
                            if (_CastTimes[_WS.Id] + 0.3f < _Time)
                            {
                                _CastTimes[_WS.Id] = _Time;
                            }
                        }
                        else
                        {
                            _CastTimes.Add(_WS.Id, _Time);
                        }
                    }
                }
                var _ES = _Hero.Spellbook.SpellE;
                if (_ES != null && _ES.Cooldown != 0 && _ES.CooldownLength > 0)
                {
                    if (_ES.CooldownLength - _ES.Cooldown <= 0.3)
                    {
                        if (_CastTimes.ContainsKey(_ES.Id))
                        {
                            if (_CastTimes[_ES.Id] + 0.3f < _Time)
                            {
                                _CastTimes[_ES.Id] = _Time;
                            }
                        }
                        else
                        {
                            _CastTimes.Add(_ES.Id, _Time);
                        }
                    }
                }
                var _RS = _Hero.Spellbook.SpellR;
                if (_RS != null && _RS.Cooldown != 0 && _RS.CooldownLength > 0)
                {
                    if (_RS.CooldownLength - _RS.Cooldown <= 0.3)
                    {
                        if (_CastTimes.ContainsKey(_RS.Id))
                        {
                            if (_CastTimes[_RS.Id] + 0.3f < _Time)
                            {
                                _CastTimes[_RS.Id] = _Time;
                            }
                        }
                        else
                        {
                            _CastTimes.Add(_RS.Id, _Time);
                        }
                    }
                }
            }
        }

        public static Boolean IsLastCasted(Hero _Enemy, AbilityId _Id)
        {
            if (_CastTimes.ContainsKey(_Id))
            {
                if (_CastTimes[_Id] + 10 < Game.RawGameTime) return false;

                var _QS = _Enemy.Spellbook.SpellQ;
                var _WS = _Enemy.Spellbook.SpellW;
                var _ES = _Enemy.Spellbook.SpellE;
                var _RS = _Enemy.Spellbook.SpellR;

                List<float> _Times = new List<float>();
                if (_Id != _QS.Id && _CastTimes.ContainsKey(_QS.Id))
                {
                    _Times.Add(_CastTimes[_QS.Id]);
                }
                if (_Id != _WS.Id && _CastTimes.ContainsKey(_WS.Id))
                {
                    _Times.Add(_CastTimes[_WS.Id]);
                }
                if (_Id != _ES.Id && _CastTimes.ContainsKey(_ES.Id))
                {
                    _Times.Add(_CastTimes[_ES.Id]);
                }
                if (_Id != _RS.Id && _CastTimes.ContainsKey(_RS.Id))
                {
                    _Times.Add(_CastTimes[_RS.Id]);
                }

                if (_Times.Any(x => x > _CastTimes[_Id]))
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
