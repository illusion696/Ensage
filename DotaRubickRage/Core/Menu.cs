using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Entries;
using Ensage.SDK.Menu.Items;
using Ensage.SDK.Renderer;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RubickRage.Core
{
    [Menu("Rubick Rage")]
    public class Menu
    {
        public Menu(Logger _Log)
        {
            this.Drawings = new DrawingsMenu();
            Hotkey = new HotkeySelector(Key.D, this.HotkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);

            this.LinkenSave = new LinkenSave(_Log);
            this.GlimmerSave = new LinkenSave(_Log);
            this.LotusCombo = new LotusCombo(_Log);
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

        [Menu("Lotus Combo")]
        public LotusCombo LotusCombo { get; set; }
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
        public LinkenSave(Logger _Log)
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S4.Id))
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
        public bool SavekeyDown;
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

                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Where(x => x.DangerLevel > 2).Any(x => x.Id == _S4.Id))
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
        public bool SavekeyDown;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
        }
    }

    public class LotusCombo
    {
        public LotusCombo(Logger _Log)
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Core.Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (Core.AbilityStorage._TargetSkills.Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    var _SpellData = AbilityStorage._TargetSkills.FirstOrDefault(x => x.Id == _S1.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S1.Name, _Temp);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    var _SpellData = AbilityStorage._TargetSkills.FirstOrDefault(x => x.Id == _S2.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S2.Name, _Temp);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    var _SpellData = AbilityStorage._TargetSkills.FirstOrDefault(x => x.Id == _S3.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S3.Name, _Temp);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (Core.AbilityStorage._TargetSkills.Any(x => x.Id == _S4.Id))
                {
                    _Names.Add(_S4.Name);
                    var _SpellData = AbilityStorage._TargetSkills.FirstOrDefault(x => x.Id == _S4.Id);
                    var _Temp = new LotusSpellConfig()
                    {
                        AnotherTarger = _SpellData.AnotherTarget,
                        ForceUse = _SpellData.ForceUse
                    };
                    LotusSpellConfigs.Add(_S4.Name, _Temp);
                    Core.Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            SaveFromKeys = _Names.ToArray();
            this.SaveFrom = new ImageToggler(true, SaveFromKeys);

            Savekey = new HotkeySelector(Key.N, this.SavekeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
        }

        public Dictionary<String, LotusSpellConfig> LotusSpellConfigs = new Dictionary<string, LotusSpellConfig>();

        [Item("Spells")]
        public ImageToggler SaveFrom { get; set; }
        public String[] SaveFromKeys { get; set; }

        [Item("Combo key")]
        public HotkeySelector Savekey { get; set; }
        public bool SavekeyDown;
        bool Togle = false;
        private void SavekeyPressed(MenuInputEventArgs obj)
        {
            SavekeyDown = obj.Flag == HotkeyFlags.Down;
            if (SavekeyDown)
            {
                if (Togle == false)
                {
                    Core.LotusLogic._Status = 0;
                    Core.Config.comboTask.RunAsync();
                    Togle = true;
                }
            }
            else
            {
                Togle = false;
                Core.Config.comboTask.Cancel();
            }
        }
    }

    public class LotusSpellConfig
    {
        public bool Steal { get; set; }
        public bool ForceUse { get; set; }
        public bool AnotherTarger { get; set; }
    }
}
