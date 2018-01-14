using Ensage.SDK.Abilities.Items;
using Ensage.SDK.Inventory.Metadata;

namespace SupportsRage.Core
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
