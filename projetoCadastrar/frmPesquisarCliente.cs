using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoCadastrar
{
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
        }

        private void btn_PesquisarProduto_Click(object sender, EventArgs e)
        {
            int x;

            for (x = 0; x < frmPrincipal.indiceCliente; x++)
            {
                if (txt_PesquisarCliente.Text == frmPrincipal.nomeCliente[x])
                {
                    frmProduto.atual = x;
                    break;
                }
            }
            if (x == frmPrincipal.indiceCliente)
            {
                MessageBox.Show("Nome não encontrado");
            }
            Close();
        }
    }
}
