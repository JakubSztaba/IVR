using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    class ChoiceNode : Node
    {
        private string message; 
        public ChoiceNode(string nodeName, string message, Call callOwner) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
        }

        public ChoiceNode(string nodeName, string message, Call callOwner, prompts.Prompt prompt) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
            player.SetPrompt(prompt);
        }

        protected override void OnEntry()
        {
            Console.WriteLine(message);
           
        }

        public override void OnKeyboard(char input)
        {
            int i = (input - '0');
           

            if (i < 1 || i > this.GetChildren().Count())
            {
                Console.WriteLine("podano nieporpawn znak sporboj jeszcze raz");
                Finish(this.GetNodeName());
            }
            else
            {
                Finish(GetChildren()[i-1].GetNodeName());
            }
        }
    }
}
