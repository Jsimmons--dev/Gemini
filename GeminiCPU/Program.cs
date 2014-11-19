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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Window(cpu);
            Application.Run(window);
        }
    }
}
