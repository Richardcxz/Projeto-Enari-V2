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
    public partial class frm_Sistema : MetroFramework.Forms.MetroForm
    {
        public frm_Sistema()
        {
            InitializeComponent();
        }

        private void metroLabel1_MouseHover(object sender, EventArgs e)
        {
            metroLabel1.Text = "Bem Vindo ao nosso Sistema \n Você já está cadastrado?";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmCadastrar f = new frmCadastrar();
            this.Hide();
            f.ShowDialog();
        }

        private void frm_Sistema_Load(object sender, EventArgs e)
        {

        }
    }   
}
