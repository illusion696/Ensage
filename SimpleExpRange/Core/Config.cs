using Ensage;
using NLog;
using System;
using Ensage.SDK.Renderer.Particle;

namespace SimpleExpRange.Core
{
    public static class Config
    {
        public static Hero _Hero;
        public static Menus.Menu _Menu;
        public static IParticleManager _ParticleManager;
        public static Logger Log = LogManager.GetCurrentClassLogger();
        
        public static String Debug;
    }
}
