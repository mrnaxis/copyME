using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copyME
{
    public partial class FmMain : Form
    {
        string origem { get; set; }
        string destino { get; set; }

        public FmMain(string origem, string destino)
        {
            this.origem = origem;
            this.destino = destino;
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
