using IVR.nodes;
using IVR.order;
using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IVR
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Prompt> chuj = new List<Prompt>() { new Prompt("gun.wav"), new Prompt("gun1.wav") };
            PromptPlayer p = new PromptPlayer(chuj);
            p.ThreadPlay();
            Console.WriteLine("chuj do dupy");
            Console.ReadLine();
            p.ThreadStop();
            Console.WriteLine("chuj do dup2");
            Console.ReadLine();


            /*
            ToppingsFactory toppingsFactory = new ToppingsFactory();
            List<Topping> toppings = toppingsFactory.Create();

            MenuFactory menuFactory = new MenuFactory(toppings);
            List<Pizza> pizzas = menuFactory.Create();

            Factory factory = new Factory(toppings,pizzas);
            Call call = factory.Create();


            // chalo kurwa robie tutaj zmiane elegancko

            call.Run();

            while (true)
                call.OnKeyboard(Console.ReadKey().KeyChar);
*/


        }
    }
}
