using System;
using Ensage.Common;
using SharpDX;
using SupportsRage.Core;
using Color = System.Drawing.Color;

namespace SupportsRage.Drawings
{
    public static class Info
    {
        public static void OnDraw(object sender, EventArgs eventArgs)
        {
            //foreach (var C in Core.Config.GetCamps)
            //{
            //    Drawing.DrawText("Camp " + C.Id, "Arial", Drawing.WorldToScreen(C.TablePos), new Vector2(20, 20), Color.Red, FontFlags.Italic);
            //    Drawing.DrawCircle(Drawing.WorldToScreen(C.StackPos), 10, 10, Color.Red);
            //    Drawing.DrawCircle(Drawing.WorldToScreen(C.PreparePos), 10, 10, Color.Red);
            //}

            //if (Core.Config.DrawConsole)
            //{
            //    Drawing.DrawText("POS " + Core.Config._Hero.Position.X + " " + Core.Config._Hero.Position.Y + " " + Core.Config._Hero.Position.Z,
            //        "Arial", Drawing.WorldToScreen(Core.Config._Hero.Position), new Vector2(40, 40), Color.Red, FontFlags.Italic);
            //}
            //else
            //{
            //    Drawing.DrawText("Status " + Core.Config.Status + " " + " " + Core.Config._Hero.IsAttacking() + " " + Core.Config.ForTest,
            //       "Arial", Drawing.WorldToScreen(Core.Config._Hero.Position), new Vector2(40, 40), Color.Red, FontFlags.Italic);
            //}

            if (Config.DoStack)
            {
                if (Config._Menu.Drawings.DrawingsOnTop)
                {
                    var _Temp = HUDInfo.GetTopPanelPosition(Config._Hero) + new Vector2(0, 60);
                    Config._Renderer.DrawRectangle(new RectangleF(_Temp.X, _Temp.Y, (float)HUDInfo.GetTopPanelSizeX(Config._Hero), (float)HUDInfo.GetTopPanelSizeY(Config._Hero)), Color.Green, 2);
                }

                if (Config._Menu.Drawings.DrawingsOnHero)
                {
                    String _Text = "Pulling...";
                    var _Pos = HUDInfo.GetHPbarPosition(Config._Hero);
                    var _TextSize = Config._Renderer.MessureText(_Text);
                    var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
                    Config._Renderer.DrawText(_TextPos, _Text, Color.White);
                }
            }
        }
    }
}
