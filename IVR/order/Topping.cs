using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.order
{
    class Topping : IItem
    {
        //prompt
        Prompt prompt;
        private string name;



        public Topping (string name, Prompt p)
        {
            this.name = name;
            this.prompt = p;
        }

        public Topping(string name)
        {
            this.name = name;
           
        }

        public List<Prompt> GetPrompts()
        {
            return new List<Prompt>() { prompt };
        }
        public string GetName()
        {
            return name;
        }

    }
}
