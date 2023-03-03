using OrangeTreeSim;

namespace OrangeTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        private OrangeTree orangeTree;

        [TestInitialize]
        public void SetupForTest()
        {
            // Start an orange tree
            orangeTree = new OrangeTree();
            orangeTree.Age = 0;
            orangeTree.Height = 6;
            orangeTree.TreeAlive = true;
        }

        [TestMethod]
        public void ShouldIncrementTheTreesAgeWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(1, orangeTree.Age);
        }
        [TestMethod]
        public void ShouldIncrementTheTreesHeightByTwoWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(8, orangeTree.Height);
        }
        [TestMethod]
        public void ShouldDieAfter80Years()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive);
        }

        [TestMethod]
        public void ShouldProduceFruitAfter2Years()
        {
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
        }
    }
}
