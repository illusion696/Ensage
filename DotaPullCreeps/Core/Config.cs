using Ensage;
using Ensage.Common.Objects.UtilityObjects;
using Ensage.SDK.Renderer;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportsRage.Core
{
    public static class Config
    {
        public static Hero _Hero;
        public static Core.Menu _Menu;
        public static IRendererManager _Renderer;
        public static Logger Log = LogManager.GetCurrentClassLogger();


        public static List<Models.Camp> GetCamps { get; } = new List<Models.Camp>();
        public static Boolean DoStack = false;
        public static int Status = 0;
        public static Models.Camp CampToPull = null;
        public static float _AttackTime = 0;
        public static Boolean DrawConsole = false;
        public static Sleeper _Sleeper = new Sleeper();
    }
}
