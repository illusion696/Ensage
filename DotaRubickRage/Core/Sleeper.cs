using Ensage;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class Sleeper
    {
        private static Dictionary<String, float> _IsSleepTimes = new Dictionary<String, float>();

        public static void Sleep(String Name, float Delay)
        {
            if (_IsSleepTimes.ContainsKey(Name))
            {
                _IsSleepTimes[Name] = Game.RawGameTime + Delay;
            }
            else
            {
                _IsSleepTimes.Add(Name, Game.RawGameTime + Delay);
            }
        }

        public static Boolean IsSleep(String Name)
        {
            if (_IsSleepTimes.ContainsKey(Name))
            {
                return Game.RawGameTime < _IsSleepTimes[Name];
            }
            else return false;
        }
    }
}
