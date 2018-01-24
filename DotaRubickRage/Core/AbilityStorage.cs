using Ensage;
using RubickRage.Models;
using System;

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
        
        public static StealData[] _AllSkills = new StealData[]
        {
            new StealData
            {
                  Id = AbilityId.abaddon_aphotic_shield,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.abaddon_death_coil,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.abyssal_underlord_dark_rift,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.abyssal_underlord_firestorm,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.abyssal_underlord_pit_of_malice,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.alchemist_acid_spray,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.alchemist_chemical_rage,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.alchemist_unstable_concoction,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.ancient_apparition_chilling_touch,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.ancient_apparition_cold_feet,
                  Type = SpellType.PositionBuff
            },
            new StealData
            {
                  Id = AbilityId.ancient_apparition_ice_blast,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.ancient_apparition_ice_vortex,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.antimage_mana_void,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.arc_warden_flux,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.arc_warden_magnetic_field,
                  Type = SpellType.PositionBuff
            },
            new StealData
            {
                  Id = AbilityId.arc_warden_spark_wraith,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.arc_warden_tempest_double,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.axe_battle_hunger,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.axe_berserkers_call,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.axe_culling_blade,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.bane_brain_sap,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.bane_enfeeble,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.bane_fiends_grip,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.bane_nightmare,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.batrider_firefly,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.batrider_flamebreak,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.batrider_flaming_lasso,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.batrider_sticky_napalm,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.beastmaster_wild_axes,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.beastmaster_primal_roar,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.bloodseeker_bloodrage,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.bloodseeker_rupture,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.bloodseeker_thirst,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.bounty_hunter_shuriken_toss,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.bounty_hunter_track,
                  Type = SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.brewmaster_thunder_clap,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.bristleback_quill_spray,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.broodmother_spawn_spiderite,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.broodmother_insatiable_hunger,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.centaur_double_edge,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.centaur_hoof_stomp,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.centaur_stampede,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.chaos_knight_chaos_bolt,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.chaos_knight_phantasm,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.chaos_knight_reality_rift,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.chen_hand_of_god,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.chen_holy_persuasion,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.chen_test_of_faith,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.clinkz_death_pact,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.clinkz_searing_arrows,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.clinkz_strafe,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.crystal_maiden_crystal_nova,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.crystal_maiden_freezing_field,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.crystal_maiden_frostbite,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.dark_seer_ion_shell,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.dark_seer_surge,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dark_seer_vacuum,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.dark_seer_wall_of_replica,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.dark_willow_bedlam,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dark_willow_bramble_maze,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dark_willow_cursed_crown,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dark_willow_shadow_realm,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dazzle_poison_touch,
                  Type =SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.dazzle_shadow_wave,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.dazzle_shallow_grave,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dazzle_weave,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.death_prophet_carrion_swarm,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.death_prophet_exorcism,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.death_prophet_spirit_siphon,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.death_prophet_witchcraft,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.disruptor_glimpse,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.disruptor_kinetic_field,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.disruptor_static_storm,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.disruptor_thunder_strike,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.doom_bringer_devour,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.doom_bringer_doom,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.doom_bringer_infernal_blade,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.doom_bringer_scorched_earth,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.dragon_knight_breathe_fire,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.dragon_knight_dragon_tail,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.dragon_knight_elder_dragon_form,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.drow_ranger_frost_arrows,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.drow_ranger_wave_of_silence,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.earthshaker_echo_slam,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.earthshaker_enchant_totem,
                  Type = SpellType.SelfBuff 
            },
            new StealData
            {
                  Id = AbilityId.earthshaker_fissure,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.earth_spirit_boulder_smash,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.earth_spirit_geomagnetic_grip,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.earth_spirit_magnetize,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.earth_spirit_rolling_boulder,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.elder_titan_ancestral_spirit,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.ember_spirit_flame_guard,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.ember_spirit_searing_chains,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.ember_spirit_sleight_of_fist,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.enchantress_enchant,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.enchantress_impetus,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.enchantress_untouchable,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.enigma_black_hole,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.enigma_demonic_conversion,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.enigma_malefice,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.enigma_midnight_pulse,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.faceless_void_chronosphere,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.faceless_void_time_lock,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.furion_force_of_nature,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.furion_sprout,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.furion_wrath_of_nature,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.gyrocopter_call_down,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.gyrocopter_flak_cannon,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.gyrocopter_homing_missile,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.gyrocopter_rocket_barrage,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.huskar_burning_spear,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.huskar_life_break,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.huskar_inner_vitality,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.invoker_alacrity,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.invoker_chaos_meteor,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.invoker_cold_snap,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.invoker_emp,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.invoker_deafening_blast,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.invoker_forge_spirit,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.invoker_ice_wall,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.invoker_sun_strike,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.invoker_tornado,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.jakiro_ice_path,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.jakiro_dual_breath,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.jakiro_macropyre,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.juggernaut_healing_ward,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.juggernaut_blade_fury,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.juggernaut_omni_slash,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.keeper_of_the_light_mana_leak,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.kunkka_ghostship,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.kunkka_torrent,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.kunkka_return,
                  Type = SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.legion_commander_duel,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.legion_commander_moment_of_courage,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.legion_commander_overwhelming_odds,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.legion_commander_press_the_attack,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.leshrac_diabolic_edict,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.leshrac_lightning_storm,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.leshrac_pulse_nova,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.leshrac_split_earth,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.lich_chain_frost,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.lich_frost_nova,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.life_stealer_rage,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.lina_dragon_slave,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.lina_laguna_blade,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.lina_light_strike_array,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.lion_finger_of_death,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.lion_impale,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.lion_voodoo,
                  Type = SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.luna_eclipse,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.luna_lucent_beam,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.lycan_howl,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.lycan_summon_wolves,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.lycan_shapeshift,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.magnataur_empower,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.magnataur_shockwave,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.magnataur_skewer,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.magnataur_reverse_polarity,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.medusa_mystic_snake,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.medusa_stone_gaze,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.mirana_arrow,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.mirana_invis,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.mirana_leap,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.mirana_starfall,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.monkey_king_boundless_strike,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.monkey_king_wukongs_command,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.morphling_waveform,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.naga_siren_mirror_image,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.naga_siren_ensnare,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.naga_siren_song_of_the_siren,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.necrolyte_death_pulse,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.necrolyte_reapers_scythe,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.night_stalker_crippling_fear,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.night_stalker_darkness,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.night_stalker_void,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.nyx_assassin_spiked_carapace,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.nyx_assassin_impale,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.nyx_assassin_mana_burn,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.nyx_assassin_vendetta,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.obsidian_destroyer_arcane_orb,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.obsidian_destroyer_astral_imprisonment,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.obsidian_destroyer_sanity_eclipse,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.ogre_magi_bloodlust,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.ogre_magi_fireblast,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.ogre_magi_ignite,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.ogre_magi_unrefined_fireblast,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.omniknight_guardian_angel,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.omniknight_purification,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.omniknight_repel,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.pangolier_gyroshell,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pangolier_heartpiercer,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pangolier_swashbuckle,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.phantom_assassin_stifling_dagger,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.phantom_assassin_phantom_strike,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.phantom_lancer_spirit_lance,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.phoenix_fire_spirits,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.phoenix_icarus_dive,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.phoenix_supernova,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.puck_dream_coil,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.puck_illusory_orb,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.puck_waning_rift,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pudge_dismember,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.pudge_meat_hook,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pudge_rot,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pugna_life_drain,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.pugna_nether_blast,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pugna_nether_ward,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.pugna_decrepify,
                  Type = SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.queenofpain_scream_of_pain,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.queenofpain_shadow_strike,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.queenofpain_sonic_wave,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.rattletrap_battery_assault,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.rattletrap_hookshot,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.rattletrap_power_cogs,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.rattletrap_rocket_flare,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.razor_static_link,
                  Type =SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.razor_plasma_field,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.razor_eye_of_the_storm,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.riki_blink_strike,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.riki_smoke_screen,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.riki_tricks_of_the_trade,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.sandking_burrowstrike,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.sandking_epicenter,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.shadow_demon_demonic_purge,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.shadow_demon_disruption,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.shadow_demon_shadow_poison,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.shadow_demon_soul_catcher,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.shadow_shaman_ether_shock,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.shadow_shaman_mass_serpent_ward,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.shadow_shaman_shackles,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.shadow_shaman_voodoo,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.shredder_chakram,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.shredder_timber_chain,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.shredder_whirling_death,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.silencer_curse_of_the_silent,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.silencer_glaives_of_wisdom,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.silencer_global_silence,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.silencer_last_word,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.skeleton_king_hellfire_blast,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.skywrath_mage_ancient_seal,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.skywrath_mage_arcane_bolt,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.skywrath_mage_concussive_shot,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.skywrath_mage_mystic_flare,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.slardar_amplify_damage,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.slardar_sprint,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.slardar_slithereen_crush,
                  Type = SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.slark_dark_pact,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.slark_pounce,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.slark_shadow_dance,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.sniper_assassinate,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.sniper_shrapnel,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.spectre_haunt,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.spectre_spectral_dagger,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.spirit_breaker_charge_of_darkness,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.spirit_breaker_nether_strike,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.storm_spirit_ball_lightning,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.storm_spirit_electric_vortex,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.storm_spirit_static_remnant,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.sven_gods_strength,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.sven_storm_bolt,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.sven_warcry,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.templar_assassin_meld,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.templar_assassin_refraction,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.terrorblade_conjure_image,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.terrorblade_metamorphosis,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.terrorblade_reflection,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.terrorblade_sunder,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.tidehunter_ravage,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.tinker_laser,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.tinker_heat_seeking_missile,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.tinker_march_of_the_machines,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.tinker_rearm,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.tiny_avalanche,
                  Type =  SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.tiny_toss,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.treant_leech_seed,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.treant_overgrowth,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.troll_warlord_berserkers_rage,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.tusk_frozen_sigil,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.tusk_ice_shards,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.tusk_snowball,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.tusk_walrus_punch,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.undying_decay,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.undying_flesh_golem,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.undying_soul_rip,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.undying_tombstone,
                  Type =  SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.ursa_earthshock,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.ursa_enrage,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.ursa_overpower,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.vengefulspirit_magic_missile,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.vengefulspirit_nether_swap,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.vengefulspirit_wave_of_terror,
                  Type =  SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.venomancer_plague_ward,
                  Type =  SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.venomancer_poison_nova,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.venomancer_venomous_gale,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.viper_viper_strike,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.visage_soul_assumption,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.visage_summon_familiars,
                  Type =  SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.visage_grave_chill,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.warlock_shadow_word,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.warlock_fatal_bonds,
                  Type = SpellType.TargetDebuff
            },
            new StealData
            {
                  Id = AbilityId.warlock_golem_flaming_fists,
                  Type = SpellType.PositionStun
            },
            new StealData
            {
                  Id = AbilityId.warlock_upheaval,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.weaver_shukuchi,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.weaver_time_lapse,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.weaver_geminate_attack,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.windrunner_focusfire,
                  Type =SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.windrunner_powershot,
                  Type =SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.windrunner_shackleshot,
                  Type =SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.windrunner_windrun,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.winter_wyvern_arctic_burn,
                  Type = SpellType.SelfBuff
            },
            new StealData
            {
                  Id = AbilityId.winter_wyvern_cold_embrace,
                  Type = SpellType.TargetBuff
            },
            new StealData
            {
                  Id = AbilityId.winter_wyvern_splinter_blast,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.winter_wyvern_winters_curse,
                  Type = SpellType.TargetStun
            },
            new StealData
            {
                  Id = AbilityId.witch_doctor_death_ward,
                  Type = SpellType.PositionDamage
            },
            new StealData
            {
                  Id = AbilityId.witch_doctor_maledict,
                  Type = SpellType.PositionDebuff
            },
            new StealData
            {
                  Id = AbilityId.witch_doctor_paralyzing_cask,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.zuus_arc_lightning,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.zuus_lightning_bolt,
                  Type = SpellType.TargetDamage
            },
            new StealData
            {
                  Id = AbilityId.zuus_thundergods_wrath,
                  Type = SpellType.PositionDamage
            },
        };
    }
}
