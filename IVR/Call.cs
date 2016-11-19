using IVR.nodes;
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

        List<INode> nodes=new List<INode>();

        public Call (string callName)
        {
            this.callName = callName;
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


    }
}
