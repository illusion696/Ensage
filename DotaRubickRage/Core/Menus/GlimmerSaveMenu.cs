using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RubickRage.Core.Menus
{
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

        public void ReBind()
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
}
