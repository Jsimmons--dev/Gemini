using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class FrameSet
    {
        public Frame[] frames = new Frame[Memory.frameSetSize];
       
        public FrameSet()
        {
            for(int i = 0;i<Memory.frameSetSize;i++)
            {
                frames[i] = new Frame();
            }
        }

    public override string ToString()
    {
        string concatFrames = "";
        for(int i = 0;i<Memory.frameSetSize;i++)
        {
            concatFrames += frames[i] + "\n";
        }
        return concatFrames;
    }
    }
}
