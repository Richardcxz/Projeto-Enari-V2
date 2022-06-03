using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class frmCadastrarRanking2 : MetroFramework.Forms.MetroForm
    {
        public frmCadastrarRanking2()
        {
            InitializeComponent();
        }

        public frmCadastrarRanking2(string txtTitulo2)
        {
            InitializeComponent();
            txtTitulo3.Text = txtTitulo2;
            comboBox1.Text = txtTitulo2;
        }

        private void frmCadastrarRanking2_Load(object sender, EventArgs e)
        {

        }
    }
}
