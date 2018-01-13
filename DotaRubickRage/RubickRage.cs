using System;
using System.ComponentModel.Composition;
using Ensage;
using Ensage.SDK.Service;
using Ensage.SDK.Service.Metadata;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Input;
using Ensage.SDK.Handlers;
using RubickRage.Core;

namespace RubickRage
{
    [ExportPlugin("Rubic Rage", StartupMode.Auto, "SirLimon", "1.0.0.0", "Rubic smart assembly", 500, HeroId.npc_dota_hero_rubick)]
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
            _Input = _Context.Input;
            Core.Config._TargetSelector = _Context.TargetSelector;

            Core.Config._QSpell = _Context.AbilityFactory.GetAbility<Ensage.SDK.Abilities.npc_dota_hero_rubick.rubick_telekinesis>();
            Core.Config._WSpell = _Context.AbilityFactory.GetAbility<Ensage.SDK.Abilities.npc_dota_hero_rubick.rubick_fade_bolt>();
        }

        protected override void OnActivate()
        {
            try
            {
                Core.Config._Menu = new Menu();
                _Context.MenuManager.RegisterMenu(Core.Config._Menu);

                _Input.KeyDown += Input_KeyDown;
                _Input.MouseClick += MouseRegionCatch.Input_MouseClick;

                Init.Prepare();

                Core.Config._Renderer.Draw += Drawings.Info.OnDraw;
                Core.Config._Renderer.Draw += Drawings.SpellConfigPanel.OnDraw;

                UpdateManager.Subscribe(MainLogic.OnUpdate, 100);
                UpdateManager.Subscribe(LinkenSaveLogic.OnUpdate, 25);
                UpdateManager.Subscribe(GlimmerSaveLogic.OnUpdate, 25);
                Core.Config._ComboTask = new TaskHandler(LotusLogic.OnUpdateTask, true);
                Core.Config._ComboMainTask = new TaskHandler(ComboLogic.Combo, true);

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

        protected override void OnDeactivate()
        {
            _MenuManager.Value.DeregisterMenu(Core.Config._Menu);
            _Input.KeyDown -= Input_KeyDown;
            _Input.MouseClick -= MouseRegionCatch.Input_MouseClick;
            Core.Config._Renderer.Draw -= Drawings.Info.OnDraw;
            UpdateManager.Unsubscribe(MainLogic.OnUpdate);
            UpdateManager.Unsubscribe(LinkenSaveLogic.OnUpdate);
            UpdateManager.Unsubscribe(GlimmerSaveLogic.OnUpdate);
        }

    }
}