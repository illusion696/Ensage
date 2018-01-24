using Ensage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core.Helpers
{
    public static class DagonManager
    {
        public static Item GetDagon()
        {
            if (Core.Config._Items.Dagon1 != null)
            {
                return Core.Config._Items.Dagon1;
            }
            else if (Core.Config._Items.Dagon2 != null)
            {
                return Core.Config._Items.Dagon2;
            }
            else if (Core.Config._Items.Dagon3 != null)
            {
                return Core.Config._Items.Dagon3;
            }
            else if (Core.Config._Items.Dagon4 != null)
            {
                return Core.Config._Items.Dagon4;
            }
            else if (Core.Config._Items.Dagon5 != null)
            {
                return Core.Config._Items.Dagon5;
            }

            return null;
        }
    }
}
