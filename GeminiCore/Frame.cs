/*
 Joshua Simmons and Shane Hayfcz
*/﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class Frame
    {
        public short[] data = new short[Memory.blockSize];
        public int tag = -1;
        public bool dirtyBit = false;

    public override string ToString()
    {
        string dataString = "data:";
        for (int i = 0; i < Memory.blockSize;i++ )
        {
            dataString += " " + data[i];
        }
        dataString += " tag:" + tag;
        dataString += " dirty:"+dirtyBit;
        return dataString;
    }
    }
}
