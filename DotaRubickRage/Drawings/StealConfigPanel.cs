using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Drawings
{
    public static class StealConfigPanel
    {
        public static void OnDraw(object sender, EventArgs eventArgs)
        {
            var _Menu = Core.Config._Menu;
            if (_Menu.Drawings.DrawingsStealPanel)
            {
                var _Renderer = Core.Config._Renderer;
                var _PanelHeight = _Menu.Steal.SpellConfigs.Count * 35 + 35;
                var _PanelPosition = _Menu.Drawings.StealPanelPosition.Value;

                _Renderer.DrawFilledRectangle(new SharpDX.RectangleF(_PanelPosition.X, _PanelPosition.Y, 150, _PanelHeight),
                     System.Drawing.Color.FromArgb(187, 187, 187, 187), System.Drawing.Color.FromArgb(100, 80, 80, 80), 2);

                _Renderer.DrawLine(new SharpDX.Vector2(_PanelPosition.X, _PanelPosition.Y + 30), new SharpDX.Vector2(_PanelPosition.X + 150, _PanelPosition.Y + 30), System.Drawing.Color.FromArgb(187, 187, 187, 187), 2);
                var _HPos = _Renderer.MessureText("Steal Panel (Drag by Header)");
                _Renderer.DrawText(new SharpDX.Vector2(_PanelPosition.X + (150 - _HPos.X) / 2, _PanelPosition.Y + 5), "Steal Panel (Drag by Header)", Color.White);

                int _Pad = 30;
                foreach (var _SC in _Menu.Steal.SpellConfigs)
                {
                    _Renderer.DrawTexture(_SC.Key, new SharpDX.RectangleF(_PanelPosition.X + 5, _PanelPosition.Y + 5 + _Pad, 30, 30));
                    _Renderer.DrawText(new SharpDX.Vector2(_PanelPosition.X + 40, _PanelPosition.Y + 9 + _Pad), "Steal", System.Drawing.Color.White);
                    _Renderer.DrawFilledRectangle(new SharpDX.RectangleF(_PanelPosition.X + 78, _PanelPosition.Y + 7 + _Pad, 25, 25),
                        System.Drawing.Color.FromArgb(187, 187, 187, 187),
                       _SC.Value ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));
                    
                    _Pad += 35;
                }
            }
        }
    }
}
