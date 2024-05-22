using WorldDefender.Models.Entities;
using WorldDefender.Models.Entities.Interactables;

namespace WorldDefender.Models
{
    public class EntityManagement
    {
        public List<Bullet> BulletList { get; set; }
        public List<Enemy> EnemyList { get; set; }
        public Player Player { get; set; }

        // Some dummy value used for unit testing
        public double LowerScreenBorder { get; set; } = 10;

        public EntityManagement()
        {
            BulletList = new List<Bullet>();
            EnemyList = new List<Enemy>();
            Player = new Player();
        }

        public void CheckCollisions()
        {
            foreach (var enemy in EnemyList.ToList())
            {
                CheckPlayerCollision(enemy);

                foreach (var bullet in BulletList.ToList())
                {
                    CheckBulletCollision(bullet, enemy);
                    CheckWorldBorder(bullet, enemy);
                }
            }

            ClearDestoryedItems();
        }

        public void CheckWorldBorder(Bullet bullet, Enemy enemy)
        {
            // Megnezi, hogy a jatekteren belul vannak-e az entitasok
            // HA KISEBB MINT Y, AKKOR -1 ELET
            if (bullet.CenterPos.Y < 0)
            {
                bullet.IsAlive = false;
            }

            if (enemy.CenterPos.Y > LowerScreenBorder)
            {
                enemy.IsAlive = false;
            }

        }

        public void CheckPlayerCollision(Enemy enemy)
        {
            // Megnezi, hogy az entitasok osszeutkoztek-e a jatekosal
            if (Player.CollisionBox.CollisionRectangle.IntersectsWith(enemy.CollisionBox.CollisionRectangle))
            {
                Player.Health--;
            }
        }

        public void CheckBulletCollision(Bullet bullet, Enemy enemy)
        {
            if (bullet.CollisionBox.CollisionRectangle.IntersectsWith(enemy.CollisionBox.CollisionRectangle))
            {
                RemoveCollidedItem(bullet, enemy);
            }
        }

        public void RemoveCollidedItem(Entity collided1, Entity collided2)
        {
            // Removeolja a helyes entitasokat a listabol
            collided1.IsAlive = false;
            collided2.IsAlive = false;
        }

        public void ClearDestoryedItems()
        {
            // Az isAlive erteke alapjan torli a megsemmisult entitasokat
            foreach (var enemy in EnemyList.ToList())
            {
                if (enemy.IsAlive == false)
                {
                    EnemyList.Remove(enemy);
                }
            }

            foreach (var bullet in BulletList.ToList())
            {
                if (bullet.IsAlive == false)
                {
                    BulletList.Remove(bullet);
                }
            }
        }
    }
}
