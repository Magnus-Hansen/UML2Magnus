using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UML2Magnus
{
    public class Terminal
    {
        #region Instance
        PizzaRepository _pizzaRepository = new PizzaRepository();
        CustomerRepository _customerRepository = new CustomerRepository();
        //OrderRepository orderRepository = new OrderRepository();
        //ToppingRepository toppingRepository = new ToppingRepository();
        #endregion

        #region Constructor
        public Terminal(PizzaRepository pizzaRepository, CustomerRepository customerRepository) 
        {
            _pizzaRepository = pizzaRepository;
            _customerRepository = customerRepository;
        }
        #endregion

        #region Methods
        public void Run()
        {
            int choice = showChoice();
            Console.Clear();
            while (choice != 6) {
                switch (choice)
                {
                    case 1:
                        LookupPizza();
                        break;

                    case 2:
                        AddPizza();
                        break;

                    case 3:
                        DeletePizza();
                        break;

                    case 4:
                        UpdatePizza();
                        break;

                    case 5:
                        _pizzaRepository.Printpizza();
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
                choice = showChoice();
            }
        }

        public int showChoice()
        {
            Console.WriteLine("\t1.\t search for pizza");
            Console.WriteLine("\t2.\t add pizza");
            Console.WriteLine("\t3.\t delete pizza");
            Console.WriteLine("\t4.\t update pizza");
            Console.WriteLine("\t5.\t print list of pizza");
            Console.WriteLine("\t6 \t exit terminal");
            return Functions.GetIntWithLimit(6);
        }

        private void LookupPizza() 
        {
            Console.WriteLine("Pizza number");
            Pizza pizza = _pizzaRepository.LookupPizza(Functions.GetInt());
            if (pizza != null)
            {
                Console.WriteLine(pizza.ToString());
                Console.ReadLine();
            }
        }

        private void AddPizza()
        {
            Console.WriteLine("Pizza number");
            int pizzaNo = Functions.GetInt();
            Console.WriteLine("Pizza name");
            string name = Functions.GetString();
            Console.WriteLine("Pizza price");
            int price = Functions.GetInt();
            Console.WriteLine("pizza ingredients");
            string ingredient = Functions.GetString();
            Pizza pizza = new Pizza(pizzaNo, name, price, ingredient);
            _pizzaRepository.addPizza(pizza);
        }

        private void DeletePizza()
        {
            Console.WriteLine("Pizza number");
            _pizzaRepository.removePizza(Functions.GetInt());
        }

        private void UpdatePizza()
        {
            Console.WriteLine("pizzaNo");
            int pizzaNo = Functions.GetInt();
            if (_pizzaRepository.LookupPizza(pizzaNo) != null) 
            {
                Console.WriteLine("Pizza name");
                string name = Functions.GetString();
                Console.WriteLine("Pizza price");
                int price = Functions.GetInt();
                Console.WriteLine("pizza ingredients");
                string ingredient = Functions.GetString();
                Pizza pizza = new Pizza(pizzaNo, name, price, ingredient);
                _pizzaRepository.UpdatePizza(pizzaNo, pizza);

            } else { Console.WriteLine("Pizza does not exist"); }
        }
        #endregion
    }
}
