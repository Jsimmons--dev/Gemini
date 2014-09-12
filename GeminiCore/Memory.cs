using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeminiCore
{
    class Memory
    {
        List<string> instructions;
        int[] stack;

        public Memory(string path)
        {
            stack = new int[256];
        }
    }
}
