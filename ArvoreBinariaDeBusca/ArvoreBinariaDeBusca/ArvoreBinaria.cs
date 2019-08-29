using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArvoreBinariaDeBusca
{
    public partial class ArvoreBinaria : Form
    {
        public ArvoreBinaria()
        {
            InitializeComponent();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var val = int.Parse(TxtBxValor.Text);

                /*if (_tree = null)
                {

                } */
            }
            catch (Exception ex)
            {

            }
        }
    }
}
