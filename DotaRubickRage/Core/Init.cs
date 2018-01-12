using Ensage;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubickRage.Core
{
    public static class Init
    {
        public static void Prepare()
        {
            PrepareCamps();
        }

        private static void PrepareCamps()
        {
            if (Config._Hero.Team == Team.Radiant)
            {
                Core.Config.GetCamps.Add(
                    new Models.Camp
                    {
                        TablePos = new Vector3(5152, -4384, 256),
                        CampPos = new Vector3(4502, -4319, 256),
                        StackPos = new Vector3(3045, -3596, 269),
                        PreparePos = new Vector3(4567, -3900, 256),
                        RunPos = new Vector3(5623, -3482, 384),
                        PullPus = new Vector3(4447, -4124, 256),
                        Id = 4,
                        PullTime = 54,
                        BendPullTime = (float)34.5,
                        BendPullTime2 = -1,
                        MiliSubTime = (float)0.5
                    });
                Core.Config.GetCamps.Add(
                    new Models.Camp
                    {
                        TablePos = new Vector3(3168, -4320, 256),
                        CampPos = new Vector3(3030, -4555, 256),
                        StackPos = new Vector3(4499, -5096, 384),
                        PreparePos = new Vector3(3432, -4656, 256),
                        PullPus = new Vector3(3070, -4610, 256),
                        RunPos = new Vector3(3447, -5884, 384),
                        Id = 5,
                        PullTime = 54,
                        BendPullTime = 21,
                        BendPullTime2 = 51,
                        MiliSubTime = (float)0.5
                    });

                Core.Config.GetCamps.Add(
                    new Models.Camp
                    {
                        TablePos = new Vector3(-4100, 3300, 256),
                        CampPos = new Vector3(-4331, 3706, 256),
                        StackPos = new Vector3(-2894, 3515, 256),
                        PreparePos = new Vector3(-4420, 3893, 256),
                        PullPus = new Vector3(-4361, 3614, 256),
                        RunPos = new Vector3(-5800, 3564, 384),
                        Id = 14,
                        PullTime = 55,
                        BendPullTime = 23,
                        BendPullTime2 = 53,
                        MiliSubTime = (float)0.5,
                    });
            }
            else
            {
                Core.Config.GetCamps.Add(
                    new Models.Camp
                    {
                        TablePos = new Vector3(-2498, 4921, 259),
                        CampPos = new Vector3(-2768, 4578, 256),
                        StackPos = new Vector3(-1923, 6042, 384),
                        PreparePos = new Vector3(-3215, 4534, 256),
                        PullPus = new Vector3(-2803, 4646, 256),
                        RunPos = new Vector3(-3310, 5788, 384),
                        Id = 13,
                        PullTime = 53,
                        BendPullTime = (float)18.5,
                        BendPullTime2 = 49,
                        MiliSubTime = (float)0.5
                    });
                Core.Config.GetCamps.Add(
                    new Models.Camp
                    {
                        TablePos = new Vector3(-4100, 3300, 256),
                        CampPos = new Vector3(-4331, 3706, 256),
                        StackPos = new Vector3(-2894, 3515, 256),
                        PreparePos = new Vector3(-4420, 3893, 256),
                        PullPus = new Vector3(-4361, 3614, 256),
                        RunPos = new Vector3(-5757, 3686, 384),
                        Id = 14,
                        PullTime = 55,
                        BendPullTime = 33,
                        BendPullTime2 = 2,
                        MiliSubTime = (float)0.5
                    });
                Core.Config.GetCamps.Add(
                   new Models.Camp
                   {
                       TablePos = new Vector3(5152, -4384, 256),
                       CampPos = new Vector3(4502, -4319, 256),
                       StackPos = new Vector3(3045, -3596, 269),
                       PreparePos = new Vector3(4567, -3900, 256),
                       RunPos = new Vector3(5623, -3482, 384),
                       PullPus = new Vector3(4447, -4124, 256),
                       Id = 4,
                       PullTime = 54,
                       BendPullTime = 23,
                       BendPullTime2 = 53,
                       MiliSubTime = (float)0.5
                   });
            }
        }
    }
}