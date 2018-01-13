using System;

namespace RubickRage.Drawings
{
    public static class SpellConfigPanel
    {
        public static void OnDraw(object sender, EventArgs eventArgs)
        {
            //if (Core.Config.DoStack)
            //{
            //    if (Core.Config._Menu.Drawings.DrawingsOnTop)
            //    {
            //        var _Temp = HUDInfo.GetTopPanelPosition(Core.Config._Hero) + new Vector2(0, 60);
            //        Core.Config._Renderer.DrawRectangle(new RectangleF(_Temp.X, _Temp.Y, (float)HUDInfo.GetTopPanelSizeX(Core.Config._Hero), (float)HUDInfo.GetTopPanelSizeY(Core.Config._Hero)), System.Drawing.Color.Green, 2);
            //    }

            //    if (Core.Config._Menu.Drawings.DrawingsOnHero)
            //    {
            //        String _Text = "Pulling...";
            //        var _Pos = HUDInfo.GetHPbarPosition(Core.Config._Hero);
            //        var _Size = new Vector2((float)HUDInfo.GetHPBarSizeX(Core.Config._Hero), (float)HUDInfo.GetHpBarSizeY(Core.Config._Hero));
            //        var _TextSize = Core.Config._Renderer.MessureText(_Text);
            //        var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
            //        Core.Config._Renderer.DrawText(_TextPos, _Text, System.Drawing.Color.White);
            //    }
            //}

            //Core.Config._Renderer.DrawFilledRectangle(new SharpDX.RectangleF(500, 100, 100, 500), System.Drawing.Color.FromArgb(187, 187, 187, 187),
            //    System.Drawing.Color.FromArgb(237, 237, 237, 120), 20);

            var _Menu = Core.Config._Menu;
            if (_Menu.Drawings.DrawingsLotusCombo)
            {
                var _Renderer = Core.Config._Renderer;
                var _PanelHeight = _Menu.LotusCombo.LotusSpellConfigs.Count * 35 + 5;

                TempDrawExt.DrawFilledRectangle(new System.Drawing.RectangleF(_Menu.Drawings.LotusPanelX.Value, _Menu.Drawings.LotusPanelY.Value, 300, _PanelHeight),
                    System.Drawing.Color.FromArgb(187, 187, 187, 187),
                    System.Drawing.Color.FromArgb(100, 80, 80, 80), 2);

                int _Pad = 0;
                foreach (var _SC in _Menu.LotusCombo.LotusSpellConfigs)
                {
                    _Renderer.DrawTexture(_SC.Key, new SharpDX.RectangleF(_Menu.Drawings.LotusPanelX.Value + 5, _Menu.Drawings.LotusPanelY.Value + 5 + _Pad, 30, 30));
                    _Renderer.DrawText(new SharpDX.Vector2(_Menu.Drawings.LotusPanelX.Value + 40, _Menu.Drawings.LotusPanelY.Value + 9 + _Pad), "Steal", System.Drawing.Color.White);
                    TempDrawExt.DrawFilledRectangle(new System.Drawing.RectangleF(_Menu.Drawings.LotusPanelX.Value + 78, _Menu.Drawings.LotusPanelY.Value + 7 + _Pad, 25, 25),
                        System.Drawing.Color.FromArgb(187, 187, 187, 187),
                       _SC.Value.Steal ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));
                    _Renderer.DrawText(new SharpDX.Vector2(_Menu.Drawings.LotusPanelX.Value + 106, _Menu.Drawings.LotusPanelY.Value + 9 + _Pad), "Use", System.Drawing.Color.White);
                    TempDrawExt.DrawFilledRectangle(new System.Drawing.RectangleF(_Menu.Drawings.LotusPanelX.Value + 140, _Menu.Drawings.LotusPanelY.Value + 7 + _Pad, 25, 25),
                        System.Drawing.Color.FromArgb(187, 187, 187, 187),
                       _SC.Value.ForceUse ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));
                    _Renderer.DrawText(new SharpDX.Vector2(_Menu.Drawings.LotusPanelX.Value + 167, _Menu.Drawings.LotusPanelY.Value + 9 + _Pad), "Another target", System.Drawing.Color.White);
                    TempDrawExt.DrawFilledRectangle(new System.Drawing.RectangleF(_Menu.Drawings.LotusPanelX.Value + 265, _Menu.Drawings.LotusPanelY.Value + 7 + _Pad, 25, 25),
                      System.Drawing.Color.FromArgb(187, 187, 187, 187),
                      _SC.Value.AnotherTarger ? System.Drawing.Color.FromArgb(200, 121, 196, 71) : System.Drawing.Color.FromArgb(200, 200, 0, 0));

                    _Pad += 35;
                }
            }

            //String _Text = "Status " + Core.LotusLogic._Status;
            //var _Pos = HUDInfo.GetHPbarPosition(Core.Config._Hero);
            //var _Size = new Vector2((float)HUDInfo.GetHPBarSizeX(Core.Config._Hero), (float)HUDInfo.GetHpBarSizeY(Core.Config._Hero));
            //var _TextSize = Core.Config._Renderer.MessureText(_Text);
            //var _TextPos = _Pos - new Vector2(_TextSize.X + 10, 5);
            //Core.Config._Renderer.DrawText(_TextPos, _Text, System.Drawing.Color.White);
        }
    }
}
