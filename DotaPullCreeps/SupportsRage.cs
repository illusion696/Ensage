using System;
using System.ComponentModel.Composition;
using Ensage;
using Ensage.SDK.Helpers;
using Ensage.SDK.Input;
using Ensage.SDK.Inventory;
using Ensage.SDK.Menu;
using Ensage.SDK.Service;
using Ensage.SDK.Service.Metadata;
using SupportsRage.Core;
using SupportsRage.Drawings;
using Config = SupportsRage.Core.Config;

namespace SupportsRage
{
    [ExportPlugin("Supports Rage", StartupMode.Auto, "SirLimon", "1.0.4.0", "AIO utility for Supports")]
    internal class SupportsRage : Plugin
    {
        private readonly Lazy<MenuManager> _MenuManager;
        private readonly IServiceContext _Context;
        private readonly IInputManager _Input;
        private readonly IInventoryManager _InventoryManager;

        [ImportingConstructor]
        public SupportsRage([Import] IServiceContext _Context, [Import] Lazy<MenuManager> _MenuManager)
        {
            Config._Hero = (Hero)_Context.Owner;
            this._MenuManager = _MenuManager;
            this._Context = _Context;
            Config._Renderer = _Context.Renderer;
            _Input = _Context.Input;
            _InventoryManager = _Context.Inventory;
        }

        protected override void OnActivate()
        {
            try
            {
                 Config._Menu = new Menu();
                _Context.MenuManager.RegisterMenu(Config._Menu);
                _Input.KeyDown += Input_KeyDown;
                _Input.MouseClick += Input_MouseClick;

                Init.Prepare();

                Config._Renderer.Draw += Info.OnDraw;

                UpdateManager.Subscribe(MainLogic.OnUpdate, 100);
                UpdateManager.Subscribe(LinkenSaveLogic.OnUpdate, 25);
                UpdateManager.Subscribe(GlimmerSaveLogic.OnUpdate, 25);
                UpdateManager.Subscribe(LotusSaveLogic.OnUpdate, 25);
                UpdateManager.Subscribe(GlimmerCUltLogic.OnUpdate, 25);

                _InventoryManager.Attach(Config._Items);

                Config.Log.Warn("Load completed");
            }
            catch (Exception ex)
            {
                Config.Log.Error(ex.ToString());
            }

            //this.inventoryManager.Attach(this);
            //this.comboTask = new TaskHandler(this.Combo, true);
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            //Log.Warn(e.Key);
            //if (e.Key == )
            //{
            //    Core.Config.DoStack = true;
            //    Core.Config.Status = 0;
            //}
        }
        private void Input_MouseClick(object sender, MouseEventArgs e)
        {
            //Log.Warn(e.Key);
            if (e.Buttons ==  MouseButtons.RightDown)
            {
                Config.DoStack = false;
                Config.Status = 0;
            }
        }

        protected override void OnDeactivate()
        {
            _MenuManager.Value.DeregisterMenu(Config._Menu);
            _Input.KeyDown -= Input_KeyDown;
            _Input.MouseClick -= Input_MouseClick;
            Config._Renderer.Draw -= Info.OnDraw;
            UpdateManager.Unsubscribe(MainLogic.OnUpdate);
            UpdateManager.Unsubscribe(LinkenSaveLogic.OnUpdate);
            UpdateManager.Unsubscribe(GlimmerSaveLogic.OnUpdate);
            UpdateManager.Unsubscribe(LotusSaveLogic.OnUpdate);
            UpdateManager.Unsubscribe(GlimmerCUltLogic.OnUpdate);
            _InventoryManager.Detach(Core.Config._Items);
        }
        
    }
}