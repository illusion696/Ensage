using Ensage;
using Ensage.SDK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RubickRage.Core.Logics
{
    public static class ParticleRemover
    {
        private static readonly Dictionary<String, Boolean> ChangedDrawings = new Dictionary<String, Boolean>()
        {
           // {"LandBombRange", Config._Menu.Drawings.BombsDrawings.LandBombRange},
        };

        private static readonly Dictionary<String, Boolean> ChangedDrawingsVals = new Dictionary<String, Boolean>()
        {
           // {"LandBombRange", Config._Menu.Drawings.BombsDrawings.LandBombRange},
        };

        public static void OnUpdate()
        {
            //if (ChangedDrawingsVals["FroceRange"] != Config._Menu.Drawings.ForceDrawings.FroceRange)
            //{
            //    ChangedDrawingsVals["FroceRange"] = Config._Menu.Drawings.ForceDrawings.FroceRange;
            //    ChangedDrawings["FroceRange"] = true;
            //}
        }
    }
}
