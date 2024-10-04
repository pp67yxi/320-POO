using Drones.Helpers;

namespace Drones
{
    public partial class Box
    {
        private Pen _buildingBrush = new Pen(new SolidBrush(Color.Orange), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(_buildingBrush, new Rectangle(X, Y, Width, Depth));
        }
    }
}