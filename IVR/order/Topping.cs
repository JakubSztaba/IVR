using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.order
{
    class Topping
    {
        //prompt

        private string name;



        public Topping (string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

    }
}
