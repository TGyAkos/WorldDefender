namespace WorldDefender.Models
{
    internal class World
    {
        public int Tick { get; set; }
        public double TickSpeed { get; set; }
        public List<Entity> Entities { get; set; }

        public World()
        {
            Tick = 0;
            TickSpeed = 1.0 / 60.0;
        }

        public void MainLoop()
        {
            while (true)
            {
                // Update all entities
                // Check for collisions
                // Check for game over
                // Render
                // Sleep
            }
        }

        private void AdvanceTick()
        {
            if (Tick >= 60) ResetTick();
            else Tick++;
        }

        private void UpdateWorld()
        {
            // Ennek kene frissitenie az osszes entitast
        }

        private void CheckCollisions()
        {
            // Ennek kene inditania az utkozes ellenorzeseket az entitasok kozott
        }

        private void IncreaseSpawnChance()
        {
            // Ennek kene novelnie az Enemy SpawnChance-et
        }

        private void ResetTick()
        {
            Tick = 0;
        }

        private void ClearDeadEntities()
        {
            Entities.RemoveAll(e => !e.IsAlive);
        }
    }
}
