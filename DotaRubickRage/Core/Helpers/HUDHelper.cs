using Ensage;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensage.Common;

namespace RubickRage.Core.Helpers
{
    public static class HUDHelper
    {
        private static Dictionary<ClassId, Vector2> _Poses = new Dictionary<ClassId, Vector2>();

        public static Vector2 GetHPbarPosition(Unit _Unit)
        {
            if (_Poses.ContainsKey(_Unit.ClassId))
            {
                return Drawing.WorldToScreen(_Unit.Position) + _Poses[_Unit.ClassId];
            }
            else
            {
                var _Pos = HUDInfo.GetHPbarPosition(_Unit);
                _Pos = _Pos - Drawing.WorldToScreen(_Unit.Position);
                _Poses.Add(_Unit.ClassId, _Pos);
                return _Pos;
            }
        }

        private static Dictionary<ClassId, Vector2> _TopPanelPoses = new Dictionary<ClassId, Vector2>();
        public static Vector2 GetTopPanelPosition(Hero _Unit)
        {
            if (_TopPanelPoses.ContainsKey(_Unit.ClassId))
            {
                return _TopPanelPoses[_Unit.ClassId];
            }
            else
            {
                var _Pos = HUDInfo.GetTopPanelPosition(_Unit) + new Vector2(0, (float)HUDInfo.GetTopPanelSizeX(_Unit));
                _TopPanelPoses.Add(_Unit.ClassId, _Pos);
                return _Pos;
            }
        }

        public static float LandBombWidth = HUDInfo.GetHPBarSizeX();
    }
}
