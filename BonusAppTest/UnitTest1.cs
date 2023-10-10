using BonusApp;

namespace BonusAppTest
{
    [TestClass]
    public class UnitTest1
    {
        Order order;

        [TestInitialize]
        public void InitializeTest()
        {
            order = new Order();
            order.AddProduct(new Product
            {
                Name = "M�lk",
                Value = 10.0
            });
            order.AddProduct(new Product
            {
                Name = "Sm�r",
                Value = 15.0
            });
            order.AddProduct(new Product
            {
                Name = "P�l�g",
                Value = 20.0
            });
        }

        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(4.5, Bonuses.TenPercent(45.0));
            Assert.AreEqual(40.0, Bonuses.TenPercent(400.0));
        }

        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, Bonuses.FlatTwoIfAmountMoreThanFive(10.0));
            Assert.AreEqual(0.0, Bonuses.FlatTwoIfAmountMoreThanFive(4.0));
        }

        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(45.0, order.GetValueOfProducts());
        }

        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(40.5, order.GetTotalPrice());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(43.0, order.GetTotalPrice());
        }

        [TestMethod]
        public void GetBonusAnonymous_Test()
        {
            order.Bonus = delegate (double amount) 
            { 
                return amount * 0.1; 
            };
            //order.Bonus = Bonuses.TenPercent; // <- Change to anonymous methods
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = delegate (double amount) 
            { 
                if (amount > 5.0) return 2.0; 
                else return 0.0; 
            };
            //order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;  // <- Change to anonymous methods
            Assert.AreEqual(2.0, order.GetBonus());
        }
    }
}