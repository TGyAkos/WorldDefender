using WorldDefender.Interfaces;

namespace WorldDefender.Models.Entities.Interactables
{
    // Generic enemy class movementet, illetve a sebzeseket kell kezelnie
    // Tarolja a a megolesert adott pontokat
    public class Enemy : Interactable
    {
        // Lehet negativ is
        public int Points { get; set; }

        // Mennyit sebez a playerre ha belemegy
        public int DamageValue { get; set; }

        public Enemy(int point, int health, int damageValue)
        {
            Points = point;
            Health = health;
            DamageValue = damageValue;
        }

        public override void DMGRecieved()
        {
            Health--;
            if(Health <= 0) { IsAlive = false; }
        }
    }
}
