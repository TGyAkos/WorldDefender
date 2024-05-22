using WorldDefender.Models;
using WorldDefender.Models.Entities;
using WorldDefender.Models.Entities.Interactables;
using WorldDefender.Models.Entities.Interactables.Enemies;

namespace WorldDefenderTest
{
    [TestClass]
    public class EntityManagementTest
    {
        public TestContext TestContext { get; set; }
        private EntityManagement entityManagement { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            entityManagement = new EntityManagement();

            // Add test bullets
            entityManagement.BulletList.Add(new Bullet
            {
                CenterPos = new Coordiantes(10, 15),
            });

            entityManagement.BulletList.Add(new Bullet
            {
                CenterPos = new Coordiantes(20, 0),
            });

            entityManagement.BulletList.Add(new Bullet
            {
                CenterPos = new Coordiantes(30, -2),
            });

            // Add test enemies
            entityManagement.EnemyList.Add(new Meteor(new Coordiantes(10, 15)));
            entityManagement.EnemyList.Add(new Meteor(new Coordiantes(20, 30)));
            entityManagement.EnemyList.Add(new Meteor(new Coordiantes(20, 10)));
            entityManagement.EnemyList.Add(new Meteor(new Coordiantes(30, 0)));

            entityManagement.Player.CenterPos = new Coordiantes(20, 5);

            if (TestContext.Properties.Contains("something"))
            {
                // Do something with that data
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            entityManagement = null;
        }

        [TestMethod]
        public void Test_CheckWorldBorder_Bullet()
        {
            Bullet bullet = new Bullet { CenterPos = new Coordiantes(10, -2) };

            entityManagement.CheckWorldBorder(bullet, new Enemy());

            Assert.AreEqual(false, bullet.IsAlive);
        }

        [TestMethod]
        public void Test_CheckWorldBorder_Enemy()
        {
            Enemy enemy = new Enemy { CenterPos = new Coordiantes(10, 15) };

            entityManagement.CheckWorldBorder(new Bullet(), enemy);

            Assert.AreEqual(false, enemy.IsAlive);
        }

        [TestMethod]
        public void Test_CheckPlayerCollision()
        {
            Meteor enemy = new Meteor(new Coordiantes(10, 7));

            entityManagement.CheckPlayerCollision(enemy);

            Assert.AreEqual(9, entityManagement.Player.Health);
        }

        [TestMethod]
        public void Test_CheckBulletCollision()
        {
            Bullet bullet = new Bullet { CenterPos = new Coordiantes(5, 12) };
            Enemy enemy = new Enemy { CenterPos = new Coordiantes(10, 15) };

            entityManagement.CheckBulletCollision(bullet, enemy);

            Assert.AreEqual(false, bullet.IsAlive);
            Assert.AreEqual(false, enemy.IsAlive);
        }

        [TestMethod]
        public void Test_RemoveCollidedItem()
        {
            Bullet bullet = new Bullet();
            Enemy enemy = new Enemy();

            entityManagement.RemoveCollidedItem(bullet, enemy);

            Assert.AreEqual(false, bullet.IsAlive);
            Assert.AreEqual(false, enemy.IsAlive);
        }

        [TestMethod]
        public void Test_ClearDestoryedItems_Enemy()
        {
            entityManagement.EnemyList.ElementAt(0).IsAlive = false;
            entityManagement.EnemyList.ElementAt(1).IsAlive = false;
            entityManagement.EnemyList.ElementAt(2).IsAlive = false;
            entityManagement.EnemyList.ElementAt(3).IsAlive = false;

            entityManagement.ClearDestoryedItems();

            Assert.AreEqual(0, entityManagement.EnemyList.Count);
        }

        [TestMethod]
        public void Test_ClearDestoryedItems_Bullet()
        {
            entityManagement.BulletList.ElementAt(0).IsAlive = false;
            entityManagement.BulletList.ElementAt(1).IsAlive = false;
            entityManagement.BulletList.ElementAt(2).IsAlive = false;

            entityManagement.ClearDestoryedItems();

            Assert.AreEqual(0, entityManagement.BulletList.Count);
        }

        [TestMethod]
        public void Test_CheckCollisions()
        {
            entityManagement.CheckCollisions();

            Assert.AreEqual(9, entityManagement.Player.Health);
            Assert.AreEqual(1, entityManagement.EnemyList.Count);
            Assert.AreEqual(0, entityManagement.BulletList.Count);
        }
    }
}
