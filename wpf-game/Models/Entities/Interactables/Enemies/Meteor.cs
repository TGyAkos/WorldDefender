namespace WorldDefender.Models.Entities.Interactables.Enemies
{
    // Legegyszerűbb enemy, csak leesik
    public class Meteor : Enemy
    {
        public Meteor(Coordiantes CenterPos)
        {
            SizeX = 20;
            SizeY = 20;
            Health = 1;
            DamageValue = 1;
            this.CenterPos = CenterPos;
        }
    }
}
