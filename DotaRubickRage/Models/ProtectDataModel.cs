using Ensage;
using System;

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
