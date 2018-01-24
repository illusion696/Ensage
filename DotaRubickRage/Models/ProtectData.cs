using Ensage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Models
{
    public class ProtectData
    {
        public AbilityId Id { get; set; }
        public Boolean ForceUse { get; set; }
        public Boolean AnotherTarget { get; set; }
        public int DangerLevel { get; set; }
    }
}
