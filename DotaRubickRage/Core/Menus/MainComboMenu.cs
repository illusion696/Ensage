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
                    Config._MainComboTask.RunAsync();
                }
            }
            else
            {
                Toggle = false;
                Config._MainComboTask.Cancel();
            }
        }
    }
}
