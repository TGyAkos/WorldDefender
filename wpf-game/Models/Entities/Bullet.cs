namespace WorldDefender.Models.Entities
{
    // A player tudja spawn-olni, csak felfele tud menni, ha valamivel utkozik akkor meghal es megoli a masikat
    public class Bullet : Entity
    {
        public Coordiantes CenterPos { get; set; } = new Coordiantes(0, 0);
        public int SizeX { get; set; } = 5;
        public int SizeY { get; set; } = 10;
        public CollisionBox CollisionBox { get; set; }

        public Bullet()
        {
            CollisionBox = new CollisionBox(CenterPos, SizeX, SizeY);
        }

    }
}
