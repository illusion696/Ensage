using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensage.SDK.Abilities.Items;
using Ensage.SDK.Inventory.Metadata;

namespace RubickRage.Core
{
    public class ItemBindings
    {
        [ItemBinding]
        public item_glimmer_cape Glimmer { get; set; }
        [ItemBinding]
        public item_lotus_orb Lotus { get; set; }
        [ItemBinding]
        public item_sphere Linken { get; set; }
        [ItemBinding]
        public item_blink Blink { get; set; }
    }
}
