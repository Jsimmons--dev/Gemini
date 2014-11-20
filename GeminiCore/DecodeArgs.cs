using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class DecodeArgs
    {
        public short mdr;
        public bool locked = false;
        public short decodePC = -1;

        public void setup(short mdr)
        {
            this.mdr = mdr;
        }
    }
}
