using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copyME
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Herp Derp... SRYLY!
        /// </summary>
        [STAThread] //Chamada de COM com o OS para permitir o uso de dialogos... cute...
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmInicial());
        }
    }
}
