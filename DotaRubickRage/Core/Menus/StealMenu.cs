using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Items;
using RubickRage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RubickRage.Core.Menus
{
    public class Steal
    {
        public Steal()
        {
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (AbilityStorage._AllSkills.Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    SpellConfigs.Add(_S1.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._AllSkills.Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    SpellConfigs.Add(_S2.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._AllSkills.Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    SpellConfigs.Add(_S3.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._AllSkills.Any(x => x.Id == _S4.Id))
                {
                    _Names.Add(_S4.Name);
                    SpellConfigs.Add(_S4.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            StealKeys = _Names.ToArray();
            StealSpells = new ImageToggler(true, StealKeys);

            Stealkey = new HotkeySelector(Key.L, StealkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);
        }

        public void ReBind()
        {
            SpellConfigs = new Dictionary<string, bool>();
            List<String> _Names = new List<String>();
            foreach (var H in EntityManager<Hero>.Entities.Where(x => x.Team != Config._Hero.Team))
            {
                var _S1 = H.Spellbook.SpellQ;
                var _S2 = H.Spellbook.SpellW;
                var _S3 = H.Spellbook.SpellE;
                var _S4 = H.Spellbook.SpellR;

                if (AbilityStorage._AllSkills.Any(x => x.Id == _S1.Id))
                {
                    _Names.Add(_S1.Name);
                    SpellConfigs.Add(_S1.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S1.Name, $"resource\\flash3\\images\\spellicons\\{_S1.TextureName}.png");
                }
                if (AbilityStorage._AllSkills.Any(x => x.Id == _S2.Id))
                {
                    _Names.Add(_S2.Name);
                    SpellConfigs.Add(_S2.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S2.Name, $"resource\\flash3\\images\\spellicons\\{_S2.TextureName}.png");
                }
                if (AbilityStorage._AllSkills.Any(x => x.Id == _S3.Id))
                {
                    _Names.Add(_S3.Name);
                    SpellConfigs.Add(_S3.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S3.Name, $"resource\\flash3\\images\\spellicons\\{_S3.TextureName}.png");
                }
                if (AbilityStorage._AllSkills.Any(x => x.Id == _S4.Id))
                {
                    _Names.Add(_S4.Name);
                    SpellConfigs.Add(_S4.Name, false);
                    Config._Renderer.TextureManager.LoadFromDota(_S4.Name, $"resource\\flash3\\images\\spellicons\\{_S4.TextureName}.png");
                }
            }

            StealKeys = _Names.ToArray();
            StealSpells = new ImageToggler(true, StealKeys);
        }

        public Dictionary<String, Boolean> SpellConfigs = new Dictionary<string, Boolean>();

        [Item("Spells")]
        public ImageToggler StealSpells { get; set; }
        public String[] StealKeys { get; set; }

        [Item("Steal key")]
        public HotkeySelector Stealkey { get; set; }
        public bool StealkeyDown;
        private bool Togle;
        private void StealkeyPressed(MenuInputEventArgs obj)
        {
            StealkeyDown = obj.Flag == HotkeyFlags.Down;
            if (StealkeyDown)
            {
                if (Togle == false)
                {
                    Core.Logics.StealLogic._Status = 0;
                    Config._StealTask.RunAsync();
                    Togle = true;
                }
            }
            else
            {
                Togle = false;
                Config._StealTask.Cancel();
            }
        }
    }
}
