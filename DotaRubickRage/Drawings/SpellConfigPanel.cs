using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Drawings
{
    public static class SpellConfigPanel
    {
        public static void OnDraw(object sender, EventArgs eventArgs)
        {
            var _Menu = Core.Config._Menu;
            if (_Menu.Drawings.DrawingsLotusCombo)
            {
                var _Renderer = Core.Config._Renderer;
                var _PanelHeight = _Menu.LotusCombo.LotusSpellConfigs.Count * 35 + 35;
                var _PanelPosition = _Menu.Drawings.LotusPanelPosition.Value;

                _Renderer.DrawFilledRectangle(new SharpDX.RectangleF(_PanelPosition.X, _PanelPosition.Y, 300, _PanelHeight),
                     System.Drawing.Color.FromArgb(187, 187, 187, 187), System.Drawing.Color.FromArgb(100, 80, 80, 80), 2);

                _Renderer.DrawLine(new SharpDX.Vector2(_PanelPosition.X, _PanelPosition.Y + 30), new SharpDX.Vector2(_PanelPosition.X + 300, _PanelPosition.Y + 30), System.Drawing.Color.FromArgb(187, 187, 187, 187), 2);
                var _HPos = _Renderer.MessureText("Lotus Panel (Drag by Header)");
                _Renderer.DrawText(new SharpDX.Vector2(_PanelPosition.X + (300 - _HPos.X) / 2, _PanelPosition.Y + 5), "Lotus Panel (Drag by Header)", Color.White);

                int _Pad = 30;
                foreach (var _SC in _Menu.LotusCombo.LotusSpellConfigs)
                {
                    _Renderer.DrawTexture(_SC.Key, new SharpDX.RectangleF(_PanelPosition.X + 5, _PanelPosition.Y + 5 + _Pad, 30, 30));
                    _Renderer.DrawText(new SharpDX.Vector2(_PanelPosition.X + 40, _PanelPosition.Y + 9 + _Pad), "Steal", System.Drawing.Color.White);
                    _Renderer.DrawFilledRectangle(new SharpDX.RectangleF(_PanelPosition.X + 78, _PanelPosition.Y + 7 + _Pad, 25, 25),
                        System.Drawing.Color.FromArgb(187, 187, 187, 187),
                       _SC.Value.Steal ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));
                    _Renderer.DrawText(new SharpDX.Vector2(_PanelPosition.X + 106, _PanelPosition.Y + 9 + _Pad), "Use", System.Drawing.Color.White);
                    _Renderer.DrawFilledRectangle(new SharpDX.RectangleF(_PanelPosition.X + 140, _PanelPosition.Y + 7 + _Pad, 25, 25),
                        System.Drawing.Color.FromArgb(187, 187, 187, 187),
                       _SC.Value.ForceUse ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));
                    _Renderer.DrawText(new SharpDX.Vector2(_PanelPosition.X + 167, _PanelPosition.Y + 9 + _Pad), "Another target", System.Drawing.Color.White);
                    _Renderer.DrawFilledRectangle(new SharpDX.RectangleF(_PanelPosition.X + 265, _PanelPosition.Y + 7 + _Pad, 25, 25),
                      System.Drawing.Color.FromArgb(187, 187, 187, 187),
                      _SC.Value.AnotherTarger ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));

                    _Pad += 35;
                }
            }
        }
    }
}
