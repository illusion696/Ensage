
using System;
using System.Collections.Generic;
using System.Linq;
using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Extensions;

namespace RubickRage.Core.Helpers
{
    public static class DamageManager
    {
        //public static float _LandDemage()
        //{
        //    return Config._QSpell.GetAbilitySpecialData("damage", Config._QSpell.Level);
        //}
        //public static float _LandDemage(Hero _Enemy)
        //{
        //    return  _LandDemage() * (1 - Config._QSpell.GetDamageReduction(_Enemy));
        //}
      
        private static readonly string[] IgnoreModifiers = {
            "modifier_templar_assassin_refraction_absorb",
            "modifier_item_blade_mail_reflect",
            "modifier_item_lotus_orb_active",
            "modifier_nyx_assassin_spiked_carapace",
            "modifier_medusa_stone_gaze_stone",
            "modifier_winter_wyvern_winters_curse"
        };
    }
}
