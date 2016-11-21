using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    abstract class Node : INode
    {
        protected string nodeName;
        protected Call callOwner;
        protected PromptPlayer player = new PromptPlayer();


        private List<INode> children = new List<INode>();

        public Node (string nodeName, Call callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            callOwner.AddNode(this);
          
        }

        public Node(string nodeName, Call callOwner, Prompt prompt)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            callOwner.AddNode(this);
            player.SetPrompt(prompt);

        }
        public string GetNodeName()
        {
            return nodeName;
        }
        public void AddChild(INode child)
        {
            this.children.Add(child);
        }
        public void AddChild(List<INode> children)
        {
            this.children.AddRange(children);
        }
        public List<INode> GetChildren()
        {
            return children;
        }       
        public void Entry()
        {
            Console.WriteLine(nodeName);
            
            OnEntry();
        }
        protected abstract void OnEntry();
        public abstract void OnKeyboard(char input);
        protected void Finish(string nodeOutputName)
        {
            callOwner.OnFinishNode(nodeOutputName);
        }
        protected void Finish()
        {
            if (children.Count() != 1)
            {
                Console.WriteLine("cos sie popsulo");

            }else
            callOwner.OnFinishNode((children.First()).GetNodeName());
        }




    }
}
