using Ensage;
using Ensage.Common;
using Ensage.SDK.Extensions;
using Ensage.SDK.Helpers;
using SharpDX;
using System;
using System.Linq;
using Color = System.Drawing.Color;

namespace RubickRage.Drawings
{
    public static class Info
    {
        public static void OnDraw(object sender, EventArgs eventArgs)
        {
            if (Core.Logics.MainLogic.DoStack)
            {
                if (Core.Config._Menu.Drawings.DrawingsOnTop)
                {
                    var _Temp = HUDInfo.GetTopPanelPosition(Core.Config._Hero) + new Vector2(0, 60);
                    Core.Config._Renderer.DrawRectangle(new RectangleF(_Temp.X, _Temp.Y, (float)HUDInfo.GetTopPanelSizeX(Core.Config._Hero), (float)HUDInfo.GetTopPanelSizeY(Core.Config._Hero)), System.Drawing.Color.Green, 2);
                }

                if (Core.Config._Menu.Drawings.DrawingsOnHero)
                {
                    String _Text = "Pulling...";
                    var _Pos = HUDInfo.GetHPbarPosition(Core.Config._Hero);
                    var _Size = new Vector2((float)HUDInfo.GetHPBarSizeX(Core.Config._Hero), (float)HUDInfo.GetHpBarSizeY(Core.Config._Hero));
                    var _TextSize = Core.Config._Renderer.MessureText(_Text);
                    var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
                    Core.Config._Renderer.DrawText(_TextPos, _Text, System.Drawing.Color.White);
                }
            }
        }
    }
}
