namespace WorldDefender.Models
{
    // Generic osztaly a jatekban szereplo entitasokhoz, direkt nem hasznaljuk
    public class Entity
    {
        public int Id { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public int AbsoluteSpeed { get; set; }
        public double SpeedVectorX { get; set; }
        public double SpeedVectorY { get; set; }
        public List<Data<String, Int32>> Data { get; set; }
        public bool IsAlive { get; set; }
        public int Health { get; set; }


        public void ClacSpeedVec()
        {
            IsAlive = true;
            AbsoluteSpeed = (int)Math.Abs(Math.Round(Math.Sqrt(Math.Pow(PosX, 2) + Math.Pow(PosY, 2))));
            SpeedVectorX = PosX / AbsoluteSpeed;
            SpeedVectorY = PosY / AbsoluteSpeed;
        }

        public void CheckCollision(Entity entity)
        {

        }

        public void Destory()
        {
            IsAlive = false;
        }
    }
}
