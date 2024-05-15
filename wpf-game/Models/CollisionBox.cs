using System.Drawing;
using System.Windows;
using WorldDefender.Models.Entities;

namespace WorldDefender.Models
{
    public class CollisionBox
    {
        public int Id { get; set; }

        public Rectangle CollisionRectangle = new Rectangle();

        public CollisionBox(Coordiantes centerPos, int sizeX, int sizeY)
        {
            CollisionRectangle = new Rectangle((int)centerPos.X, (int)centerPos.Y, sizeX, sizeY);
        }

        public void UpdateCollisionBox(Coordiantes newCenterPos)
        {
            CollisionRectangle.Location = new System.Drawing.Point((int)newCenterPos.X, (int)newCenterPos.Y);
        }
    }
}
