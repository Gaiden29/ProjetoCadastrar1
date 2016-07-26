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
    public partial class frmPesquisarProduto : Form
    {
        private TextBox txt_PesquisarProduto;
        private Button btn_PesquisarProduto;
        private Button btn_SairPesquisa;
        private Label label2;
        private Label label1;
    
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PesquisarProduto = new System.Windows.Forms.TextBox();
            this.btn_PesquisarProduto = new System.Windows.Forms.Button();
            this.btn_SairPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-343, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_PesquisarProduto
            // 
            this.txt_PesquisarProduto.Location = new System.Drawing.Point(75, 39);
            this.txt_PesquisarProduto.Name = "txt_PesquisarProduto";
            this.txt_PesquisarProduto.Size = new System.Drawing.Size(136, 20);
            this.txt_PesquisarProduto.TabIndex = 1;
            // 
            // btn_PesquisarProduto
            // 
            this.btn_PesquisarProduto.Location = new System.Drawing.Point(37, 82);
            this.btn_PesquisarProduto.Name = "btn_PesquisarProduto";
            this.btn_PesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_PesquisarProduto.TabIndex = 2;
            this.btn_PesquisarProduto.Text = "Pesquisar";
            this.btn_PesquisarProduto.UseVisualStyleBackColor = true;
            this.btn_PesquisarProduto.Click += new System.EventHandler(this.btn_PesquisarProduto_Click);
            // 
            // btn_SairPesquisa
            // 
            this.btn_SairPesquisa.Location = new System.Drawing.Point(136, 82);
            this.btn_SairPesquisa.Name = "btn_SairPesquisa";
            this.btn_SairPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_SairPesquisa.TabIndex = 3;
            this.btn_SairPesquisa.Text = "Sair";
            this.btn_SairPesquisa.UseVisualStyleBackColor = true;
            this.btn_SairPesquisa.Click += new System.EventHandler(this.btn_SairPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPesquisarProduto
            // 
            this.ClientSize = new System.Drawing.Size(250, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SairPesquisa);
            this.Controls.Add(this.btn_PesquisarProduto);
            this.Controls.Add(this.txt_PesquisarProduto);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisarProduto";
            this.Load += new System.EventHandler(this.frmPesquisarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPesquisarProduto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_SairPesquisa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_PesquisarProduto_Click(object sender, EventArgs e)
        {
            int x;

            for (x = 0; x < frmPrincipal.indicePro; x++)
            {
                if (txt_PesquisarProduto.Text == frmPrincipal.descricaoPro[x])
                {
                    frmProduto.atual = x;
                    break;
                }
            }
            if (x == frmPrincipal.indicePro) 
            {
                MessageBox.Show("Nome não encontrado");
            }
            Close();
        }
    }
}
