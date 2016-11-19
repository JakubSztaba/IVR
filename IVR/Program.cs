using IVR.nodes;
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
            Call call = new Call("uszanowanko");

            ChoiceNode wybor = new ChoiceNode("choice1", "co wybierasz qrwiy ;]", call);
            MessageNode wiadomosc1 = new MessageNode("wiad1", "wybrales pierwszy wybur", call);
            MessageNode wiadomosc2 = new MessageNode("wiad2", "wybrales drugi wybur ;]", call);


            List<INode> wybory1 = new List<INode> { wiadomosc1, wiadomosc2 };
            wybor.AddChild(wybory1);

            call.SetStartingNode(wybor);


            

            call.Run();

            while (true)
                call.OnKeyboard(Console.ReadKey().KeyChar);



        }
    }
}
