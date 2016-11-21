using IVR.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IVR.prompts
{
    public class Prompt
    {


        
        string BasePath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName, @"Waves\");        
        public string path;

        public Prompt(string path_)
        {
            path = BasePath + path_;
        }
    }
}