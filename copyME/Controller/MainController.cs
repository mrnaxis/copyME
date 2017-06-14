using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyME.Controller
{
    class MainController
    {
        string origem { get; set; }
        string destino { get; set; }
        List<string> formatos { get; set; }

        public MainController() { this.formatos = new List<string>(); }
        public MainController(string origem, string destino)
        {
            this.formatos = new List<string>();
        }
    }
}
