using WorldDefender.Models.Entities.Interactables;

namespace WorldDefender.Models.Entities
{
    // A player osztaly, csak jobbra es balra tud menni
    public class Player : Entity
    {
        public bool IsGameOver { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }
        public List<Powerup> ActivePowerups { get; set; }

        public Player()
        {
            IsGameOver = false;
            Health = 10;
            Score = 0;
            ActivePowerups = new List<Powerup>();
        }

        public void CollidedWithOrPassedByEnemy()
        {
            Health--;
            if (Health <= 0) IsGameOver = true;
        }

        public void CollidedWithPowerup(Powerup powerup) => ActivePowerups.Add(powerup);
    }
}
