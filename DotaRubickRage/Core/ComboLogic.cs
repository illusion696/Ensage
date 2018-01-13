using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ensage.SDK.Extensions;
using Ensage.SDK.Helpers;

namespace RubickRage.Core
{
    public static class ComboLogic
    {
        public static async Task Combo(CancellationToken cancellationToken)
        {
            try
            {
                if (Config._Hero.IsAlive == false)
                {
                    return;
                }

                var _Target = Config._TargetSelector.Active.GetTargets().FirstOrDefault(x => x.Distance2D(Config._Hero) < 1000);
                if (_Target == null)
                {
                    return;
                }

                var _Combo = new Combo(Config._QSpell, Config._WSpell);
                if (!_Combo.IsInRange(_Target))
                {
                    return;
                }

                //if (combo.GetDamage(target) > target.Health)
                //{
                //    Log.Warn("Target should die");
                //}

                await _Combo.Execute(_Target, cancellationToken);
            }
            catch (TaskCanceledException)
            {
            }
            catch
            {
                // ignored
            }
        }
    }
}
