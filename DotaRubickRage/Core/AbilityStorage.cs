using Ensage;
using RubickRage.Models;

namespace RubickRage.Core
{
    public static class AbilityStorage
    {
        public static ProtectData[] _TargetSkills = new ProtectData[]
        {
            new ProtectData
            {
                Id = AbilityId.abaddon_death_coil,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.axe_battle_hunger,
                ForceUse = true,
                AnotherTarget = true,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.brewmaster_drunken_haze,
                ForceUse = true,
                AnotherTarget = true,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.abaddon_death_coil,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.night_stalker_void,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.broodmother_spawn_spiderlings,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.luna_lucent_beam,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.medusa_mystic_snake,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.phantom_lancer_spirit_lance,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.ancient_apparition_cold_feet,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.dazzle_poison_touch,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.disruptor_thunder_strike,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.leshrac_lightning_storm,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.shadow_shaman_ether_shock,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.visage_soul_assumption,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.warlock_shadow_word,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 1
            },
            new ProtectData
            {
                Id = AbilityId.centaur_double_edge,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.night_stalker_crippling_fear,
                ForceUse = true,
                AnotherTarget = true,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.tiny_toss,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.treant_leech_seed,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.arc_warden_flux,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.bounty_hunter_shuriken_toss,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.gyrocopter_homing_missile,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.nyx_assassin_mana_burn,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.bane_enfeeble,
                ForceUse = true,
                AnotherTarget = true,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.bane_brain_sap,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.enigma_malefice,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.keeper_of_the_light_mana_leak,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.lich_frost_nova,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.queenofpain_shadow_strike,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.zuus_lightning_bolt,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 2
            },
            new ProtectData
            {
                Id = AbilityId.chaos_knight_chaos_bolt,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.dragon_knight_dragon_tail,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.sven_storm_bolt,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.skeleton_king_hellfire_blast,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.naga_siren_ensnare,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.terrorblade_reflection,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.vengefulspirit_magic_missile,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.razor_static_link,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.bane_nightmare,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.chen_test_of_faith,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.crystal_maiden_frostbite,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.death_prophet_spirit_siphon,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.invoker_cold_snap,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.lion_voodoo,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.ogre_magi_fireblast,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.ogre_magi_unrefined_fireblast,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.ogre_magi_ignite,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.oracle_fortunes_end,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.obsidian_destroyer_astral_imprisonment,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.pugna_decrepify,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.shadow_demon_disruption,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.shadow_shaman_shackles,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.shadow_shaman_voodoo,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.silencer_last_word,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.tinker_laser,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.witch_doctor_paralyzing_cask,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 3
            },
            new ProtectData
            {
                Id = AbilityId.axe_culling_blade,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.beastmaster_primal_roar,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.doom_bringer_doom,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.huskar_life_break,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.legion_commander_duel,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.pudge_dismember,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.spirit_breaker_nether_strike,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.lina_laguna_blade,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.antimage_mana_void,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.bloodseeker_rupture,
                ForceUse = true,
                AnotherTarget = true,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.bounty_hunter_track,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.juggernaut_omni_slash,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.sniper_assassinate,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.terrorblade_sunder,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.vengefulspirit_nether_swap,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.viper_viper_strike,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.bane_fiends_grip,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.batrider_flaming_lasso,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.lich_chain_frost,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.lion_finger_of_death,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.necrolyte_reapers_scythe,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.pugna_life_drain,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.shadow_demon_demonic_purge,
                ForceUse = true,
                AnotherTarget = false,
                DangerLevel = 4
            },
            new ProtectData
            {
                Id = AbilityId.winter_wyvern_winters_curse,
                ForceUse = false,
                AnotherTarget = false,
                DangerLevel = 4
            },
        };
    }
}
