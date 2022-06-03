using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.IO;
using System.Web.Helpers;
using Microsoft.Ajax.Utilities;

namespace SistemaCadastro
{
    public partial class frmCadastrar : MetroFramework.Forms.MetroForm
    {
        public class Movie
        {
            public string Name { get; set; }
            public int Year { get; set; }
        }

        bool VerSenhaTxt = false;
        //char Arroba = "@";
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txt_Senha.Text = "";
            txtRepitaSenha.Text = "";
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Email = txtEmail.Text;
            p.Senha = txtRepitaSenha.Text;
            p.RepitaSenha = txtRepitaSenha.Text;

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email");
                txtEmail.Focus();
                return;
            }
            //if(txtEmail.Contains("a"))
            //{ 
            //    MessageBox.Show("Email contêm @ ");
            //    txtEmail.Focus();
            //    return;
            //}
            //else
            //{                
            //    MessageBox.Show("Preencha o campo Email");
            //    txtEmail.Focus();
            //    return;
            //}            
            if (txt_Senha.Text == "")
            {
                MessageBox.Show("Preencha o campo Senha");
                txt_Senha.Focus();
                return;
            }

            if (txtRepitaSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo Repita a Senha");
                txt_Senha.Focus();
                return;
            }
            
            if (txt_Senha.Text == txtRepitaSenha.Text)
            {
                MessageBox.Show("Senha confere!!!");
                frmLogin f = new frmLogin(txtEmail.Text, txt_Senha.Text);
                this.Hide();
                f.ShowDialog();
                return;
            }           
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if (Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" | Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };

            using (StreamWriter file = File.CreateText(@"C:\teste\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string fileName = @"C:\teste\movie.json";
            string jsonString = File.ReadAllText(fileName);
            Movie movie = JsonSerializer.Deserialize<Movie>(jsonString)!;


            label4.Text = jsonString;
        }
    }
    public class ChecaForcaSenha
        {

          public enum ForcaDaSenha
          {
              Inaceitavel,
              Fraca,
              Aceitavel,
              Forte,
            Segura
         }

          public int geraPontosSenha(string senha)
         {
            if (senha == null) return 0;
           int pontosPorTamanho = GetPontoPorTamanho(senha);
              int pontosPorMinusculas = GetPontoPorMinusculas(senha);
             int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
             int pontosPorDigitos = GetPontoPorDigitos(senha);
             int pontosPorSimbolos = GetPontoPorSimbolos(senha);
              int pontosPorRepeticao = GetPontoPorRepeticao(senha);
              return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
          }

          private int GetPontoPorTamanho(string senha)
          {
              return Math.Min(10, senha.Length) * 7;
          }

          private int GetPontoPorMinusculas(string senha)
          {
              int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
              return Math.Min(2, rawplacar) * 5;
          }

          private int GetPontoPorMaiusculas(string senha)
          {
              int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
              return Math.Min(2, rawplacar) * 5;
          }

          private int GetPontoPorDigitos(string senha)
          {
              int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
              return Math.Min(2, rawplacar) * 6;
          }

          private int GetPontoPorSimbolos(string senha)
          {
              int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
              return Math.Min(2, rawplacar) * 5;
          }

          private int GetPontoPorRepeticao(string senha)
          {
              System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
              bool repete = regex.IsMatch(senha);
              if (repete)
              {
                  return 30;
              }
              else
              {
                  return 0;
              }
          }

          public ForcaDaSenha GetForcaDaSenha(string senha)
          {
              int placar = geraPontosSenha(senha);

              if (placar < 50)
                  return ForcaDaSenha.Inaceitavel;
              else if (placar < 60)
                  return ForcaDaSenha.Fraca;
              else if (placar < 80)
                  return ForcaDaSenha.Aceitavel;
              else if (placar < 100)
                  return ForcaDaSenha.Forte;
              else
                  return ForcaDaSenha.Segura;
          }
        }  
}
