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
    public partial class RankingSystem : MetroFramework.Forms.MetroForm
    {
        public RankingSystem()
        {
            InitializeComponent();
        }

        private void RankingSystem_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                metroProgressBar1.Value = i;
            }
        }
    }
}
