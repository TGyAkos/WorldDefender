using WorldDefender.Models;
using WorldDefender.Models.Entities;

namespace WorldDefenderTest
{
    [TestClass]
    public class CollisionBoxTest
    {
        private CollisionBox collisionBox { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            collisionBox = new CollisionBox(5, 3);
        }

        [TestCleanup]
        public void Cleanup()
        {
            collisionBox = null;
        }

        [TestMethod]
        public void Test_UpdateCollisionBox_WithCorrectData()
        {
            collisionBox.UpdateCollisionBox(new Coordiantes(5, 10));

            Assert.AreEqual(8, collisionBox.MaxCoords.X);
            Assert.AreEqual(15, collisionBox.MaxCoords.Y);

            Assert.AreEqual(2, collisionBox.MinCoords.X);
            Assert.AreEqual(15, collisionBox.MinCoords.Y);
        }

    }
}
