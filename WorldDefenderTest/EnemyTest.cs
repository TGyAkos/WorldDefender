using WorldDefender.Models;
using WorldDefender.Models.Entities;
using WorldDefender.Models.Entities.Interactables;

namespace WorldDefenderTest
{
    [TestClass]
    public class EnemyTest
    {
        private EntityManagement EM { get; set; }
        [TestInitialize]
        public void Initialize()
        {
            EM = new EntityManagement();
            EM.EnemyList.Add(new Enemy(1, 1, 1));
            EM.EnemyList.Add(new Enemy(3, 3, 3));
        }

        [TestCleanup]
        public void Cleanup()
        {
            EM = null;
        }

        [TestMethod]
        public void Test_DMGRecieved()
        {
            EM.EnemyList[1].DMGRecieved();

            Assert.AreEqual(2, EM.EnemyList[1].Health);
        }

        [TestMethod]
        public void Test_DMGDealt()
        {
            EM.CheckWorldBorder();

            Assert.AreEqual(2, 1);
        }

        [TestMethod]
        public void Test_EnemyEliminated()
        {

        }
    }
}