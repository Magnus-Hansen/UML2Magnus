using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Magnus
{
    public class Pizza
    {
        #region Instance fields
        private int _pizzaNo;
        private string _name;
        private int _price;
        private string _ingredients;
        #endregion

        #region Constructor
        Pizza(int pizzaNo, string name, int price, string ingredients)
        {
            _pizzaNo = pizzaNo;
            _name = name;
            _price = price;
            _ingredients = ingredients;
        }
        #endregion

        #region Properties
        public int PizzaNo
        {
            get { return _pizzaNo; }
        }
        public string Name
        { 
            get { return _name; } 
        }
        public int Price
        {
            get { return _price; }
        }
        public string ingredients 
        { 
            get { return _ingredients; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return _pizzaNo.ToString() + _name.ToString() + _price.ToString() + _ingredients.ToString();
        }
        #endregion
    }
}
