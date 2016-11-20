using IVR.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR
{
    class MenuFactory
    {
        List<Topping> toppings;


        public MenuFactory(List<Topping> toppings)
        {
            this.toppings = toppings;
        }

        public List<Pizza> Create()
        {
            List<Pizza> list = new List<Pizza>();
            
               list.Add(CreatePizza(new List<string> {"ser","szynka" },"margarita :>"));
            

            
            // tutaj idom pitce







            return list;
        }



        private Pizza CreatePizza(List<string> tlist,string name)
        {

            Pizza pizza = new Pizza(name);

            foreach (string element in tlist)
            {
                int o = 0;
                Topping foundItem = toppings.FirstOrDefault(i => i.GetName() == element);
                if (foundItem != null)
                {
                    pizza.AddTopping(foundItem);
                }
                else
                {
                    Console.WriteLine("pitca nie moze byc stworzona :/");
                    break;
                }

            Console.WriteLine("skladnik zatwierdzond");
        }








            return pizza;
        }
    }
}
