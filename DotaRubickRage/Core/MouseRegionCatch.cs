using Ensage.SDK.Input;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class MouseRegionCatch
    {
        public static void Input_MouseClick(object sender, MouseEventArgs e)
        {
            //Log.Warn(e.Key);
            if (e.Buttons == MouseButtons.RightDown)
            {
                Core.Config.DoStack = false;
                Core.Config.Status = 0;
            }

            var _Menu = Core.Config._Menu;

            if (e.Buttons == MouseButtons.LeftUp && _Menu.Drawings.DrawingsLotusCombo)
            {
                var _Pad = _Menu.Drawings.LotusPanelY.Value + 7;
                foreach (var _SC in _Menu.LotusCombo.LotusSpellConfigs)
                {
                    if (IsInRegion(new RectangleF(_Menu.Drawings.LotusPanelX.Value + 78, _Pad, 25, 25), e.Position))
                    {
                        _SC.Value.Steal = !_SC.Value.Steal;
                        //Core.Config.Log.Warn("Changed!");
                    }
                    if (IsInRegion(new RectangleF(_Menu.Drawings.LotusPanelX.Value + 140, _Pad, 25, 25), e.Position))
                    {
                        _SC.Value.ForceUse = !_SC.Value.ForceUse;
                        //Core.Config.Log.Warn("Changed!");
                    }
                    //if (IsInRegion(new RectangleF(_Menu.Drawings.LotusPanelX.Value + 265, _Pad, 25, 25), e.Position))
                    //{
                    //    _SC.Value.AnotherTarger = !_SC.Value.AnotherTarger;
                    //    //Core.Config.Log.Warn("Changed!");
                    //}
                    _Pad += 35;
                }
            }
        }
    


        public static Boolean IsInRegion(RectangleF _Rect, Vector2 _Pos)
        {
            //Core.Config.Log.Warn($"{_Pos.X} {_Pos.Y} : {_Rect.X} {_Rect.Y} {_Rect.Right} {_Rect.Bottom}");
            if (_Pos.X >= _Rect.X && 
                _Pos.X <= _Rect.Right && 
                _Pos.Y >= _Rect.Y && 
                _Pos.Y <= _Rect.Bottom)
            {
                return true;
            }
            return false;
        }
    }
}
