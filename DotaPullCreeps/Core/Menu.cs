using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Items;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace SupportsRage.Core
{
    [Menu("Supports Rage")]
    public class Menu
    {
        public Menu(Logger _Log)
        {
            this.Drawings = new DrawingsMenu();
            Hotkey = new HotkeySelector(Key.D, this.HotkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);

            this.LinkenSave = new LinkenSave(_Log);
            this.GlimmerSave = new LinkenSave(_Log);
        }

        [Item("Stack key")]
        public HotkeySelector Hotkey { get; set; }
        public Boolean HotkeyDown;
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
    }

    [Menu("Drawings")]
    public class DrawingsMenu
    {
        [Item("On Top panel")]
        [DefaultValue(true)]
        public Boolean DrawingsOnTop { get; set; }
        [Item("On Hero")]
        [DefaultValue(true)]
        public Boolean DrawingsOnHero { get; set; }
    }
    
    public class LinkenSave
    {
        public LinkenSave(Logger _Log)
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (Core.AbilityStorage._LowSkills.Any(x => x.Id == _S1.Id) ||
                    Core.AbilityStorage._MediumSkills.Any(x => x.Id == _S1.Id) ||
                    Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S1.Id) ||
                    Core.AbilityStorage._UltSkills.Any(x => x.Id == _S1.Id)
                    )
                {
                    _Names.Add(_S1.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (Core.AbilityStorage._LowSkills.Any(x => x.Id == _S2.Id) ||
                   Core.AbilityStorage._MediumSkills.Any(x => x.Id == _S2.Id) ||
                   Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S2.Id) ||
                   Core.AbilityStorage._UltSkills.Any(x => x.Id == _S2.Id)
                   )
                {
                    _Names.Add(_S2.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (Core.AbilityStorage._LowSkills.Any(x => x.Id == _S3.Id) ||
                   Core.AbilityStorage._MediumSkills.Any(x => x.Id == _S3.Id) ||
                   Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S3.Id) ||
                   Core.AbilityStorage._UltSkills.Any(x => x.Id == _S3.Id)
                   )
                {
                    _Names.Add(_S3.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (Core.AbilityStorage._LowSkills.Any(x => x.Id == _S4.Id) ||
                   Core.AbilityStorage._MediumSkills.Any(x => x.Id == _S4.Id) ||
                   Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S4.Id) ||
                   Core.AbilityStorage._UltSkills.Any(x => x.Id == _S4.Id)
                   )
                {
                    _Names.Add(_S4.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            SaveFromKeys = _Names.ToArray();
            this.SaveFrom = new ImageToggler(true, SaveFromKeys);

            Savekey = new HotkeySelector(Key.L, this.SavekeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
        }

        [Item("Save from")]
        public ImageToggler SaveFrom { get; set; }
        public String[] SaveFromKeys { get; set; }

        [Item("Save key")]
        public HotkeySelector Savekey { get; set; }
        public Boolean SavekeyDown;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
        }
    }

    public class GlimmerSave
    {
        public GlimmerSave(Logger _Log)
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S1.Id) ||
                    Core.AbilityStorage._UltSkills.Any(x => x.Id == _S1.Id)
                    )
                {
                    _Names.Add(_S1.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S2.Id) ||
                   Core.AbilityStorage._UltSkills.Any(x => x.Id == _S2.Id)
                   )
                {
                    _Names.Add(_S2.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S3.Id) ||
                   Core.AbilityStorage._UltSkills.Any(x => x.Id == _S3.Id)
                   )
                {
                    _Names.Add(_S3.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (Core.AbilityStorage._DangerSkills.Any(x => x.Id == _S4.Id) ||
                   Core.AbilityStorage._UltSkills.Any(x => x.Id == _S4.Id)
                   )
                {
                    _Names.Add(_S4.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            SaveFromKeys = _Names.ToArray();
            this.SaveFrom = new ImageToggler(true, SaveFromKeys);

            Savekey = new HotkeySelector(Key.L, this.SavekeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
        }

        [Item("Save from")]
        public ImageToggler SaveFrom { get; set; }
        public String[] SaveFromKeys { get; set; }

        [Item("Save key")]
        public HotkeySelector Savekey { get; set; }
        public Boolean SavekeyDown;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
        }
    }
}
