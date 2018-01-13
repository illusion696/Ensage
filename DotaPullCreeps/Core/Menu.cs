using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Items;

namespace SupportsRage.Core
{
    [Menu("Supports Rage")]
    public class Menu
    {
        public Menu()
        {
            Drawings = new DrawingsMenu();
            Hotkey = new HotkeySelector(Key.D, HotkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);

            LinkenSave = new LinkenSave();
            GlimmerSave = new LinkenSave();
            LotusSave = new LotusSave();
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
        public LinkenSave GlimmerSave { get; set; }

        [Menu("Lotus Save")]
        public LotusSave LotusSave { get; set; }

        [Menu("Glimmer for CUlts")]
        public GlimmerCUlts GlimmerCUlts { get; set; }
    }
    
    public class DrawingsMenu
    {
        [Item("On Top panel")]
        [DefaultValue(true)]
        public bool DrawingsOnTop { get; set; }
        [Item("On Hero")]
        [DefaultValue(true)]
        public bool DrawingsOnHero { get; set; }
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

                if (AbilityStorage._LowSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._MediumSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._DangerSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._UltSkills.Any(x => x.Id == _S1.Id)
                    )
                {
                    _Names.Add(_S1.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._LowSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._MediumSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._DangerSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S2.Id)
                   )
                {
                    _Names.Add(_S2.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._LowSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._MediumSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._DangerSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S3.Id)
                   )
                {
                    _Names.Add(_S3.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._LowSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._MediumSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._DangerSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S4.Id)
                   )
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

        public bool SavekeyDown { get; set; }
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

                if (AbilityStorage._DangerSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._UltSkills.Any(x => x.Id == _S1.Id)
                    )
                {
                    _Names.Add(_S1.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._DangerSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S2.Id)
                   )
                {
                    _Names.Add(_S2.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._DangerSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S3.Id)
                   )
                {
                    _Names.Add(_S3.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._DangerSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S4.Id)
                   )
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
    }

    public class LotusSave
    {
        public LotusSave()
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (AbilityStorage._LowSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._MediumSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._DangerSkills.Any(x => x.Id == _S1.Id) ||
                    AbilityStorage._UltSkills.Any(x => x.Id == _S1.Id)
                    )
                {
                    _Names.Add(_S1.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._LowSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._MediumSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._DangerSkills.Any(x => x.Id == _S2.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S2.Id)
                   )
                {
                    _Names.Add(_S2.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._LowSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._MediumSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._DangerSkills.Any(x => x.Id == _S3.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S3.Id)
                   )
                {
                    _Names.Add(_S3.Name);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._LowSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._MediumSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._DangerSkills.Any(x => x.Id == _S4.Id) ||
                   AbilityStorage._UltSkills.Any(x => x.Id == _S4.Id)
                   )
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

        public bool SavekeyDown { get; set; }
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
