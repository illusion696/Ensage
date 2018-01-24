using System;
using SharpDX;

namespace RubickRage.Drawings
{
    public static class Hello
    {
        public static void OnDraw(object sender, EventArgs eventArgs)
        {
            if (Core.Config._Hello)
            {
                String _Text = "Please read docs for Rubick Rage at http://RageScript.pro";
                var _Pos2 = Core.Helpers.HUDHelper.GetHPbarPosition(Core.Config._Hero);
                var _TextSize = Core.Config._Renderer.MessureText(_Text, 16);
                var _TextPos = _Pos2 - new Vector2(_TextSize.X / 2 - 50, 80);
                Core.Config._Renderer.DrawText(_TextPos, _Text, System.Drawing.Color.White, 16);
            }
        }
    }
}
