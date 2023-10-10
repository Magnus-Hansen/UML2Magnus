using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Magnus
{
    public class PizzaRepository
    {
        #region Instance fields
        private Dictionary<int, Pizza> _pizza;
        #endregion

        #region Constructor
        public PizzaRepository() 
        {
            _pizza = new Dictionary<int, Pizza>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _pizza.Count;}
        }
        #endregion

        #region Methods
        public Pizza LookupPizza(int pizzaNo)
        {
            if (_pizza.ContainsKey(pizzaNo))
                return _pizza[pizzaNo];
            return null;
        }
        public void addPizza(Pizza pizza)
        {
            if (LookupPizza(pizza.PizzaNo) != null)
                _pizza.Add(pizza.PizzaNo, pizza);
        }
        public void removePizza(int pizzaNo)
        {
            if (LookupPizza(pizzaNo) != null)
                _pizza.Remove(pizzaNo);
        }
        public void UpdatePizza(int pizzaNo, Pizza pizza)
        {
            if (LookupPizza(pizzaNo) != null)
                _pizza[pizzaNo] = pizza;
        }
        public void Printpizza()
        {
            foreach (Pizza pizza in _pizza.Values)
                Console.WriteLine(pizza.ToString());
        }
        #endregion
    }
}
