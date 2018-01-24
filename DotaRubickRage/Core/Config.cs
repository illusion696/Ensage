using Ensage;
using Ensage.SDK.Handlers;
using Ensage.SDK.Renderer;
using NLog;
using System;
using System.Collections.Generic;
using System.Reflection;
using Ensage.SDK.Renderer.Particle;
using Ensage.SDK.TargetSelector;

namespace RubickRage.Core
{
    public static class Config
    {
        public static Assembly _Assembly;

        public static Hero _Hero;
        public static Menus.Menu _Menu;
        public static ItemBindings _Items = new ItemBindings();
        public static IRendererManager _Renderer;
        public static IParticleManager _ParticleManager;
        public static ITargetSelectorManager _TargetSelector;
        public static Logger Log = LogManager.GetCurrentClassLogger();

        public static Ensage.SDK.Abilities.BaseAbility _QSpell { get; set; }
        public static Ensage.SDK.Abilities.BaseAbility _WSpell { get; set; }
        public static Ability _ESpell { get; set; }
        public static Ability _RSpell { get; set; }

        public static List<String> _HeroesFullNames = new List<String>();


        public static TaskHandler _MainComboTask;
        public static TaskHandler _LotusComboTask;
        public static TaskHandler _StealTask;


        public static List<Models.Camp> GetCamps { get; } = new List<Models.Camp>();

        public static readonly Dictionary<Unit, double> _EnemyAttakers = new Dictionary<Unit, double>();


        public static float _StormLastUlt;
        public static Dictionary<String, Models.TimeModel> _Delays = new Dictionary<String, Models.TimeModel>();
        public static readonly String[] _BlockModiffers =
        {
            "modifier_ember_spirit_sleight_of_fist_caster",
            "modifier_abaddon_borrowed_time",
            "modifier_shredder_timber_chain",
            "modifier_storm_spirit_ball_lightning",
            "modifier_ember_spirit_sleight_of_fist_caster_invulnerability",
            "modifier_item_combo_breaker_buff",
            "modifier_item_aeon_disk_buff",
            "modifier_eul_cyclone",
            "modifier_black_king_bar_immune"
        };

        public static Boolean _Hello = true;
    }
}
