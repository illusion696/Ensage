using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace RubickRage.Core
{
    [Menu("Rubick Rage")]
    public class Menu
    {
        public Menu()
        {
            Drawings = new DrawingsMenu();
            Hotkey = new HotkeySelector(Key.D, HotkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);

            LinkenSave = new LinkenSave();
            GlimmerSave = new GlimmerSave();
            LotusCombo = new LotusCombo();
            MainCombo = new MainCombo();
            GlimmerCUlts = new GlimmerCUlts();
        }

        [Item("Stack key")]
        public HotkeySelector Hotkey { get; set; }
        public bool HotkeyDown;
        private void HotkeyPressed(MenuInputEventArgs obj)
        {
            HotkeyDown = obj.Flag == HotkeyFlags.Down;
        }

        [Menu("Drawings")]
        public DrawingsMenu Drawings { get; set; }

        [Menu("Linken Save")]
        public LinkenSave LinkenSave { get; set; }

        [Menu("Glimmer Save")]
        public GlimmerSave GlimmerSave { get; set; }

        [Menu("Lotus Combo")]
        public LotusCombo LotusCombo { get; set; }

        [Menu("Main Combo")]
        public MainCombo MainCombo { get; set; }

        [Menu("Glimmer for CUlts")]
        public GlimmerCUlts GlimmerCUlts { get; set; }
    }

    [Menu]
    public class DrawingsMenu
    {
        [Item("On Top panel")]
        [DefaultValue(true)]
        public bool DrawingsOnTop { get; set; }
        [Item("On Hero")]
        [DefaultValue(true)]
        public bool DrawingsOnHero { get; set; }

        [Item("Lotus Combo panel")]
        [DefaultValue(true)]
        public bool DrawingsLotusCombo { get; set; }

        [Item("Lotus panel X")]
        public Slider<float> LotusPanelX { get; set; } = new Slider<float>(51, 0, 1900);
        [Item("Lotus panel Y")]
        public Slider<float> LotusPanelY { get; set; } = new Slider<float>(51, 0, 1200);
    }

    public class LinkenSave
    {
        public LinkenSave()
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S4.Id))
                {
                    _Names.Add(_S4.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            SaveFromKeys = _Names.ToArray();
            SaveFrom = new ImageToggler(true, SaveFromKeys);

            Savekey = new HotkeySelector(Key.L, SavekeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
            Togglekey = new HotkeySelector(Key.K, TogglekeyPressed, HotkeyFlags.Up);
        }

        [Item("Save from")]
        public ImageToggler SaveFrom { get; set; }
        public String[] SaveFromKeys { get; set; }

        [Item("Save key")]
        public HotkeySelector Savekey { get; set; }
        public bool SavekeyDown;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
        }

        [Item("Toggle key")]
        public HotkeySelector Togglekey { get; set; }

        [Item("Toggle enabled")]
        public bool ToggleEnabled { get; set; }
        private void TogglekeyPressed(MenuInputEventArgs obj)
        {
            ToggleEnabled = !ToggleEnabled;
        }

        [Item("Cast timing")]
        [Tooltip("How match time should left before target will be determined. (more > accuracy but > fails, lower < accuracy but < fails")]
        public Slider<float> CastTiming { get; set; } = new Slider<float>(20, 15, 40);
    }

    public class GlimmerSave
    {
        public GlimmerSave()
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S4.Id))
                {
                    _Names.Add(_S4.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            SaveFromKeys = _Names.ToArray();
            SaveFrom = new ImageToggler(true, SaveFromKeys);

            Savekey = new HotkeySelector(Key.L, SavekeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
            Togglekey = new HotkeySelector(Key.K, TogglekeyPressed, HotkeyFlags.Up);
        }

        [Item("Save from")]
        public ImageToggler SaveFrom { get; set; }
        public String[] SaveFromKeys { get; set; }

        [Item("Save key")]
        public HotkeySelector Savekey { get; set; }
        public bool SavekeyDown;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
        }

        [Item("Toggle key")]
        public HotkeySelector Togglekey { get; set; }

        [Item("Toggle enabled")]
        public bool ToggleEnabled { get; set; }
        private void TogglekeyPressed(MenuInputEventArgs obj)
        {
            ToggleEnabled = !ToggleEnabled;
        }

        [Item("Cast timing")]
        [Tooltip("How match time should left before target will be determined. (more > accuracy but > fails, lower < accuracy but < fails")]
        public Slider<float> CastTiming { get; set; } = new Slider<float>(20, 15, 40);
    }

    public class LotusCombo
    {
        public LotusCombo()
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (AbilityStorage._TargetSkills.Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    var _SpellData = AbilityStorage._TargetSkills.First(x => x.Id == _S1.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S1.Name, _Temp);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    var _SpellData = AbilityStorage._TargetSkills.First(x => x.Id == _S2.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S2.Name, _Temp);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    var _SpellData = AbilityStorage._TargetSkills.First(x => x.Id == _S3.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S3.Name, _Temp);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._TargetSkills.Any(x => x.Id == _S4.Id))
                {
                    _Names.Add(_S4.Name);
                    var _SpellData = AbilityStorage._TargetSkills.First(x => x.Id == _S4.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S4.Name, _Temp);
                    Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            SaveFromKeys = _Names.ToArray();
            SaveFrom = new ImageToggler(true, SaveFromKeys);

            Savekey = new HotkeySelector(Key.L, SavekeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
        }

        public Dictionary<String, LotusSpellConfig> LotusSpellConfigs = new Dictionary<string, LotusSpellConfig>();

        [Item("Spells")]
        public ImageToggler SaveFrom { get; set; }
        public String[] SaveFromKeys { get; set; }

        [Item("Combo key")]
        public HotkeySelector Savekey { get; set; }
        public bool SavekeyDown;
        private bool Togle;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
            if (SavekeyDown)
            {
                if (Togle == false)
                {
                    LotusLogic._Status = 0;
                    Config._ComboTask.RunAsync();
                    Togle = true;
                }
            }
            else
            {
                Togle = false;
                Config._ComboTask.Cancel();
            }
        }

        [Item("Cast timing")]
        [Tooltip("How match time should left before target will be determined. (more > accuracy but > fails, lower < accuracy but < fails")]
        public Slider<float> CastTiming { get; set; } = new Slider<float>(20, 15, 40);
    }

    public class LotusSpellConfig
    {
        public bool Steal { get; set; }
        public bool ForceUse { get; set; }
        public bool AnotherTarger { get; set; }
    }

    public class MainCombo
    {
        public MainCombo()
        {
            Config._Renderer.TextureManager.LoadFromDota("rubick_telekinesis", "resource\\flash3\\images\\spellicons\\rubick_telekinesis.png");
            Config._Renderer.TextureManager.LoadFromDota("rubick_fade_bolt", "resource\\flash3\\images\\spellicons\\rubick_fade_bolt.png");

            Use = new ImageToggler(true, new[] { "rubick_telekinesis", "rubick_fade_bolt" });

            ComboKey = new HotkeySelector(Key.G, KeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
        }
        
        [Item("Use Spells")]
        public ImageToggler Use { get; set; }

        [Item("Combo key")]
        public HotkeySelector ComboKey { get; set; }

        private bool Toggle;
        private void KeyPressed(MenuInputEventArgs obj)
        {
            if (obj.Flag == HotkeyFlags.Down)
            {
                if (Toggle == false)
                {
                    Toggle = true;
                    Config._ComboMainTask.RunAsync();
                }
            }
            else
            {
                Toggle = false;
                Config._ComboMainTask.Cancel();
            }
        }
    }

    public class GlimmerCUlts
    {
        public GlimmerCUlts()
        {
            Config._Renderer.TextureManager.LoadFromDota("bane_fiends_grip", "resource\\flash3\\images\\spellicons\\bane_fiends_grip.png");
            Config._Renderer.TextureManager.LoadFromDota("crystal_maiden_freezing_field", "resource\\flash3\\images\\spellicons\\crystal_maiden_freezing_field.png");
            Config._Renderer.TextureManager.LoadFromDota("witch_doctor_death_ward", "resource\\flash3\\images\\spellicons\\witch_doctor_death_ward.png");

            For = new ImageToggler(true, "bane_fiends_grip", "crystal_maiden_freezing_field", "witch_doctor_death_ward");

            Forkey = new HotkeySelector(Key.L, ForkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
            Togglekey = new HotkeySelector(Key.K, TogglekeyPressed, HotkeyFlags.Up);
        }

        [Item("Save from")]
        public ImageToggler For { get; set; }

        [Item("Save key")]
        public HotkeySelector Forkey { get; set; }

        public bool ForkeyDown { get; set; }
        private void ForkeyPressed(MenuInputEventArgs obj)
        {
            ForkeyDown = obj.Flag == HotkeyFlags.Down;
        }


        [Item("Toggle key")]
        public HotkeySelector Togglekey { get; set; }

        [Item("Toggle enabled")]
        public bool ToggleEnabled { get; set; }
        private void TogglekeyPressed(MenuInputEventArgs obj)
        {
            ToggleEnabled = !ToggleEnabled;
        }
    }
}
