using SharpDX;

namespace RubickRage.Drawings
{
    public static class TempDrawExt
    {
        public static void DrawFilledRectangle(System.Drawing.RectangleF rect, System.Drawing.Color color, System.Drawing.Color BackgroundColor, uint BorderWidth = 1)
        {
            for (uint i = 0; i < BorderWidth; i++)
            {
                Core.Config._Renderer.DrawLine(new Vector2(rect.X - i, rect.Y - i), new Vector2(rect.X + rect.Width + i, rect.Y - i), color);
                Core.Config._Renderer.DrawLine(new Vector2(rect.X + rect.Width + i, rect.Y - i), new Vector2(rect.X + rect.Width + i, rect.Y + rect.Height + i), color);
                Core.Config._Renderer.DrawLine(new Vector2(rect.X + rect.Width + i, rect.Y + rect.Height + i), new Vector2(rect.X - i, rect.Y + rect.Height + i), color);
                Core.Config._Renderer.DrawLine(new Vector2(rect.X - i, rect.Y + rect.Height + i), new Vector2(rect.X - i, rect.Y - i), color);
            }
            for (int i = 1; i < rect.Height; i++)
            {
                Core.Config._Renderer.DrawLine(new Vector2(rect.X + 1, rect.Y + i), new Vector2(rect.X + rect.Width, rect.Y + i), BackgroundColor);
            }
        }
    }
}
