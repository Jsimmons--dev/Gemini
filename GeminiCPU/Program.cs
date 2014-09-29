/*
Joshua Simmons and Shane Hafycz
*/
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeminiCore;
namespace GeminiCPU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Window window;

        [STAThread]
        static void Main()
        {
            CPU cpu = new CPU();
            /*
                cpu.engine.Assemble("../../test1.s", "test1.out");
                cpu.engine.Assemble("../../test2.s", "test2.out"); //cannot have an out due to syntax error
                cpu.engine.Assemble("../../test3.s", "test3.out");
                cpu.engine.Assemble("../../test4.s", "test4.out"); //cannot have an out due to segfault
                cpu.engine.Assemble("../../test5.s","test5.out");
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Window(cpu);
            Application.Run(window);

        }



    }
}
