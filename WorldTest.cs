using WorldDefender.Models;

namespace WorldDefenderTest
{
    [TestClass]
    public class WorldTest
    {
        public TestContext TestContext { get; set; }
        private World world { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            world = new World();

            if (TestContext.Properties.Contains("something"))
            {
                // Do something with that data
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            world = null;
        }

        [TestMethod]
        public void TickTest()
        {
            world.Tick = 0;

            world.AdvanceTick();

            Assert.AreEqual(1, world.Tick);
        }

        [TestMethod]
        public void TickOverflowTest()
        {
            world.Tick = 60;

            world.AdvanceTick();

            Assert.AreEqual(0, world.Tick);
        }

    }
}
