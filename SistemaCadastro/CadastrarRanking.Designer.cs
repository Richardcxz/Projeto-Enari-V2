namespace SistemaCadastro
{
    partial class CadastrarRanking
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtCodigoRanking = new MetroFramework.Controls.MetroTextBox();
            this.txtNomeRanking = new MetroFramework.Controls.MetroTextBox();
            this.txtValorRanking = new MetroFramework.Controls.MetroTextBox();
            this.btnGravarRanking = new MetroFramework.Controls.MetroButton();
            this.btnInserirRanking = new MetroFramework.Controls.MetroButton();
            this.btnFecharCadastro = new MetroFramework.Controls.MetroButton();
            this.btnListarRanking = new MetroFramework.Controls.MetroButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Classificação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData3 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo2 = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData2 = new System.Windows.Forms.DateTimePicker();
            this.checkAtivo2 = new System.Windows.Forms.CheckBox();
            this.checkAmigos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompartilhar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(21, 177);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(112, 21);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Classificação:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(21, 224);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(61, 21);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(370, 175);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(96, 21);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Pontuação:";
            // 
            // txtCodigoRanking
            // 
            // 
            // 
            // 
            this.txtCodigoRanking.CustomButton.Image = null;
            this.txtCodigoRanking.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.txtCodigoRanking.CustomButton.Name = "";
            this.txtCodigoRanking.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigoRanking.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoRanking.CustomButton.TabIndex = 1;
            this.txtCodigoRanking.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoRanking.CustomButton.UseSelectable = true;
            this.txtCodigoRanking.CustomButton.Visible = false;
            this.txtCodigoRanking.Lines = new string[0];
            this.txtCodigoRanking.Location = new System.Drawing.Point(177, 177);
            this.txtCodigoRanking.MaxLength = 32767;
            this.txtCodigoRanking.Name = "txtCodigoRanking";
            this.txtCodigoRanking.PasswordChar = '\0';
            this.txtCodigoRanking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoRanking.SelectedText = "";
            this.txtCodigoRanking.SelectionLength = 0;
            this.txtCodigoRanking.SelectionStart = 0;
            this.txtCodigoRanking.ShortcutsEnabled = true;
            this.txtCodigoRanking.Size = new System.Drawing.Size(46, 23);
            this.txtCodigoRanking.TabIndex = 2;
            this.txtCodigoRanking.UseSelectable = true;
            this.txtCodigoRanking.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoRanking.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNomeRanking
            // 
            // 
            // 
            // 
            this.txtNomeRanking.CustomButton.Image = null;
            this.txtNomeRanking.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtNomeRanking.CustomButton.Name = "";
            this.txtNomeRanking.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeRanking.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeRanking.CustomButton.TabIndex = 1;
            this.txtNomeRanking.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeRanking.CustomButton.UseSelectable = true;
            this.txtNomeRanking.CustomButton.Visible = false;
            this.txtNomeRanking.Lines = new string[0];
            this.txtNomeRanking.Location = new System.Drawing.Point(177, 224);
            this.txtNomeRanking.MaxLength = 32767;
            this.txtNomeRanking.Name = "txtNomeRanking";
            this.txtNomeRanking.PasswordChar = '\0';
            this.txtNomeRanking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeRanking.SelectedText = "";
            this.txtNomeRanking.SelectionLength = 0;
            this.txtNomeRanking.SelectionStart = 0;
            this.txtNomeRanking.ShortcutsEnabled = true;
            this.txtNomeRanking.Size = new System.Drawing.Size(189, 23);
            this.txtNomeRanking.TabIndex = 4;
            this.txtNomeRanking.UseSelectable = true;
            this.txtNomeRanking.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeRanking.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValorRanking
            // 
            // 
            // 
            // 
            this.txtValorRanking.CustomButton.Image = null;
            this.txtValorRanking.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.txtValorRanking.CustomButton.Name = "";
            this.txtValorRanking.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorRanking.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorRanking.CustomButton.TabIndex = 1;
            this.txtValorRanking.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorRanking.CustomButton.UseSelectable = true;
            this.txtValorRanking.CustomButton.Visible = false;
            this.txtValorRanking.Lines = new string[0];
            this.txtValorRanking.Location = new System.Drawing.Point(472, 175);
            this.txtValorRanking.MaxLength = 32767;
            this.txtValorRanking.Name = "txtValorRanking";
            this.txtValorRanking.PasswordChar = '\0';
            this.txtValorRanking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorRanking.SelectedText = "";
            this.txtValorRanking.SelectionLength = 0;
            this.txtValorRanking.SelectionStart = 0;
            this.txtValorRanking.ShortcutsEnabled = true;
            this.txtValorRanking.Size = new System.Drawing.Size(46, 23);
            this.txtValorRanking.TabIndex = 3;
            this.txtValorRanking.UseSelectable = true;
            this.txtValorRanking.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorRanking.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGravarRanking
            // 
            this.btnGravarRanking.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGravarRanking.Location = new System.Drawing.Point(27, 527);
            this.btnGravarRanking.Name = "btnGravarRanking";
            this.btnGravarRanking.Size = new System.Drawing.Size(80, 30);
            this.btnGravarRanking.TabIndex = 6;
            this.btnGravarRanking.Text = "Gravar";
            this.btnGravarRanking.UseSelectable = true;
            this.btnGravarRanking.Click += new System.EventHandler(this.btnGravarRanking_Click);
            // 
            // btnInserirRanking
            // 
            this.btnInserirRanking.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnInserirRanking.Location = new System.Drawing.Point(149, 527);
            this.btnInserirRanking.Name = "btnInserirRanking";
            this.btnInserirRanking.Size = new System.Drawing.Size(80, 30);
            this.btnInserirRanking.TabIndex = 7;
            this.btnInserirRanking.Text = "Inserir";
            this.btnInserirRanking.UseSelectable = true;
            this.btnInserirRanking.Click += new System.EventHandler(this.btnInserirRanking_Click);
            // 
            // btnFecharCadastro
            // 
            this.btnFecharCadastro.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFecharCadastro.Location = new System.Drawing.Point(271, 527);
            this.btnFecharCadastro.Name = "btnFecharCadastro";
            this.btnFecharCadastro.Size = new System.Drawing.Size(80, 30);
            this.btnFecharCadastro.TabIndex = 9;
            this.btnFecharCadastro.Text = "Fechar";
            this.btnFecharCadastro.UseSelectable = true;
            this.btnFecharCadastro.Click += new System.EventHandler(this.btnFecharCadastro_Click);
            // 
            // btnListarRanking
            // 
            this.btnListarRanking.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnListarRanking.Location = new System.Drawing.Point(393, 527);
            this.btnListarRanking.Name = "btnListarRanking";
            this.btnListarRanking.Size = new System.Drawing.Size(80, 30);
            this.btnListarRanking.TabIndex = 8;
            this.btnListarRanking.Text = "Listar";
            this.btnListarRanking.UseSelectable = true;
            this.btnListarRanking.Click += new System.EventHandler(this.btnListarRanking_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classificação,
            this.Nome,
            this.Valor});
            this.dgvDados.Location = new System.Drawing.Point(28, 366);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(490, 155);
            this.dgvDados.TabIndex = 11;
            // 
            // Classificação
            // 
            this.Classificação.HeaderText = "Classificação";
            this.Classificação.Name = "Classificação";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 250;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Pontuação";
            this.Valor.Name = "Valor";
            // 
            // txtData3
            // 
            this.txtData3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData3.Location = new System.Drawing.Point(177, 275);
            this.txtData3.Margin = new System.Windows.Forms.Padding(2);
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(338, 29);
            this.txtData3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Validade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Título:";
            // 
            // txtTitulo2
            // 
            // 
            // 
            // 
            this.txtTitulo2.CustomButton.Image = null;
            this.txtTitulo2.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.txtTitulo2.CustomButton.Name = "";
            this.txtTitulo2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTitulo2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo2.CustomButton.TabIndex = 1;
            this.txtTitulo2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo2.CustomButton.UseSelectable = true;
            this.txtTitulo2.CustomButton.Visible = false;
            this.txtTitulo2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTitulo2.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTitulo2.Lines = new string[0];
            this.txtTitulo2.Location = new System.Drawing.Point(178, 68);
            this.txtTitulo2.MaxLength = 32767;
            this.txtTitulo2.Name = "txtTitulo2";
            this.txtTitulo2.PasswordChar = '\0';
            this.txtTitulo2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo2.SelectedText = "";
            this.txtTitulo2.SelectionLength = 0;
            this.txtTitulo2.SelectionStart = 0;
            this.txtTitulo2.ShortcutsEnabled = true;
            this.txtTitulo2.Size = new System.Drawing.Size(188, 30);
            this.txtTitulo2.TabIndex = 0;
            this.txtTitulo2.UseSelectable = true;
            this.txtTitulo2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data Criação:";
            // 
            // txtData2
            // 
            this.txtData2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(178, 116);
            this.txtData2.Margin = new System.Windows.Forms.Padding(2);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(338, 29);
            this.txtData2.TabIndex = 1;
            // 
            // checkAtivo2
            // 
            this.checkAtivo2.AutoSize = true;
            this.checkAtivo2.Location = new System.Drawing.Point(386, 224);
            this.checkAtivo2.Margin = new System.Windows.Forms.Padding(2);
            this.checkAtivo2.Name = "checkAtivo2";
            this.checkAtivo2.Size = new System.Drawing.Size(92, 17);
            this.checkAtivo2.TabIndex = 19;
            this.checkAtivo2.Text = "Ranking ativo";
            this.checkAtivo2.UseVisualStyleBackColor = true;
            // 
            // checkAmigos
            // 
            this.checkAmigos.AutoSize = true;
            this.checkAmigos.Location = new System.Drawing.Point(386, 249);
            this.checkAmigos.Margin = new System.Windows.Forms.Padding(2);
            this.checkAmigos.Name = "checkAmigos";
            this.checkAmigos.Size = new System.Drawing.Size(104, 17);
            this.checkAmigos.TabIndex = 20;
            this.checkAmigos.Text = "Convidar amigos";
            this.checkAmigos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vence em :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            // 
            // btnCompartilhar
            // 
            this.btnCompartilhar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCompartilhar.Location = new System.Drawing.Point(515, 527);
            this.btnCompartilhar.Name = "btnCompartilhar";
            this.btnCompartilhar.Size = new System.Drawing.Size(131, 30);
            this.btnCompartilhar.TabIndex = 23;
            this.btnCompartilhar.Text = "Compartilhar";
            this.btnCompartilhar.UseSelectable = true;
            this.btnCompartilhar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CadastrarRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 569);
            this.Controls.Add(this.btnCompartilhar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkAmigos);
            this.Controls.Add(this.checkAtivo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtTitulo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData3);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnListarRanking);
            this.Controls.Add(this.btnFecharCadastro);
            this.Controls.Add(this.btnInserirRanking);
            this.Controls.Add(this.btnGravarRanking);
            this.Controls.Add(this.txtValorRanking);
            this.Controls.Add(this.txtNomeRanking);
            this.Controls.Add(this.txtCodigoRanking);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCodigo);
            this.Name = "CadastrarRanking";
            this.Text = "CadastrarRanking";
            this.Load += new System.EventHandler(this.CadastrarRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbValor;
        private MetroFramework.Controls.MetroTextBox txtCodigoRanking;
        private MetroFramework.Controls.MetroTextBox txtNomeRanking;
        private MetroFramework.Controls.MetroTextBox txtValorRanking;
        private MetroFramework.Controls.MetroButton btnGravarRanking;
        private MetroFramework.Controls.MetroButton btnInserirRanking;
        private MetroFramework.Controls.MetroButton btnFecharCadastro;
        private MetroFramework.Controls.MetroButton btnListarRanking;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DateTimePicker txtData3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtTitulo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtData2;
        private System.Windows.Forms.CheckBox checkAtivo2;
        private System.Windows.Forms.CheckBox checkAmigos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private MetroFramework.Controls.MetroButton btnCompartilhar;
    }
}