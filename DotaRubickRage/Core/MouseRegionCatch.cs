using Ensage.SDK.Input;
using Ensage.SDK.Extensions;
using System;
using SharpDX;
using System.Linq;

namespace RubickRage.Core
{
    public static class MouseRegionCatch
    {
        private static bool _Drag;
        private static bool _CanDrag;
        private static Vector2 _DiffPos;

        private static bool _Drag2;
        private static bool _CanDrag2;
        private static Vector2 _DiffPos2;


        public static void Input_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Buttons == MouseButtons.LeftUp)
            {
                if (e.Buttons == MouseButtons.LeftUp && Core.Config._Menu.Drawings.DrawingsLotusCombo)
                {
                    var _LotusPanelPosition = Core.Config._Menu.Drawings.LotusPanelPosition.Value;
                    var _Pad = _LotusPanelPosition.Y + 37;
                    foreach (var _SC in Core.Config._Menu.LotusCombo.LotusSpellConfigs)
                    {
                        if (e.Position.IsUnderRectangle(_LotusPanelPosition.X + 78, _Pad, 25, 25))
                        {
                            _SC.Value.Steal = !_SC.Value.Steal;
                            break;
                        }

                        if (e.Position.IsUnderRectangle(_LotusPanelPosition.X + 140, _Pad, 25, 25))
                        {
                            _SC.Value.ForceUse = !_SC.Value.ForceUse;
                            break;
                        }
                        //if (IsInRegion(new RectangleF(_Menu.Drawings.LotusPanelX.Value + 265, _Pad, 25, 25), e.Position))
                        //{
                        //    _SC.Value.AnotherTarger = !_SC.Value.AnotherTarger;
                        //    //Core.Config.Log.Warn("Changed!");
                        //}
                        _Pad += 35;
                    }

                    var _StealPanelPosition = Core.Config._Menu.Drawings.StealPanelPosition.Value;
                    var _Pad2 = _StealPanelPosition.Y + 37;
                    foreach (var _SC in Core.Config._Menu.Steal.SpellConfigs)
                    {
                        if (e.Position.IsUnderRectangle(_StealPanelPosition.X + 78, _Pad2, 25, 25))
                        {
                            Core.Config._Menu.Steal.SpellConfigs[_SC.Key] = !Core.Config._Menu.Steal.SpellConfigs[_SC.Key];
                            break;
                        }

                        _Pad2 += 35;
                    }
                }
            }

            if (_CanDrag && e.Buttons == MouseButtons.LeftDown)
            {
                _DiffPos = e.Position - Config._Menu.Drawings.LotusPanelPosition.Value;
                _Drag = true;
            }
            else
            {
                _Drag = false;
            }

            if (_CanDrag2 && e.Buttons == MouseButtons.LeftDown)
            {
                _DiffPos2 = e.Position - Config._Menu.Drawings.StealPanelPosition.Value;
                _Drag2 = true;
            }
            else
            {
                _Drag2 = false;
            }
        }

        public static void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_Drag)
            {
                var _Pos = e.Position - _DiffPos;
                _Pos.X = Math.Max(Config._Menu.Drawings.LotusPanelPosition.MinValue.X, Math.Min(Config._Menu.Drawings.LotusPanelPosition.MaxValue.X, _Pos.X));
                _Pos.Y = Math.Max(Config._Menu.Drawings.LotusPanelPosition.MinValue.Y, Math.Min(Config._Menu.Drawings.LotusPanelPosition.MaxValue.Y, _Pos.Y));
                Config._Menu.Drawings.LotusPanelPosition.Value = _Pos;
            }

            var _DragZone = new RectangleF(Config._Menu.Drawings.LotusPanelPosition.Value.X, Config._Menu.Drawings.LotusPanelPosition.Value.Y, 300, 20);
            _CanDrag = _DragZone.Contains(e.Position);

            if (_Drag2)
            {
                var _Pos = e.Position - _DiffPos2;
                _Pos.X = Math.Max(Config._Menu.Drawings.StealPanelPosition.MinValue.X, Math.Min(Config._Menu.Drawings.StealPanelPosition.MaxValue.X, _Pos.X));
                _Pos.Y = Math.Max(Config._Menu.Drawings.StealPanelPosition.MinValue.Y, Math.Min(Config._Menu.Drawings.StealPanelPosition.MaxValue.Y, _Pos.Y));
                Config._Menu.Drawings.StealPanelPosition.Value = _Pos;
            }

            var _DragZone2 = new RectangleF(Config._Menu.Drawings.StealPanelPosition.Value.X, Config._Menu.Drawings.StealPanelPosition.Value.Y, 150, 20);
            _CanDrag2 = _DragZone2.Contains(e.Position);
        }
    }
}
