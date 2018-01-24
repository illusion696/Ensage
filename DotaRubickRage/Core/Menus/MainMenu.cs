using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Attributes;
using Ensage.SDK.Menu.Items;
using System.Windows.Input;

namespace RubickRage.Core.Menus
{
    [Menu("Rubick Rage"), TextureResource("RubR_Logo", @"Images.IngameLogo.png")]
    public class Menu
    {
        public Menu()
        {
            Drawings = new Drawings();
            Hotkey = new HotkeySelector(Key.D, HotkeyPressed, HotkeyFlags.Down | HotkeyFlags.Up);

            LinkenSave = new LinkenSave();
            GlimmerSave = new GlimmerSave();
            LotusCombo = new LotusCombo();
            MainCombo = new MainCombo();
            GlimmerCUlts = new GlimmerCUlts();
            Steal = new Steal();
        }

        [Item("Stack key")]
        public HotkeySelector Hotkey { get; set; }
        public bool HotkeyDown;
        private void HotkeyPressed(MenuInputEventArgs obj)
        {
            HotkeyDown = obj.Flag == HotkeyFlags.Down;
        }

        [Menu("Drawings")]
        public Drawings Drawings { get; set; }

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

        [Menu("Steal configs")]
        public Steal Steal { get; set; }
    }
}
