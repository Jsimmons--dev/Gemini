/*
Joshua Simmons and Shane Hafycz
*/
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeminiCore
{
    public class Memory
    {
        #region MEMORY_VARS : 
        public int cacheReadHit = 0;
        public int cacheReadMiss = 0;
        public int cacheWriteHit = 0;
        public int cacheWriteMiss = 0;
        public static int cacheSize = 8;
        public static int blockSize = 2;
        public static int frameSetSize = 1;
        public static int memSize = 256;
        public List<short> instructions;
        public short[] stack;
        public Cache cache = new Cache();
        #endregion
        public void resetInstructions()
        {
            instructions.Clear();
        }

        public Memory()
        {
            stack = new short[memSize];
            for (int i = 0; i < cacheSize / frameSetSize; i++)
            {
                cache[i] = new FrameSet();
            }
        }

        public short this[short address]
        {
            get
            {
                int setNum = getSetNum(address);
                int frameNum = searchForBlk(setNum, address);
                //cache read hit policy
                if (frameNum != -1)
                {
                    cacheReadHit++;
                    short inCache = cache[setNum].frames[frameNum].data[address % blockSize];
                    return inCache;
                }
                //cache read miss poilcy
                else
                {
                    cacheReadMiss++;
                    short val = loadMemBlk(setNum, address);
                    return val;
                }
            }
            set
            {
                int setNum = getSetNum(address);
                int frameNum = searchForBlk(setNum, address);
                //cache write hit policy
                if (frameNum != -1)
                {
                    cacheWriteHit++;
                    overwriteCache(setNum, frameNum, address, value);
                }
                //cache write miss policy
                else
                {
                    cacheWriteMiss++;
                    stack[address] = value;
                }
            }
        }

        public short loadMemBlk(int setNum, short address)
        {
            int blkNum = getBlkNum(address);
            Frame newFrame = new Frame();
            newFrame.dirtyBit = false;
            newFrame.tag = blkNum;
            for (int i = 0; i < blockSize; i++)
            {
                newFrame.data[i] = stack[blkNum * blockSize + i];
            }
            int emptySpot = lookForEmptySpot(setNum);
            //if there's an empty spot
            if (emptySpot != -1)
            {
                cache[setNum].frames[emptySpot] = newFrame;
                return newFrame.data[address % blockSize];
            }
            //no free spot
            else
            {
                return randomReplace(setNum, newFrame, address);
            }
        }

        public short randomReplace(int setNum, Frame newFrame, short address)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(frameSetSize);
            Frame replaceable = cache[setNum].frames[randNum];
            if (replaceable.dirtyBit)
            {
                writeToMem(replaceable, address);
            }
            cache[setNum].frames[randNum] = newFrame;
            return newFrame.data[address % blockSize];
        }

        public void writeToMem(Frame replaceable, short address)
        {
            for (int i = 0; i < blockSize; i++)
            {
                stack[(address - address % blockSize) + i] = replaceable.data[i];
            }
        }

        public int lookForEmptySpot(int setNum)
        {
            for (int i = 0; i < frameSetSize; i++)
            {
                if (cache[setNum].frames[i].tag == -1)
                    return i;
            }
            return -1;
        }

        public void overwriteCache(int setNum, int frameNum, short address, short value)
        {
            Frame current = cache[setNum].frames[frameNum];
            current.data[address % blockSize] = value;
            current.dirtyBit = true;

        }

        public int getSetNum(short address)
        {
            return getBlkNum(address) % (cacheSize/frameSetSize);
        }

        public int searchForBlk(int setNum, short address)
        {
            int blkNum = getBlkNum(address);
            for (int i = 0; i < frameSetSize; i++)
                if (cache[setNum].frames[i].tag == blkNum)
                    return i;
            return -1;
        }

        public int getBlkNum(short address)
        {
            return (address - address % blockSize) / blockSize;
        }
    }
}
