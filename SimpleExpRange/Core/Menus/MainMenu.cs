using Ensage.SDK.Menu;
using System.ComponentModel;

namespace SimpleExpRange.Core.Menus
{
    [Menu("Simple Exp Range")]
    public class Menu
    {
        [Item("Display Experience Range")]
        [DefaultValue(true)]
        public bool ExpRange { get; set; }
    }
}
