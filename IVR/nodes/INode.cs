using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.nodes
{
    interface INode : IEventHandler
    {
          void AddChild(INode childNode);
          List<INode> GetChildren();
          void Entry();
          string GetNodeName();

    }
}
