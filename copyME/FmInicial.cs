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
    public partial class FmInicial : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public FmInicial()
        {
            InitializeComponent();
            fbd.Description = "Selecione o arquivo de ";
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCamOrigem.Text))
                MessageBox.Show("Selecione um caminho de Origem", "Hum...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(string.IsNullOrEmpty(txCamDestino.Text))
                MessageBox.Show("Selecione um caminho de destino", "Hum...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                FmMain fm = new FmMain(txCamOrigem.Text, txCamDestino.Text);
                fm.Show();
            }
        }

        private void btDirOrigem_Click(object sender, EventArgs e)
        {
            AbrirDialogo("Origem", txCamOrigem);
        }

        private void btDirDestino_Click(object sender, EventArgs e)
        {
            AbrirDialogo("Destino", txCamDestino);
        }

        private bool AbrirDialogo(string finalDesc, TextBox textBoxDestino)
        {
            try
            {
                fbd.Description = string.Concat(fbd.Description, finalDesc);
                if (fbd.ShowDialog() == DialogResult.OK)
                    textBoxDestino.Text = fbd.SelectedPath;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Erro durante acesso aos diretórios. Mensagem: ", ex.Message), "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
