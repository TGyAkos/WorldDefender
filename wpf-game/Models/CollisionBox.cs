namespace WorldDefender.Models
{
    public class CollisionBox
    {
        public double OffsetY { get; set; }
        public int Size { get; set; }
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public double CenterPosX { get; set; }
        public double CenterPosY { get; set; }
        public CollisionBox(double offsety, int size)
        {
            this.OffsetY = offsety;
            this.Size = size;
        }
        public void UpdateCollisionBox(double centerPosX, double centerPosY)
        {

        }
    }
}
