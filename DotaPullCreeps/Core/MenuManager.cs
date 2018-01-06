using Ensage.Common.Menu;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullCreeps.Core
{
    public static class MenuManager
    {
        public static readonly Menu Menu = new Menu("Support Pullings", "Support Pullings", true);
        
        public static Boolean DrawingsOnHero => GetBool("Drawings.OnHero");
        public static Boolean DrawingsOnTop => GetBool("Drawings.OnTop");
        public static KeyBind Key => GetKey("Key");


        public static void Init()
        {
            var _Drawings = new Menu("Drawings", "Drawings");
            _Drawings.AddItem(new MenuItem("Drawings.OnHero", "On Hero").SetValue(true));
            _Drawings.AddItem(new MenuItem("Drawings.OnTop", "On Top panel").SetValue(true));
            Menu.AddSubMenu(_Drawings);

            Menu.AddItem(new MenuItem("Key", "Key bind").SetValue(new KeyBind('U')));
            
            Menu.AddToMainMenu();
        }

       
        private static float GetSlider(string item)
        {
            return Menu.Item(item).GetValue<Slider>().Value;
        }
        private static KeyBind GetKey(string item)
        {
            return Menu.Item(item).GetValue<KeyBind>();
        }
        private static bool GetBool(string item)
        {
            return Menu.Item(item).GetValue<bool>();
        }
        private static int GetStringList(string item)
        {
            return Menu.Item(item).GetValue<StringList>().SelectedIndex;
        }
    }
}
