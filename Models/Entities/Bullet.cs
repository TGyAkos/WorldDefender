namespace WorldDefender.Models.Entities
{
    // A player tudja spawn-olni, csak felfele tud menni, ha valamivel utkozik akkor meghal es megoli a masikat
    public class Bullet : Entity
    {
        public double PosX { get; set; }
        public double PosY { get; set; }
        public CollisionBox CollisionBox { get; set; }
    }
}
