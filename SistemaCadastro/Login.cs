using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        bool VerSenhaTxt = false;

        //public frmLogin(string txtEmail)
        public frmLogin()
        {
            InitializeComponent();            
        }
        public frmLogin(string txtEmail)
        {
            InitializeComponent();
            txtEmail2.Text = txtEmail;    
        }
        public frmLogin(string txtEmail, string txt_Senha)
        {
            InitializeComponent();
            txtEmail2.Focus();
            txtEmail2.Text = txtEmail;
            txt_Senha2.Text = txt_Senha;
            
        }

        //private Task ProcessData(List<string>list, IProgress<ProgressReport> progress)
        //{
        //    int index = 1;
        //    int totalProcess = list.Count;
        //    var progressReport = new ProgressReport();
        //    return Task.Run(() =>
        //    {
        //        for (int i = 0; i < totalProcess; i++)
        //        {
        //            progressReport.PercentComplete = index++ * 100 / totalProcess;
        //            progress.Report(progressReport);
        //            Thread.Sleep(10);
        //        }
        //    });
        // }

        private void button1_Click(object sender, EventArgs e)
        {          
            if(txtEmail2.Text == "")
            {
                MessageBox.Show("Preencha o campo Login");
                txtEmail2.Focus();
                return;
            }

            if (txt_Senha2.Text == "")
            {
                MessageBox.Show("Preencha o campo senha");
                txt_Senha2.Focus();
                return;
            }            
        }

        private void btnLimparLogin_Click(object sender, EventArgs e)
        {
            txtEmail2.Text = "";
            txt_Senha2.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar f = new frmCadastrar();
            //this.Hide();
            f.ShowDialog();            
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                txt_Senha2.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha2.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
        }

        private void btnEntrar(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        //private async void button1_Click_1(object sender, EventArgs e)
        //{
        //    List<string> list = new List<string>();
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        list.Add(i.ToString());
        //        lblStatus.Text = "Working...";
        //        var progress = new Progress<ProgressReport>();
        //        progress.ProgressChanged += (o, report) =>
        //        {
        //            lblStatus.Text = string.Format("Processing {0}%", report.PercentComplete);
        //            progressBar.Value = report.PercentComplete;
        //            progressBar.Update();
        //        };
        //        await ProcessData(list, progress);
        //        lblStatus.Text = "Concluído!";
        //   }
        //}
    }
}
