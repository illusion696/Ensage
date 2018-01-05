using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesRage.Models
{
    public class Camp
    {
        public int Id { get; set; }
        public Vector3 TablePos { get; set; }
        public Vector3 CampPos { get; set; }
        public Vector3 StackPos { get; set; }
        public Vector3 PreparePos { get; set; }
        public Vector3 PullPus { get; set; }
        public Vector3 RunPos { get; set; }
        public int PullTime { get; set; }
    }
}
