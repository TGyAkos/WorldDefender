using WorldDefender.Interfaces;
using WorldDefender.Models.Entities;

namespace WorldDefender.Models
{
    // Generic osztaly a jatekban szereplo entitasokhoz, direkt nem hasznaljuk
    public class Entity : AMethods
    {
        public int Id { get; set; }
        public Coordiantes CenterPos { get; set; }
        public int AbsoluteSpeed { get; set; }
        public double SpeedVectorX { get; set; }
        public double SpeedVectorY { get; set; }
        public List<Data<String, Int32>> Data { get; set; }
        public bool IsAlive { get; set; }
        public int Health { get; set; }
        public int WorldBorderUpper { get; set; }
        public int WorldBorderLower { get; set; }
        public CollisionBox CollisionBox { get; set; }


        public void ClacSpeedVec()
        {
            IsAlive = true;
            AbsoluteSpeed = (int)Math.Abs(Math.Round(Math.Sqrt(Math.Pow(CenterPos.X, 2) + Math.Pow(CenterPos.Y, 2))));
            SpeedVectorX = CenterPos.X / AbsoluteSpeed;
            SpeedVectorY = CenterPos.Y / AbsoluteSpeed;
        }

        public void Destory()
        {
            IsAlive = false;
        }
    }
}
