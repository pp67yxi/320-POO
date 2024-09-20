namespace Drones
{
    public partial class Building
    {
        private Pen _buildingBrush;

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace, bool isStore)
        {
            if (isStore)
            {
                drawingSpace.Graphics.DrawEllipse(_buildingBrush, new Rectangle(X, Y, Width, Depth));
                
            }
            else
            {
                drawingSpace.Graphics.DrawRectangle(_buildingBrush, new Rectangle(X, Y, Width, Depth));
            }
        }
    }
}