using System;
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
            cpu.engine.Assemble();
            cpu.fillMem();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Window(cpu);
            window.setUpFirstIns();
            Application.Run(window);

        }


     
    }
}
