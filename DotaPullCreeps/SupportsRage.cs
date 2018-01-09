using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using Ensage;
using Ensage.Common;
using Ensage.Common.Extensions;
using SharpDX;
using Ensage.SDK.Service;
using Ensage.SDK.Service.Metadata;
using NLog;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Renderer;
using Ensage.SDK.Menu.ValueBinding;
using Ensage.SDK.Menu.Items;
using Ensage.SDK.Input;

namespace SupportsRage
{
    [ExportPlugin("Supports Rage", StartupMode.Auto, "SirLimon", "1.0.0.0", "AIO utility for Supports")]
    internal class SupportsRage : Plugin
    {
        private readonly Lazy<MenuManager> _MenuManager;
        private readonly IServiceContext _Context;
        private readonly IInputManager _Input;

        [ImportingConstructor]
        public SupportsRage([Import] IServiceContext _Context, [Import] Lazy<MenuManager> _MenuManager)
        {
            Core.Config._Hero = (Hero)_Context.Owner;
            this._MenuManager = _MenuManager;
            this._Context = _Context;
            Core.Config._Renderer = _Context.Renderer;
            this._Input = _Context.Input;
        }

        protected override void OnActivate()
        {
            try
            {
                 Core.Config._Menu = new Core.Menu(Core.Config.Log);
                _Context.MenuManager.RegisterMenu(Core.Config._Menu);
                _Input.KeyDown += Input_KeyDown;
                _Input.MouseClick += Input_MouseClick;

                Core.Init.Prepare();

                Core.Config._Renderer.Draw += Drawings.Info.OnDraw;

                UpdateManager.Subscribe(Core.MainLogic.OnUpdate, 100);
                UpdateManager.Subscribe(Core.LinkenSaveLogic.OnUpdate, 25);

                Core.Config.Log.Warn("Load completed");
            }
            catch (Exception ex)
            {
                Core.Config.Log.Error(ex.ToString());
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
                Core.Config.DoStack = false;
                Core.Config.Status = 0;
            }
        }

        protected override void OnDeactivate()
        {
            this._MenuManager.Value.DeregisterMenu(Core.Config._Menu);
            _Input.KeyDown -= Input_KeyDown;
            _Input.MouseClick -= Input_MouseClick;
            Core.Config._Renderer.Draw -= Drawings.Info.OnDraw;
            UpdateManager.Unsubscribe(Core.MainLogic.OnUpdate);
            UpdateManager.Unsubscribe(Core.LinkenSaveLogic.OnUpdate);
        }
        
    }
}