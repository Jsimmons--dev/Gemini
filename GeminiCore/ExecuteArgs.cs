using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class ExecuteArgs
    {
        public short op;
        public short acc;
        public short value;
        public short current;

        public void setup(short op,short acc,short value)
        {
            this.op = op;
            this.acc = acc;
            this.value = value;
        }
    }
}
