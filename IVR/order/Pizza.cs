using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.order
{
    class Pizza : IItem
    {

        private string name = "DEFAULT_PIZZA";
        private bool customCreated = false;
        private Size size;
        private Prompt prompt;

        
        List<Topping> toppings = new List<Topping>();



        public Pizza(string name)
        {
            this.name = name;
        }

        public Pizza() { }
         
        public Pizza(List<Topping> toppings)
        {
            this.toppings = toppings;
            customCreated = true;
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }

        public Prompt GetPrompt()
        {
            return prompt;
        }

    }
}
