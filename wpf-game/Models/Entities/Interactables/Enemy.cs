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

        public Coordiantes CenterPos { get; set; } = new Coordiantes(0, 0);
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public CollisionBox CollisionBox { get; set; }

        public Enemy()
        {
            CollisionBox = new CollisionBox(CenterPos, SizeX, SizeY);
        }
    }
}
