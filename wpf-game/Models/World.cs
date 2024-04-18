using WorldDefender.Models.Entities;

namespace WorldDefender.Models
{
    public class World
    {
        public int Tick { get; set; }
        public double TickSpeed { get; set; }
        public Player Player { get; set; }
        public EntityManagement EntityManagement { get; set; }

        public World()
        {
            Tick = 0;
            TickSpeed = 1.0 / 60.0;
        }



        public void MainLoop()
        {
            while (Player.IsGameOver == false)
            {
                // Update all entities
                // Check for collisions
                // Check for game over
                // Render
                // Sleep
            }
        }

        public void AdvanceTick()
        {
            if (Tick >= 60) ResetTick();
            else Tick++;
        }

        public void UpdateWorld()
        {
            // Ennek kene frissitenie az osszes entitast
        }

        public void IncreaseSpawnChance()
        {
            // Ennek kene novelnie az Enemy SpawnChance-et
        }

        public void IncreaseEnemySpeed()
        {

        }

        public void ResetTick()
        {
            Tick = 0;
        }

        public void ClearDeadEntities()
        {
        }
    }
}
