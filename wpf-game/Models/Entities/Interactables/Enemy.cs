namespace WorldDefender.Models.Entities.Interactables
{
    // Generic enemy class movementet, illetve a sebzeseket kell kezelnie
    // Tarolja a a megolesert adott pontokat
    public class Enemy : Interactable
    {
        // Lehet negativ is
        public int Points { get; set; }
        public int Health { get; set; }

        // Mennyit sebez a playerre ha belemegy
        public int DamageValue { get; set; }
        public Enemy(int points, int health, int damageValue)
        {
            Points = points;
            Health = health;
            DamageValue = damageValue;
        }
    }
}
