using IVR.prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.order
{
    interface IItem
    {
        Prompt GetPrompt();

    }
}
