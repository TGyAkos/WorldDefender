using WorldDefender.Models.Entities;

namespace WorldDefender.Models
{
    public class EntityManagement
    {
        public List<Entity> EntityList = new List<Entity>();
        public List<Entity> CollidedList = new List<Entity>();
        public Player Player = new Player();

        public void CheckCollision()
        {
            // Linq-val megnezzuk, hogy hol van overlap a collision boxok listajaban
        }
        public void CheckCollidedEntities(int[] Collided)
        {
            // Megnezi a KET osszeutkozott entitasnak a fajtajat, es aszerint nem removolja ha pl: powerup 
        }
        public void CheckWorldBorder()
        {
            // Megnezi, hogy a jatekteren belul vannak-e az entitasok
            // HA KISEBB MINT Y, AKKOR -1 ELET
        }
        public void CheckPlayerCollision()
        {
            // Megnezi, hogy az entitasok osszeutkoztek-e a jatekosal
        }
        public void RemoveCollidedItem()
        {
            // Removeolja a helyes entitasokat a listabol
        }

        public void ClearDestoryedItems()
        {
            // Az isAlive erteke alapjan torli a megsemmisult entitasokat
        }
    }
}
