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
    public partial class frmProduto : Form
    {
        public static int atual = 0;
        int tipo;
        public void mostra()
        {
            txtCodigoProduto.Text = frmPrincipal.codigoPro[atual].ToString();
            txtDescricaoProduto.Text = frmPrincipal.descricaoPro[atual];
            txtUnidadeProduto.Text = frmPrincipal.unidadePro[atual];
            txtQtEstoque.Text = frmPrincipal.qtdEstoquePro[atual].ToString();
            txtPrecoCusto.Text = frmPrincipal.custoPro[atual].ToString();
            txtPrecoVenda.Text = frmPrincipal.vendaPro[atual].ToString(); 
        }
        public void desablitar()
        {
            txtCodigoProduto.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtQtEstoque.Enabled = false;
            txtUnidadeProduto.Enabled = false;
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
            txtCodigoProduto.Enabled = false;
            txtDescricaoProduto.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtQtEstoque.Enabled = true;
            txtUnidadeProduto.Enabled = true;
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
        public frmProduto()
        {
            InitializeComponent();
        }

        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            atual = 0;
            desablitar();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.indicePro < 10)
            {
                txtDescricaoProduto.Text = "";
                txtUnidadeProduto.Text = "";
                txtQtEstoque.Text = "0";
                txtPrecoCusto.Text = "0";
                txtPrecoVenda.Text = "0";
                habilitar();
                tipo = 0;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.indicePro > 10)
            {
                habilitar();
                tipo = 1;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmPrincipal.descricaoPro[atual] = "";
            frmPrincipal.unidadePro[atual] = " ";
            frmPrincipal.qtdEstoquePro[atual] = 0;
            frmPrincipal.custoPro[atual] = 0;
            frmPrincipal.vendaPro[atual] = 0;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desablitar();
            if (tipo == 0)
            {
                frmPrincipal.codigoPro[frmPrincipal.indicePro] = frmPrincipal.indicePro + 1;
                frmPrincipal.descricaoPro[frmPrincipal.indicePro] = txtDescricaoProduto.Text;
                frmPrincipal.unidadePro[frmPrincipal.indicePro] = txtUnidadeProduto.Text;
                frmPrincipal.qtdEstoquePro[frmPrincipal.indicePro] = int.Parse(txtQtEstoque.Text);
                frmPrincipal.custoPro[frmPrincipal.indicePro] = double.Parse(txtPrecoCusto.Text);
                frmPrincipal.vendaPro[frmPrincipal.indicePro] = double.Parse(txtPrecoVenda.Text);
                atual = frmPrincipal.indicePro;
                frmPrincipal.indicePro++;
            }
            else
            {
                frmPrincipal.descricaoPro[atual] = txtDescricaoProduto.Text;
                frmPrincipal.unidadePro[atual] = txtUnidadeProduto.Text;
                frmPrincipal.qtdEstoquePro[atual] = int.Parse(txtQtEstoque.Text);
                frmPrincipal.custoPro[atual] = double.Parse(txtPrecoCusto.Text);
                frmPrincipal.vendaPro[atual] = double.Parse(txtPrecoVenda.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desablitar();
            mostra();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisarProduto fpp = new frmPesquisarProduto();
            fpp.ShowDialog();
            mostra();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string stvDados;

            stvDados = "Ficha de produto" + (char)10 + (char)10;
            stvDados = stvDados + "Código: " + txtCodigoProduto.Text + (char)10;
            stvDados = stvDados + "Descrição: " + txtDescricaoProduto.Text + (char)10;
            stvDados = stvDados + "Unidade: " + txtUnidadeProduto.Text + (char)10;
            stvDados = stvDados + "Quantidade de estoque: " + txtQtEstoque.Text + (char)10;
            stvDados = stvDados + "Preço de custo: " + txtPrecoCusto.Text + (char)10;
            stvDados = stvDados + "Preço de venda: " + txtPrecoVenda.Text;

            objImpressao.DrawString(stvDados, new System.Drawing.Font("Arial", 12, FontStyle.Italic), Brushes.DarkGray,50,50);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
