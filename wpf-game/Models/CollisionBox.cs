using WorldDefender.Models.Entities;

namespace WorldDefender.Models
{
    public class CollisionBox
    {
        public int Id { get; set; }
        public double OffsetY { get; set; }
        public int Size { get; set; }
        public Coordiantes MinCoords { get; set; }
        public Coordiantes MaxCoords { get; set; }
        public Coordiantes CenterPos { get; set; }

        public CollisionBox(double offsety, int size)
        {
            OffsetY = offsety;
            Size = size;
        }

        public void UpdateCollisionBox(Coordiantes newCenterPos)
        {
            MaxCoords = new Coordiantes(newCenterPos.X + Size, newCenterPos.Y + OffsetY);
            MinCoords = new Coordiantes(newCenterPos.X - Size, newCenterPos.Y + OffsetY);

            CenterPos = newCenterPos;
        }

    }
}
