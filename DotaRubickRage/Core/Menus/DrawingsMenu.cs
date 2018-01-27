using Ensage;
using Ensage.SDK.Menu;
using Ensage.SDK.Menu.Items;
using SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core.Menus
{
    public class Drawings
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

        [Item("Lotus panel Position")]
        public Slider<Vector2> LotusPanelPosition { get; set; } = new Slider<Vector2>(new Vector2(200, 50), new Vector2(0, 0), new Vector2(Drawing.Width - 10, Drawing.Height - 10));


        [Item("Steal panel")]
        [DefaultValue(true)]
        public bool DrawingsStealPanel { get; set; }

        [Item("Steal Position")]
        public Slider<Vector2> StealPanelPosition { get; set; } = new Slider<Vector2>(new Vector2(200, 100), new Vector2(0, 0), new Vector2(Drawing.Width - 10, Drawing.Height - 10));
    }
}
