using Ensage.Common;
using SharpDX;
using System;

namespace RubickRage.Drawings
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

            //if (Core.Config.DoStack)
            //{
            //    if (Core.Config._Menu.Drawings.DrawingsOnTop)
            //    {
            //        var _Temp = HUDInfo.GetTopPanelPosition(Core.Config._Hero) + new Vector2(0, 60);
            //        Core.Config._Renderer.DrawRectangle(new RectangleF(_Temp.X, _Temp.Y, (float)HUDInfo.GetTopPanelSizeX(Core.Config._Hero), (float)HUDInfo.GetTopPanelSizeY(Core.Config._Hero)), System.Drawing.Color.Green, 2);
            //    }

            //    if (Core.Config._Menu.Drawings.DrawingsOnHero)
            //    {
            //        String _Text = "Pulling...";
            //        var _Pos = HUDInfo.GetHPbarPosition(Core.Config._Hero);
            //        var _Size = new Vector2((float)HUDInfo.GetHPBarSizeX(Core.Config._Hero), (float)HUDInfo.GetHpBarSizeY(Core.Config._Hero));
            //        var _TextSize = Core.Config._Renderer.MessureText(_Text);
            //        var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
            //        Core.Config._Renderer.DrawText(_TextPos, _Text, System.Drawing.Color.White);
            //    }
            //}

            String _Text = "Status " + Core.LotusLogic._Status;
            var _Pos = HUDInfo.GetHPbarPosition(Core.Config._Hero);
            var _TextSize = Core.Config._Renderer.MessureText(_Text);
            var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
            Core.Config._Renderer.DrawText(_TextPos, _Text, System.Drawing.Color.White);
        }
    }
}
