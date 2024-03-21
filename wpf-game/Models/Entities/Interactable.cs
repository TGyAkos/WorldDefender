namespace WorldDefender.Models.Entities
{
    internal class Interactable
    {
        public int SpawnChance { get; set; }

        public Interactable()
        {
            SpawnChance = 0;
        }

        public void increaseSpawnChance()
        {
            SpawnChance *= 2;
        }
    }
}
