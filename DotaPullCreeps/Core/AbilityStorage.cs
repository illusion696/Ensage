using SupportsRage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportsRage.Core
{
    public static class AbilityStorage
    {
        public static ProtectData[] _LowSkills = new ProtectData[]
        {
            new ProtectData
            {
                Id = Ensage.AbilityId.abaddon_death_coil,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.axe_battle_hunger,
                ForceUse = true,
                AnotherTarget = true
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.brewmaster_drunken_haze,
                ForceUse = true,
                AnotherTarget = true
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.abaddon_death_coil,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.night_stalker_void,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.broodmother_spawn_spiderlings,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.luna_lucent_beam,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.medusa_mystic_snake,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.phantom_lancer_spirit_lance,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.ancient_apparition_cold_feet,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.dazzle_poison_touch,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.disruptor_thunder_strike,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.leshrac_lightning_storm,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.shadow_shaman_ether_shock,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.visage_soul_assumption,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.warlock_shadow_word,
                ForceUse = true,
                AnotherTarget = false
            },
        };
        public static ProtectData[] _MediumSkills = new ProtectData[]
        {
            new ProtectData
            {
                Id = Ensage.AbilityId.centaur_double_edge,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.night_stalker_crippling_fear,
                ForceUse = true,
                AnotherTarget = true
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.tiny_toss,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.treant_leech_seed,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.arc_warden_flux,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bounty_hunter_shuriken_toss,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.gyrocopter_homing_missile,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.nyx_assassin_mana_burn,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bane_enfeeble,
                ForceUse = true,
                AnotherTarget = true
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bane_brain_sap,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.enigma_malefice,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.keeper_of_the_light_mana_leak,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.lich_frost_nova,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.queenofpain_shadow_strike,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.zuus_lightning_bolt,
                ForceUse = true,
                AnotherTarget = false
            },
        };
        public static ProtectData[] _DangerSkills = new ProtectData[]
        {
            new ProtectData
            {
                Id = Ensage.AbilityId.chaos_knight_chaos_bolt,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.dragon_knight_dragon_tail,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.sven_storm_bolt,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.skeleton_king_hellfire_blast,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.naga_siren_ensnare,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.terrorblade_reflection,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.vengefulspirit_magic_missile,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.razor_static_link,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bane_nightmare,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.chen_test_of_faith,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.crystal_maiden_frostbite,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.death_prophet_spirit_siphon,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.invoker_cold_snap,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.lion_voodoo,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.ogre_magi_fireblast,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.ogre_magi_unrefined_fireblast,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.ogre_magi_ignite,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.oracle_fortunes_end,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.obsidian_destroyer_astral_imprisonment,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.pugna_decrepify,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.shadow_demon_disruption,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.shadow_shaman_shackles,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.shadow_shaman_voodoo,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.silencer_last_word,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.tinker_laser,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.witch_doctor_paralyzing_cask,
                ForceUse = true,
                AnotherTarget = false
            },
        };
        public static ProtectData[] _UltSkills = new ProtectData[]
        {
            new ProtectData
            {
                Id = Ensage.AbilityId.axe_culling_blade,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.beastmaster_primal_roar,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.doom_bringer_doom,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.huskar_life_break,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.legion_commander_duel,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.pudge_dismember,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.spirit_breaker_nether_strike,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.lina_laguna_blade,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.antimage_mana_void,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bloodseeker_rupture,
                ForceUse = true,
                AnotherTarget = true
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bounty_hunter_track,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.juggernaut_omni_slash,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.sniper_assassinate,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.terrorblade_sunder,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.vengefulspirit_nether_swap,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.viper_viper_strike,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.bane_fiends_grip,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.batrider_flaming_lasso,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.lich_chain_frost,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.lion_finger_of_death,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.necrolyte_reapers_scythe,
                ForceUse = false,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.pugna_life_drain,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.shadow_demon_demonic_purge,
                ForceUse = true,
                AnotherTarget = false
            },
            new ProtectData
            {
                Id = Ensage.AbilityId.winter_wyvern_winters_curse,
                ForceUse = false,
                AnotherTarget = false
            },
        };
    }
}
