using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class WritebackArgs
    {
        public short temp;
        public short wb;

        public void setup(short temp,short wb)
        {
            this.temp = temp;
            this.wb = wb;
        }
    }
}
