using WorldDefender.Models;
using WorldDefender.Models.Entities;
   
namespace WorldDefenderTest
{
    [TestClass]
    public class CollisionBoxTest
    {
        private CollisionBox collisionBox { get; set; }
        private CollisionBox collisionBox2 { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            collisionBox = new CollisionBox(new Coordiantes(5,5),2,2);
            collisionBox2 = new CollisionBox(new Coordiantes(5, 5), 2, 2);
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

            Assert.IsTrue(collisionBox.CollisionRectangle.IntersectsWith(collisionBox2.CollisionRectangle));
        }

    }
}
