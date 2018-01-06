using Ensage;
using Ensage.Common;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullCreeps.Drawings
{
    public static class Info
    {
        public static void Drawing_OnDraw(EventArgs args)
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
            //    Drawing.DrawText("Status " + Core.Config.Status + " ",
            //       "Arial", Drawing.WorldToScreen(Core.Config._Hero.Position), new Vector2(40, 40), Color.Red, FontFlags.Italic);
            //}

            if (Core.Config.DoStack)
            {
                if (Core.MenuManager.DrawingsOnTop)
                {
                    Drawing.DrawRect(HUDInfo.GetTopPanelPosition(Core.Config._Hero) + new Vector2(0, 60),
                        new Vector2((float)HUDInfo.GetTopPanelSizeX(Core.Config._Hero), (float)HUDInfo.GetTopPanelSizeY(Core.Config._Hero)), Color.Green);
                }

                if (Core.MenuManager.DrawingsOnHero)
                {
                    String _Text = "Pulling...";
                    var _Pos = HUDInfo.GetHPbarPosition(Core.Config._Hero);
                    var _Size = new Vector2((float)HUDInfo.GetHPBarSizeX(Core.Config._Hero), (float)HUDInfo.GetHpBarSizeY(Core.Config._Hero));
                    var _TextSize = Drawing.MeasureText(_Text, "Arial", new Vector2((float)(_Size.Y * 1.5), (float)(_Size.Y * 1.5)), FontFlags.None);
                    var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
                    Drawing.DrawText(
                        _Text,
                        _TextPos,
                        new Vector2(_TextSize.Y, 0),
                        Color.White,
                        FontFlags.None);
                }
            }
        }
    }
}
