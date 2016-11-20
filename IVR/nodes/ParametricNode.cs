using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    class ParametricNode : Node
    {
        private string message;
        List<int> range;
        Action<int> action;
        public ParametricNode(string nodeName, string message, Call callOwner, List<int> range, Action<int> action ) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
            this.range = range;
            this.action = action;
        }

        protected override void OnEntry()
        {
            Console.WriteLine(message);

        }

        public override void OnKeyboard(char input)
        {
            int i = (input - '0');

            
            if (range.Contains(i))
            {
                //tutaj magia
                Finish();
            }
            else
            {
                Console.WriteLine("niepoprawny parametr");
                Finish(this.GetNodeName());
            }
        }
    }
}
