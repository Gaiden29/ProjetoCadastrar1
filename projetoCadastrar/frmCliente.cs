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
    public partial class frmCliente : Form
    {
        int atual = 0;
        int tipo;

        public void mostra()
        {
            txtCodigoCliente.Text = frmPrincipal.codigoCliente[atual].ToString();
            txtNomeCliente.Text = frmPrincipal.nomeCliente[atual];
            txtEnderecoCliente.Text = frmPrincipal.enderecoCliente[atual];
            txtBairroCliente.Text = frmPrincipal.bairroCliente[atual];
            txtCidadeCliente.Text = frmPrincipal.cidadeCliente[atual];
            txtEstadoCliente.Text = frmPrincipal.estadoCliente[atual];
            txtCepCliente.Text = frmPrincipal.cepCliente[atual];
            txtCPFCliente.Text = frmPrincipal.cpfCliente[atual];
            txtTelCliente.Text = frmPrincipal.telCliente[atual];
        }
        public void desablitar()
        {
            txtCodigoCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtEnderecoCliente.Enabled = false;
            txtBairroCliente.Enabled = false;
            txtCidadeCliente.Enabled = false;
            txtEstadoCliente.Enabled = false;
            txtCepCliente.Enabled = false;
            txtCPFCliente.Enabled = false;
            txtTelCliente.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisa.Enabled = true;
            btnProximo.Enabled = true;
            btnSair.Enabled = true;
            btnImprimir.Enabled = true;
            btnPesquisa.Enabled = true;
            btnAnterior.Enabled = true;
            btnExcluir.Enabled = true;
        }
        public void habilitar()
        {
            txtCodigoCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtEnderecoCliente.Enabled = true;
            txtBairroCliente.Enabled = true;
            txtCidadeCliente.Enabled = true;
            txtEstadoCliente.Enabled = true;
            txtCepCliente.Enabled = true;
            txtCPFCliente.Enabled = true;
            txtTelCliente.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisa.Enabled = false;
            btnProximo.Enabled = false;
            btnSair.Enabled = false;
            btnImprimir.Enabled = false;
            btnPesquisa.Enabled = false;
            btnAnterior.Enabled = false;
            btnExcluir.Enabled = false;

        }
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                mostra();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < 9)
            {
                atual++;
                mostra();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            atual = 0;
            desablitar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            if (frmPrincipal.indiceCliente < 10)
            {
                
                habilitar();
                tipo = 0;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.indiceCliente > 10)
            {
                habilitar();
                tipo = 1;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmPrincipal.nomeCliente[atual] = " ";
            frmPrincipal.enderecoCliente[atual] = " ";
            frmPrincipal.bairroCliente[atual] = " ";
            frmPrincipal.cidadeCliente[atual] = " ";
            frmPrincipal.cepCliente[atual] = " ";
            frmPrincipal.estadoCliente[atual] = " ";
            frmPrincipal.cpfCliente[atual] = " ";
            frmPrincipal.telCliente[atual] = " ";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desablitar();
            if (tipo == 0)
            {
                frmPrincipal.codigoCliente[atual] = frmPrincipal.indiceCliente + 1;
                frmPrincipal.nomeCliente[atual] = txtNomeCliente.Text;
                frmPrincipal.enderecoCliente[atual] = txtEnderecoCliente.Text;
                frmPrincipal.bairroCliente[atual] = txtBairroCliente.Text;
                frmPrincipal.cidadeCliente[atual] = txtCidadeCliente.Text;
                frmPrincipal.estadoCliente[atual] = txtEstadoCliente.Text;
                frmPrincipal.cepCliente[atual] = txtCepCliente.Text;
                frmPrincipal.cpfCliente[atual] = txtCPFCliente.Text;
                frmPrincipal.telCliente[atual] = txtTelCliente.Text;
                atual = frmPrincipal.indiceCliente;
                frmPrincipal.indiceCliente++;
            }
            else
            {
                frmPrincipal.nomeCliente[atual] = txtNomeCliente.Text;
                frmPrincipal.enderecoCliente[atual] = txtEnderecoCliente.Text;
                frmPrincipal.bairroCliente[atual] = txtBairroCliente.Text;
                frmPrincipal.cidadeCliente[atual] = txtCidadeCliente.Text;
                frmPrincipal.estadoCliente[atual] = txtEstadoCliente.Text;
                frmPrincipal.cepCliente[atual] = txtCepCliente.Text;
                frmPrincipal.cpfCliente[atual] = txtCPFCliente.Text;
                frmPrincipal.telCliente[atual] = txtTelCliente.Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desablitar();
            mostra();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisarCliente fpc = new frmPesquisarCliente();
            fpc.ShowDialog();
            mostra();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics objImpressao = e.Graphics;
            string stvDados;

            stvDados = "Ficha de produto" + (char)10 + (char)10;
            stvDados = stvDados + "Código: " + txtCodigoCliente.Text + (char)10;
            stvDados = stvDados + "Nome: " + txtNomeCliente.Text + (char)10;
            stvDados = stvDados + "Endereço: " + txtEnderecoCliente.Text + (char)10;
            stvDados = stvDados + "Bairro: " + txtBairroCliente.Text + (char)10;
            stvDados = stvDados + "Cidade: " + txtCidadeCliente.Text + (char)10;
            stvDados = stvDados + "Estado: " + txtEstadoCliente.Text + (char)10;
            stvDados = stvDados + "CEP: " + txtCepCliente.Text + (char)10;
            stvDados = stvDados + "CPF: " + txtCPFCliente.Text + (char)10;
            stvDados = stvDados + "Telefone: " + txtTelCliente.Text;
            

            objImpressao.DrawString(stvDados, new System.Drawing.Font("Arial", 12, FontStyle.Italic), Brushes.DarkGray, 50, 50);
        }


       
    }
}
