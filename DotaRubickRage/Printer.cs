using Ensage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage
{
    internal class Printer
    {
        public static void Print(string s, bool print = false)
        {
            //if (MenuManager.DebugInGame || print)
            Game.PrintMessage(s);
        }
    }
}
