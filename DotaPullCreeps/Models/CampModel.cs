using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportsRage.Models
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

        public float BendPullTime { get; set; }
        public float BendPullTime2 { get; set; }
        public float MiliSubTime { get; set; }
    }
}
