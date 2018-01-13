using Ensage;
using Ensage.Common.Objects.UtilityObjects;
using Ensage.SDK.Handlers;
using Ensage.SDK.Renderer;
using NLog;
using System;
using System.Collections.Generic;
using Ensage.SDK.TargetSelector;

namespace RubickRage.Core
{
    public static class Config
    {
        public static Hero _Hero;
        public static Menu _Menu;
        public static IRendererManager _Renderer;
        public static ITargetSelectorManager _TargetSelector;
        public static Logger Log = LogManager.GetCurrentClassLogger();

        public static Ensage.SDK.Abilities.BaseAbility _QSpell { get; set; }
        public static Ensage.SDK.Abilities.BaseAbility _WSpell { get; set; }

        public static List<Models.Camp> GetCamps { get; } = new List<Models.Camp>();
        public static Boolean DoStack = false;
        public static int Status = 0;
        public static Models.Camp CampToPull = null;
        public static float _AttackTime = 0;
        public static Boolean DrawConsole = false;
        public static Sleeper _Sleeper = new Sleeper();

        public static TaskHandler _ComboTask;
        public static TaskHandler _ComboMainTask;
    }
}
