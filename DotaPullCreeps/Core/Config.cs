using Ensage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesRage.Core
{
    public static class Config
    {
        public static Hero _Hero;

        public static List<Models.Camp> GetCamps { get; } = new List<Models.Camp>();
        public static Boolean DoStack = false;
        public static int Status = 0;
        public static Models.Camp CampToPull = null;
        public static float _AttackTime = 0;
    }
}
