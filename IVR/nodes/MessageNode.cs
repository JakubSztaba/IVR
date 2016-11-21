using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    class MessageNode : Node
    {

        private string message;
        
        public MessageNode (string nodeName,string message, Call callOwner) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
        }

        public MessageNode(string nodeName, string message, Call callOwner, Prompt prompt) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
            player.SetPrompt(prompt);


        }

        protected override void OnEntry()
        {
            Console.WriteLine(message);
            player.Play();
           

        
        }

        public override void OnKeyboard(char input)
        {

            player.Stop();
            Finish();
        }

    }

}
