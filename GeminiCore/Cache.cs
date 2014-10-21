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
    public class Cache
    {
        public FrameSet[] cache = new FrameSet[Memory.cacheSize / Memory.frameSetSize];

        public override string ToString()
        {
            string cacheConcat = "";
            for(int i = 0;i<Memory.cacheSize/Memory.frameSetSize;i++)
            {
                cacheConcat += cache[i];
            }
            return cacheConcat;
        }

        public FrameSet this[int ind]
        {
            get
            {
                return cache[ind];
            }
            set
            {
                cache[ind] = value;
            }
        }
    }
}
