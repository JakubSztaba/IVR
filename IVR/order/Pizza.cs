using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.order
{
    class Pizza 
    {

        private string name = "DEFAULT_PIZZA";
        //name prompt
        List<Topping> toppings = new List<Topping>();



        public Pizza(string name)
        {
            this.name = name;
        }
       
        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }
    }
}
