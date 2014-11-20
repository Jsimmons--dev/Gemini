using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class FetchArgs
    {
        public short pc = -1;
        public bool locked = false;

    public void setup(short pc)
        {
            this.pc = pc;
        }
    }
}
