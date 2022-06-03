using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SistemaCadastro
{
    public partial class CadastrarRanking : MetroFramework.Forms.MetroForm
    {        
        public struct sProduto
        {
            public int Codigo;
            public string Nome;
            public int Valor;
        }

        ArrayList ArlListaProdutos = new ArrayList();
        
        public CadastrarRanking()
        {
            InitializeComponent();
        }
        public CadastrarRanking(string txtTitulo, string txtData)
        {
            InitializeComponent();
            txtTitulo2.Focus();
            txtTitulo2.Text = txtTitulo;   
            txtData2.Text = txtData;
            checkAtivo2.Checked = true;         
            checkAmigos.Checked = true;
            txtCodigoRanking.Text = (1).ToString();
            txtValorRanking.Text = (5).ToString();
            Calcular();
        }

        private void btnFecharCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravarRanking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoRanking.Text))
            {
                MessageBox.Show("Erro ao gravar Registro, Campo Código Inválido");
                return;
            }
            sProduto sProd = new sProduto();

            sProd.Codigo = int.Parse(txtCodigoRanking.Text);
            sProd.Nome = txtNomeRanking.Text;
            sProd.Valor = int.Parse(txtValorRanking.Text);

            ArlListaProdutos.Add(sProd);
            MessageBox.Show("Registro gravado com sucesso", "Gravado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListarRanking_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
            for (int i = 0; i < ArlListaProdutos.Count; i++)
            {
                dgvDados.Rows.Add(((sProduto)ArlListaProdutos[i]).Codigo.ToString(), ((sProduto)ArlListaProdutos[i]).Nome, ((sProduto)ArlListaProdutos[i]).Valor);
            }
        }

        private void btnInserirRanking_Click(object sender, EventArgs e)
        {
            LimparRegistro();
            txtCodigoRanking.Text = (ArlListaProdutos.Count + 1).ToString();
            //txtValorRanking.Text = (ArlListaProdutos.Count - 1).ToString();
            txtNomeRanking.Focus();
        }
        private void LimparRegistro()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
        }
        public void Calcular()
        {
            label5.Text = txtData2.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmCadastrarRanking2 f = new frmCadastrarRanking2(txtTitulo2.Text);
            //this.Hide();
            f.ShowDialog();

        }

        private void CadastrarRanking_Load(object sender, EventArgs e)
        {

        }
    }
}
    
