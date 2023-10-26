using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML2Magnus;

namespace TestPizza
{
    [TestClass]
    public class TestCustomerRepository
    {
        private CustomerRepository customerRepository = new CustomerRepository();

        public void TestSetup()
        {
            Customer c1 = new Customer("UwU", "123456789", "Hentai@UglyBastard.cum");
            Customer c2 = new Customer("Bait", "333444555", "Master@Baiter.orgy");
            customerRepository.addCustomer(c1);
            customerRepository.addCustomer(c2);
        }

        [TestMethod]
        public void TestAddCustomer()
        {
            TestSetup();

            int numberBefore = customerRepository.Count;
            Customer p3 = new Customer("Margarita", "45", "sause@rule.34");
            customerRepository.addCustomer(p3);
            int numberAfter = customerRepository.Count;

            //assert
            Assert.AreEqual(++numberBefore, numberAfter);
        }
        [TestMethod]
        public void TestLookupCustomer()
        {
            TestSetup();

            Customer p3 = new Customer("Margarita", "55", "ost@crust.omer");
            customerRepository.addCustomer(p3);

            Assert.AreEqual(p3, customerRepository.LookupCustomer("Margarita"));
        }
        [TestMethod]
        public void TestRemoveCustomer()
        {
            TestSetup();

            int numberBefore = customerRepository.Count;
            customerRepository.removeCustomer("Bait");
            int numberAfter = customerRepository.Count;

            //assert
            Assert.AreEqual(--numberBefore, numberAfter);
        }
    }
}
