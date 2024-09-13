namespace Drones
{
    public partial class Building
    {
        private Pen _buildingBrush;

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(_buildingBrush, new Rectangle(X, Y, Width, Depth));
        }
    }
}