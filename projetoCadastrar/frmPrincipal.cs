using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace projetoCadastrar
{
    public partial class frmPrincipal : Form
    {
        public static int[] codigoPro = new int[10];
        public static string[] descricaoPro = new string[10];
        public static string[] unidadePro = new string[10];
        public static int[] qtdEstoquePro = new int[10];
        public static double[] custoPro = new double[10];
        public static double[] vendaPro = new double[10];

        public static int[] codigoCliente = new int[10];
        public static string[] nomeCliente = new string[10];
        public static string[] enderecoCliente = new string[10];
        public static string[] bairroCliente = new string[10];
        public static string[] cidadeCliente = new string[10];
        public static string[] estadoCliente = new string[10];
        public static string[] cepCliente = new string[10];
        public static string[] cpfCliente = new string[10];
        public static string[] telCliente = new string[10];

        public static int indicePro = 0, indiceCliente = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

       
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto fp = new frmProduto();
            fp.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x;
            FileStream fs = new FileStream(@"c:\cli.txt", FileMode.Append);
            BinaryWriter bw = new BinaryWriter(fs);

            FileStream pro = new FileStream(@"c:\pro.txt", FileMode.Append);
            BinaryWriter rd = new BinaryWriter(pro);

            if (indiceCliente > 0) 
            {
                for (x = 0; x < indiceCliente; x++) 
                {
                    bw.Write(codigoCliente[x]);
                    bw.Write(nomeCliente[x]);
                    bw.Write(enderecoCliente[x]);
                    bw.Write(bairroCliente[x]);
                    bw.Write(cidadeCliente[x]);
                    bw.Write(estadoCliente[x]);
                    bw.Write(cepCliente[x]);
                    bw.Write(cpfCliente[x]);
                    bw.Write(telCliente[x]);
                }
                bw.Flush();
                bw.Close();
            }

            if (indicePro > 0) 
            {
                for (x = 0; x < indicePro; x++) 
                {
                    rd.Write(codigoPro[x]);
                    rd.Write(descricaoPro[x]);
                    rd.Write(unidadePro[x]);
                    rd.Write(qtdEstoquePro[x]);
                    rd.Write(custoPro[x]);
                    rd.Write(vendaPro[x]); 
                }
                rd.Flush();
                rd.Close();
            }
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream cliente = new FileStream(@"c:\cli.txt", FileMode.Open);
 
            int cont = 0;

            BinaryReader reader = new BinaryReader(cliente);

            while (reader.PeekChar() > -1) 
            {
                codigoCliente[cont] = reader.ReadInt32();
                nomeCliente[cont] = reader.ReadString();
                enderecoCliente[cont] = reader.ReadString();
                bairroCliente[cont] = reader.ReadString();
                cidadeCliente[cont] = reader.ReadString();
                estadoCliente[cont] = reader.ReadString();
                cepCliente[cont] = reader.ReadString();
                cpfCliente[cont] = reader.ReadString();
                telCliente[cont] = reader.ReadString();

                cont++;

            }

            reader.Close();

            FileStream produto = new FileStream(@"c:\pro.txt", FileMode.Open);

            int cont1 = 0;

            BinaryReader leitor = new BinaryReader(produto);

            while (leitor.PeekChar() > -1) 
            {
                codigoPro[cont1] = leitor.ReadInt32();
                descricaoPro[cont1] = leitor.ReadString();
                unidadePro[cont1] = leitor.ReadString();
                qtdEstoquePro[cont1] = leitor.ReadInt32();
                custoPro[cont1] = leitor.ReadDouble();
                vendaPro[cont1] = leitor.ReadDouble();

                cont1++;
            }

            leitor.Close();


        }
    }
}
