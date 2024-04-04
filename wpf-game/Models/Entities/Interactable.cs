namespace WorldDefender.Models.Entities
{
    // Generic osztaly az osszes dolgohoz amihez a player hozza tud erni
    // Ha valami minden osztalyban szerepel, akkor ide kell rakni
    internal class Interactable : Entity
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
