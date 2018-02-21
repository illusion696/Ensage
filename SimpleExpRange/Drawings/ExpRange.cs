
using SharpDX;
using Ensage;
using Ensage.SDK.Renderer.Particle;

namespace SimpleExpRange.Drawings
{
    public static class ExpRange
    {
        public static void OnUpdate()
        {
            if (Core.Config._Menu.ExpRange)
            {
                Core.Config._ParticleManager.DrawRange(Core.Config._Hero, "SimpleExpRange", 1500, Color.Blue);
            }
            else
            {
                if (Core.Config._ParticleManager.HasParticle("SimpleExpRange"))
                {
                    Core.Config._ParticleManager.Remove("SimpleExpRange");
                }
            }
        }
    }
}
