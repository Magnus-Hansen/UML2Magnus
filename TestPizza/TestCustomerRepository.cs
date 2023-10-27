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
            Customer c1 = new Customer("TestPerson1", "123456789", "Test1@zealand.com");
            Customer c2 = new Customer("TestPerson2", "333444555", "Test2@zealand.org");
            customerRepository.addCustomer(c1);
            customerRepository.addCustomer(c2);
        }

        [TestMethod]
        public void TestAddCustomer()
        {
            TestSetup();

            int numberBefore = customerRepository.Count;
            Customer p3 = new Customer("Test3", "45", "test3@zealand.dk");
            customerRepository.addCustomer(p3);
            int numberAfter = customerRepository.Count;

            //assert
            Assert.AreEqual(++numberBefore, numberAfter);
        }
        [TestMethod]
        public void TestLookupCustomer()
        {
            TestSetup();

            Customer p3 = new Customer("test3", "55", "test3@zealand.dk");
            customerRepository.addCustomer(p3);

            Assert.AreEqual(p3, customerRepository.LookupCustomer("test3"));
        }
        [TestMethod]
        public void TestRemoveCustomer()
        {
            TestSetup();

            int numberBefore = customerRepository.Count;
            customerRepository.removeCustomer("TestPerson2");
            int numberAfter = customerRepository.Count;

            //assert
            Assert.AreEqual(--numberBefore, numberAfter);
        }
    }
}
