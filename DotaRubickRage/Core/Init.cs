using System.Linq;
using System.Reflection;
using Ensage;
using Ensage.SDK.Helpers;
using SharpDX;

namespace RubickRage.Core
{
    public static class Init
    {
        public static void Prepare()
        {
            Config._Assembly = Assembly.GetExecutingAssembly();
            Config._Renderer.TextureManager.LoadFromResource("ArrowLeft", "Images.ArrowLeft.png", Config._Assembly);
            Config._Renderer.TextureManager.LoadFromResource("ArrowRight", "Images.ArrowRight.png", Config._Assembly);
            
            Config._Renderer.TextureManager.LoadFromDota("manta", "resource\\flash3\\images\\items\\manta.png");
            Config._Renderer.TextureManager.LoadFromDota("necronomicon", "resource\\flash3\\images\\items\\necronomicon.png");
            Config._Renderer.TextureManager.LoadFromDota("furion_treant", "resource\\flash3\\images\\spellicons\\furion_force_of_nature.png");
            Config._Renderer.TextureManager.LoadFromDota("techies_focused_detonate", "resource\\flash3\\images\\spellicons\\techies_focused_detonate.png");
            Config._Renderer.TextureManager.LoadFromDota("enigma_demonic_conversion", "resource\\flash3\\images\\spellicons\\enigma_demonic_conversion.png");
            Config._Renderer.TextureManager.LoadFromDota("KillHimself", "resource\\flash3\\images\\spellicons\\techies_suicide.png");
            
            Config._Renderer.TextureManager.LoadFromResource("Run", "Images.Run.png", Config._Assembly);
            Config._Renderer.TextureManager.LoadFromResource("RunRed", "Images.RunRed.png", Config._Assembly);


            Config._Renderer.TextureManager.LoadFromResource("RubR_Logo", "Images.IngameLogo.png", Config._Assembly);
            PrepareCamps();
        }

        private static void PrepareCamps()
        {
            if (Config._Hero.Team == Team.Radiant)
            {
                Config.GetCamps.Add(
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
                Config.GetCamps.Add(
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

                Config.GetCamps.Add(
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
                Config.GetCamps.Add(
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
                Config.GetCamps.Add(
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
                Config.GetCamps.Add(
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