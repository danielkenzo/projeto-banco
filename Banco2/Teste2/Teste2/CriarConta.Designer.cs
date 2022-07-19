
namespace Teste2
{
    partial class CriarConta
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
            this.picBoxTelaFundo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.lblSenhaNumDigitos = new System.Windows.Forms.Label();
            this.txtSenhaConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txtDataAniversario = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenhaConfirmar = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lclCelular = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.picBoxSetaVoltar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelaFundo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSetaVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxTelaFundo
            // 
            this.picBoxTelaFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxTelaFundo.Image = global::Teste2.Properties.Resources.LoginNormal;
            this.picBoxTelaFundo.Location = new System.Drawing.Point(0, 0);
            this.picBoxTelaFundo.Name = "picBoxTelaFundo";
            this.picBoxTelaFundo.Size = new System.Drawing.Size(700, 500);
            this.picBoxTelaFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTelaFundo.TabIndex = 1;
            this.picBoxTelaFundo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.btnCriarConta);
            this.panel1.Controls.Add(this.lblSenhaNumDigitos);
            this.panel1.Controls.Add(this.txtSenhaConfirmar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.txtDataAniversario);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblSenhaConfirmar);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.lclCelular);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblVoltar);
            this.panel1.Controls.Add(this.picBoxSetaVoltar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 450);
            this.panel1.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(484, 305);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 33);
            this.txtSaldo.TabIndex = 21;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSaldo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(343, 308);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(135, 27);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "Saldo inicial:";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(254, 373);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(128, 46);
            this.btnCriarConta.TabIndex = 19;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // lblSenhaNumDigitos
            // 
            this.lblSenhaNumDigitos.AutoSize = true;
            this.lblSenhaNumDigitos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSenhaNumDigitos.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaNumDigitos.Location = new System.Drawing.Point(26, 272);
            this.lblSenhaNumDigitos.Name = "lblSenhaNumDigitos";
            this.lblSenhaNumDigitos.Size = new System.Drawing.Size(70, 19);
            this.lblSenhaNumDigitos.TabIndex = 18;
            this.lblSenhaNumDigitos.Text = "(4 dígitos)";
            // 
            // txtSenhaConfirmar
            // 
            this.txtSenhaConfirmar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaConfirmar.Location = new System.Drawing.Point(484, 246);
            this.txtSenhaConfirmar.Mask = "0000";
            this.txtSenhaConfirmar.Name = "txtSenhaConfirmar";
            this.txtSenhaConfirmar.Size = new System.Drawing.Size(155, 33);
            this.txtSenhaConfirmar.TabIndex = 17;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(117, 246);
            this.txtSenha.Mask = "0000";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(170, 33);
            this.txtSenha.TabIndex = 16;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cbxStatus.Location = new System.Drawing.Point(484, 132);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(155, 33);
            this.cbxStatus.TabIndex = 15;
            this.cbxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxStatus_KeyPress);
            // 
            // txtDataAniversario
            // 
            this.txtDataAniversario.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAniversario.Location = new System.Drawing.Point(484, 187);
            this.txtDataAniversario.Mask = "00-00-0000";
            this.txtDataAniversario.Name = "txtDataAniversario";
            this.txtDataAniversario.Size = new System.Drawing.Size(155, 33);
            this.txtDataAniversario.TabIndex = 14;
            this.txtDataAniversario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(117, 187);
            this.txtCelular.Mask = "(00)00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(170, 33);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(117, 132);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(170, 33);
            this.txtCPF.TabIndex = 12;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(117, 80);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(522, 33);
            this.txtNome.TabIndex = 11;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblSenhaConfirmar
            // 
            this.lblSenhaConfirmar.AutoSize = true;
            this.lblSenhaConfirmar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSenhaConfirmar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaConfirmar.Location = new System.Drawing.Point(316, 254);
            this.lblSenhaConfirmar.Name = "lblSenhaConfirmar";
            this.lblSenhaConfirmar.Size = new System.Drawing.Size(162, 25);
            this.lblSenhaConfirmar.TabIndex = 10;
            this.lblSenhaConfirmar.Text = "Confirmar senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(20, 246);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 27);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(402, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 27);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDataNascimento.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(327, 198);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(151, 22);
            this.lblDataNascimento.TabIndex = 7;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // lclCelular
            // 
            this.lclCelular.AutoSize = true;
            this.lclCelular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lclCelular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCelular.Location = new System.Drawing.Point(8, 193);
            this.lclCelular.Name = "lclCelular";
            this.lclCelular.Size = new System.Drawing.Size(88, 27);
            this.lclCelular.TabIndex = 6;
            this.lclCelular.Text = "Celular:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(35, 138);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(61, 27);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(20, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 27);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblVoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.Location = new System.Drawing.Point(69, 23);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(294, 27);
            this.lblVoltar.TabIndex = 3;
            this.lblVoltar.Text = "Voltar para a página de Login";
            // 
            // picBoxSetaVoltar
            // 
            this.picBoxSetaVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.picBoxSetaVoltar.Image = global::Teste2.Properties.Resources.BackArrow;
            this.picBoxSetaVoltar.Location = new System.Drawing.Point(18, 14);
            this.picBoxSetaVoltar.Name = "picBoxSetaVoltar";
            this.picBoxSetaVoltar.Size = new System.Drawing.Size(45, 46);
            this.picBoxSetaVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSetaVoltar.TabIndex = 2;
            this.picBoxSetaVoltar.TabStop = false;
            this.picBoxSetaVoltar.Click += new System.EventHandler(this.picBoxSetaVoltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Teste2.Properties.Resources.Login;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(650, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBoxTelaFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaCriarContaa";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelaFundo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSetaVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTelaFundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoxSetaVoltar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.MaskedTextBox txtSenhaConfirmar;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.MaskedTextBox txtDataAniversario;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenhaConfirmar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lclCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenhaNumDigitos;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}