﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    class EndNode : Node
    {
        private string message;
        public EndNode(string nodeName, string message, Call callOwner) : base(nodeName, callOwner)
        {
            this.nodeName = nodeName;
            this.callOwner = callOwner;
            this.message = message;
        }

        protected override void OnEntry()
        {
            Console.WriteLine(message);         
        }

        public override void OnKeyboard(char input)
        {
            
        }

    }
}
