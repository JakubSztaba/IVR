using IVR.nodes;
using IVR.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IVR
{
    class Factory
    {
        List<Topping> toppings;
        List<Pizza> pizzas;


        public Factory (List<Topping> toppings, List<Pizza> pizzas)
        {
            this.toppings = toppings;
            this.pizzas = pizzas;
        }

        public Call Create()
        {
            Call call = new Call("uszanowanko");

            ChoiceNode wybor = new ChoiceNode("choice1", "co wybierasz qrwiy ;]", call);
            MessageNode wiadomosc1 = new MessageNode("wiad1", "wybrales pierwszy wybur", call);
            MessageNode wiadomosc2 = new MessageNode("wiad2", "wybrales drugi wybur ;]", call);
            EndNode koniec = new EndNode("koniec", "no i elo :}", call);
            ConfirmationNode wspaniale = new ConfirmationNode("potwierdzenie", "wcisnij 1 zeby potwierdzic :]", call, 1);
            EndNode koniecpotwierdzony = new EndNode("koniec potwierdzony", "super potwierdziles", call);
            EndNode koniecniepotwierdzony = new EndNode("koniec niepotwierdzony", "ehh no mogles potwierdzic", call);


            List<INode> wybory1 = new List<INode> { wiadomosc1, wiadomosc2 };
            wybor.AddChild(wybory1);
            wiadomosc1.AddChild(koniec);
            wiadomosc2.AddChild(wspaniale);
            wspaniale.AddChild(koniecpotwierdzony);
            wspaniale.SetNotConfirmedNode(koniecniepotwierdzony);

            call.SetStartingNode(wybor);

            return call;
        }
    }
}
