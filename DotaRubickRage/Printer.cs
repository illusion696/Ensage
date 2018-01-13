using Ensage;

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
