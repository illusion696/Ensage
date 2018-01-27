using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Ensage;
using Ensage.Common.Extensions;
using Ensage.SDK.Handlers;
using Ensage.SDK.Service;
using Ensage.SDK.Service.Metadata;
using Ensage.SDK.Helpers;
using Ensage.SDK.Menu;
using Ensage.SDK.Input;
using Ensage.SDK.Inventory;
using RubickRage.Core;
using RubickRage.Core.Menus;

namespace RubickRage
{
    [ExportPlugin("Rubick Rage", StartupMode.Auto, "SirLimon", "1.2.1.0", "Rubick smart assembly", 500, HeroId.npc_dota_hero_rubick)]
    internal class RubickRage : Plugin
    {
        private readonly Lazy<MenuManager> _MenuManager;
        private readonly IServiceContext _Context;
        private readonly IInputManager _Input;
        private readonly IInventoryManager _InventoryManager;

        [ImportingConstructor]
        public RubickRage([Import] IServiceContext _Context, [Import] Lazy<MenuManager> _MenuManager)
        {
            Core.Config._Hero = (Hero)_Context.Owner;
            this._MenuManager = _MenuManager;
            this._Context = _Context;
            Core.Config._Renderer = _Context.Renderer;
            Core.Config._ParticleManager = _Context.Particle;
            _Input = _Context.Input;
            Core.Config._TargetSelector = _Context.TargetSelector;
            _InventoryManager = _Context.Inventory;

            Core.Config._QSpell = _Context.AbilityFactory.GetAbility<Ensage.SDK.Abilities.npc_dota_hero_rubick.rubick_telekinesis>();
            Core.Config._WSpell = _Context.AbilityFactory.GetAbility<Ensage.SDK.Abilities.npc_dota_hero_rubick.rubick_fade_bolt>();
            Core.Config._ESpell = Core.Config._Hero.Spellbook.SpellE;
            Core.Config._RSpell = Core.Config._Hero.Spellbook.SpellR;
        }

        protected override void OnActivate()
        {
            try
            {
                Init.Prepare();
                Core.Config._Menu = new Menu();
                _Context.MenuManager.RegisterMenu(Core.Config._Menu);
                
                _Input.MouseClick += MouseRegionCatch.Input_MouseClick;
                _Input.MouseMove += MouseRegionCatch.OnMouseMove;

                Core.Config._Renderer.Draw += Drawings.Info.OnDraw;
                Core.Config._Renderer.Draw += Drawings.SpellConfigPanel.OnDraw;
                Core.Config._Renderer.Draw += Drawings.StealConfigPanel.OnDraw;

                UpdateManager.Subscribe(LinkenSaveLogic.OnUpdate, 25);
                UpdateManager.Subscribe(GlimmerSaveLogic.OnUpdate, 25);
                Core.Config._LotusComboTask = new TaskHandler(Core.Logics.LotusLogic.OnUpdateTask, true);
                Core.Config._MainComboTask = new TaskHandler(ComboLogic.Combo, true);
                Core.Config._StealTask = new TaskHandler(Core.Logics.StealLogic.OnUpdateTask, true);


                UpdateManager.Subscribe(Core.Logics.ModWatcherLogic.OnUpdate, 50);
                UpdateManager.BeginInvoke(CampStackLoop);

                UpdateManager.Subscribe(Core.Logics.ParticleRemover.OnUpdate, 1000);
                UpdateManager.Subscribe(EnemyUpdater.OnUpdate, 5000);

                //Core.Config._EULComboTask = new TaskHandler(Core.Logics.EULComboLogic.OnUpdateTask, true);

                _InventoryManager.Attach(Core.Config._Items);

                Entity.OnAnimationChanged += OnAnimationChanged;
                
                Task.Run(async () =>
                {
                    await Task.Delay(15000);
                    Core.Config._Hello = false;
                });
                Core.Config.Log.Warn("Load completed");
                Printer.Print("Please read docs for Rubick Rage at RageScript.pro");
            }
            catch (Exception ex)
            {
                Core.Config.Log.Error(ex.ToString());
            }
        }

        protected override void OnDeactivate()
        {
            _MenuManager.Value.DeregisterMenu(Core.Config._Menu);
            _Input.MouseClick -= MouseRegionCatch.Input_MouseClick;
            _Input.MouseMove -= MouseRegionCatch.OnMouseMove;

            Core.Config._Renderer.Draw -= Drawings.Info.OnDraw;
            Core.Config._Renderer.Draw -= Drawings.SpellConfigPanel.OnDraw;
            Core.Config._Renderer.Draw -= Drawings.StealConfigPanel.OnDraw;

            UpdateManager.Unsubscribe(LinkenSaveLogic.OnUpdate);
            UpdateManager.Unsubscribe(GlimmerSaveLogic.OnUpdate);

            UpdateManager.Unsubscribe(Core.Logics.ModWatcherLogic.OnUpdate);
            UpdateManager.Unsubscribe(Core.Logics.ParticleRemover.OnUpdate);
            UpdateManager.Unsubscribe(EnemyUpdater.OnUpdate);

            _InventoryManager.Detach(Core.Config._Items);
            Entity.OnAnimationChanged -= OnAnimationChanged;

            //foreach (var _BS in Core.Config._BombStacks)
            //{
            //    Core.Config._ParticleManager.Remove(_BS.Id.ToString());
            //}
           
            _InventoryManager.Detach(Core.Config._Items);
        }


        private static void OnAnimationChanged(Entity sender, EventArgs args)
        {
            if (sender.Team == Core.Config._Hero.Team || !sender.Animation.Name.Contains("attack")
                && sender.Animation.Name != "radiant_tower002")
            {
                return;
            }

            var unit = sender as Unit;
            if (unit == null || !unit.IsAttacking())
            {
                return;
            }

            if (Core.Config._EnemyAttakers.ContainsKey(unit) == false)
            {
                Core.Config._EnemyAttakers.Add(unit, 0);
            }
            else
            {
                Core.Config._EnemyAttakers[unit] = Game.RawGameTime;
            }
        }

        private async void CampStackLoop()
        {
            while (IsActive)
            {
                await Core.Logics.MainLogic.OnUpdateAsync();
                await Task.Delay(50);
            }
        }
    }
}