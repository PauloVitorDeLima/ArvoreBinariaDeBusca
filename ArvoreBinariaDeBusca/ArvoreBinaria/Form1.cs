using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArvoreBinaria
{
    public partial class Form1 : Form
    {
        private Arvore arvore = new Arvore();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                arvore.insere(int.Parse(TxtBxValor.Text));
                RichTxtBxArvore.AppendText("Inserido: " + TxtBxValor.Text +" \n");
            }catch (Exception ex)
            {
                MessageBox.Show("Valor Invalido! Digite apenas números");
            }
            TxtBxValor.Clear();
            TxtBxValor.Focus();
        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            RichTxtBxArvore.Clear();
            RichTxtBxArvore.AppendText(arvore.listagemEmOrdem());
        }

        private void BtListarPreOrdem_Click(object sender, EventArgs e)
        {
            RichTxtBxArvore.Clear();
            RichTxtBxArvore.AppendText(arvore.listagemPreOrdem());
        }

        private void BtListarPosOrdem_Click(object sender, EventArgs e)
        {
            RichTxtBxArvore.Clear();
            RichTxtBxArvore.AppendText(arvore.listagemPosOrdem());
        }
    }
}
