using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Magnus
{
    public class CustomerRepository
    {
        #region Instance fields
        private Dictionary<string, Customer> _customer;
        #endregion

        #region Constructor
        public CustomerRepository()
        {
            _customer = new Dictionary<string, Customer>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _customer.Count; }
        }
        #endregion

        #region Methods
        public Customer LookupCustomer(string name)
        {
            if (_customer.ContainsKey(name))
                return _customer[name];
            return null;
        }
        public void addCustomer(Customer customer)
        {
            if (LookupCustomer(customer.Name) != null)
                _customer.Add(customer.Name, customer);
        }
        public void removeCustomer(string name)
        {
            if (LookupCustomer(name) != null)
                _customer.Remove(name);
        }
        public void updateCustomer(string name, Customer customer)
        {
            if (LookupCustomer(name) != null)
                _customer[name] = customer;
        }
        public void printCustomer()
        {
            foreach (Customer customer in _customer.Values)
                Console.WriteLine(customer.ToString());
        }
        #endregion
    }
}
