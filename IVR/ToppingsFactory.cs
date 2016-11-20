using IVR.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR
{
    class ToppingsFactory
    {
        public List<Topping> Create()
        {
            List<Topping> list = new List<Topping>()
            {
                    new Topping("ser"),
                    new Topping("szynka"),
                    new Topping("magulon"),
                    new Topping("ananas"),
                    new Topping("podwujny ananas ;]]"),
            }
            ;
            return list;
        }
    }
}
