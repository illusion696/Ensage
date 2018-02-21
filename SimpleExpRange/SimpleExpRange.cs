using System;
using System.ComponentModel.Composition;
using Ensage;
using Ensage.SDK.Service;
using Ensage.SDK.Service.Metadata;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Input;
using Ensage.SDK.Inventory;
using SimpleExpRange.Core.Menus;

namespace SimpleExpRange
{
    [ExportPlugin("Simple Exp Range", StartupMode.Auto, "SirLimon", "1.0.0.0", "Display Exp range", 500)]
    internal class SimpleExpRange : Plugin
    {
        private readonly Lazy<MenuManager> _MenuManager;
        private readonly IServiceContext _Context;
        private readonly IInputManager _Input;
        private readonly IInventoryManager _InventoryManager;

        [ImportingConstructor]
        public SimpleExpRange([Import] IServiceContext _Context, [Import] Lazy<MenuManager> _MenuManager)
        {
            Core.Config._Hero = (Hero)_Context.Owner;
            this._MenuManager = _MenuManager;
            this._Context = _Context;
            Core.Config._ParticleManager = _Context.Particle;
        }

        protected override void OnActivate()
        {
            try
            {
                Core.Config._Menu = new Menu();
                _Context.MenuManager.RegisterMenu(Core.Config._Menu);
                
                UpdateManager.Subscribe(Drawings.ExpRange.OnUpdate, 100);
            }
            catch (Exception ex)
            {
                Core.Config.Log.Error(ex.ToString());
            }
        }

        protected override void OnDeactivate()
        {
            _MenuManager.Value.DeregisterMenu(Core.Config._Menu);
           
            UpdateManager.Unsubscribe(Drawings.ExpRange.OnUpdate);
        }
    }
}