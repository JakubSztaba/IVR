using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    class ConfirmationNode : Node
    {
        private string message;
        private int confirmationNumber;
        private INode notConfirmedNode;
        public ConfirmationNode(string nodeName, string message, Call callOwner, int confirmationNumber) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
            this.confirmationNumber = confirmationNumber;
        }

        protected override void OnEntry()
        {
            Console.WriteLine(message);

        }

        public void SetNotConfirmedNode(INode notConfirmedNode)
        {
            this.notConfirmedNode = notConfirmedNode;
        }

        public override void OnKeyboard(char input)
        {
            int i = (input - '0');

            if (i == confirmationNumber)
            {
                Finish();
            }
            else
            {
                Finish(notConfirmedNode.GetNodeName());
            }

        }
    }
}
