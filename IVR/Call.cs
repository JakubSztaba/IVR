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
    class Call : IEventHandler
    {
        string callName;

        INode activeNode;
        INode startingNode;
        Pizza currentPizza = new Pizza();
        Factory owner;

        List<INode> nodes = new List<INode>();
        List<IItem> items = new List<IItem>();

        public Call (string callName, Factory owner)
        {
            this.callName = callName;
            this.owner = owner;

        }

        public void AddNode(INode node)
        {
            nodes.Add(node);

        }

        public void SetStartingNode(INode startingNode)
        {
            this.startingNode = startingNode;
        }

        public void Run()
        {
            activeNode = startingNode;
            activeNode.Entry();
        }

        public void OnKeyboard (char input)
        {
            activeNode.OnKeyboard(input);
        }

        public void OnFinishNode (string output)
        {
            INode foundItem = nodes.FirstOrDefault(i => i.GetNodeName() == output);
            if (foundItem != null)
            {
                activeNode = foundItem;
                activeNode.Entry();
            }
            else
            {
                Console.WriteLine("skaszanilo sie");
            }
        }

        public void PickFromMenu(int i)
        {
            currentPizza = owner.GetPizzas()[i - 1];
            Console.WriteLine(currentPizza.GetName());
        }

        public Pizza GetPizza()
        {
            return currentPizza;
        }


    }
}
