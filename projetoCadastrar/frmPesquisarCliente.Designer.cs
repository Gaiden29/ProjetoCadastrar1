namespace projetoCadastrar
{
    partial class frmPesquisarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SairPesquisa = new System.Windows.Forms.Button();
            this.btn_PesquisarCliente = new System.Windows.Forms.Button();
            this.txt_PesquisarCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // btn_SairPesquisa
            // 
            this.btn_SairPesquisa.Location = new System.Drawing.Point(141, 101);
            this.btn_SairPesquisa.Name = "btn_SairPesquisa";
            this.btn_SairPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_SairPesquisa.TabIndex = 7;
            this.btn_SairPesquisa.Text = "Sair";
            this.btn_SairPesquisa.UseVisualStyleBackColor = true;
            // 
            // btn_PesquisarCliente
            // 
            this.btn_PesquisarCliente.Location = new System.Drawing.Point(42, 101);
            this.btn_PesquisarCliente.Name = "btn_PesquisarCliente";
            this.btn_PesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_PesquisarCliente.TabIndex = 6;
            this.btn_PesquisarCliente.Text = "Pesquisar";
            this.btn_PesquisarCliente.UseVisualStyleBackColor = true;
            this.btn_PesquisarCliente.Click += new System.EventHandler(this.btn_PesquisarProduto_Click);
            // 
            // txt_PesquisarCliente
            // 
            this.txt_PesquisarCliente.Location = new System.Drawing.Point(80, 58);
            this.txt_PesquisarCliente.Name = "txt_PesquisarCliente";
            this.txt_PesquisarCliente.Size = new System.Drawing.Size(136, 20);
            this.txt_PesquisarCliente.TabIndex = 5;
            // 
            // frmPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SairPesquisa);
            this.Controls.Add(this.btn_PesquisarCliente);
            this.Controls.Add(this.txt_PesquisarCliente);
            this.Name = "frmPesquisarCliente";
            this.Text = "frmPesquisarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SairPesquisa;
        private System.Windows.Forms.Button btn_PesquisarCliente;
        private System.Windows.Forms.TextBox txt_PesquisarCliente;
    }
}