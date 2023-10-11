using System.Diagnostics;
using System.Xml.Linq;
using UML2Magnus;

namespace TestPizza
{
    [TestClass]
    public class TestPizzaRepository
    {
        private PizzaRepository pizzaRepository = new PizzaRepository();
        public void TestSetup()
        {
            Pizza p1 = new Pizza(1, "bønnePizza", 45, "bønner");
            Pizza p2 = new Pizza(5, "Hawaii", 60, "ananas");
            pizzaRepository.addPizza(p1);
            pizzaRepository.addPizza(p2);
        }

        [TestMethod]
        public void TestAddPizza()
        {
            //arrange
            TestSetup();

            //act
            int numberBefore = pizzaRepository.Count;
            Pizza p3 = new Pizza(30, "Margarita", 45, "sause");
            pizzaRepository.addPizza(p3);
            int numberAfter = pizzaRepository.Count;

            //assert
            Assert.AreEqual(++numberBefore, numberAfter);
        }

        [TestMethod]
        public void TestLookupPizza()
        {
            TestSetup();

            Pizza p3 = new Pizza(6, "Margarita", 55, "ost");
            pizzaRepository.addPizza(p3);

            Assert.AreEqual(p3, pizzaRepository.LookupPizza(6));
        }

        [TestMethod]
        public void TestRemovePizza()
        {
            TestSetup();

            int numberBefore = pizzaRepository.Count;
            pizzaRepository.removePizza(5);
            int numberAfter = pizzaRepository.Count;

            //assert
            Assert.AreEqual(--numberBefore, numberAfter);
        }

        [TestMethod]
        public void TestUpdatePizza()
        {
            TestSetup();

            Pizza p3 = new Pizza(30, "Margarita", 45, "sause");
            pizzaRepository.UpdatePizza(5, p3);

            //assert
            Assert.AreEqual(p3, pizzaRepository.LookupPizza(5));
        }
    }
}