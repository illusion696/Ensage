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
