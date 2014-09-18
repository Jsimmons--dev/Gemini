using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeminiCore
{
    public class Memory
    {
        public List<short> instructions;
        public int[] stack;

        public Memory()
        {
            stack = new int[256];
        }
    }
}
