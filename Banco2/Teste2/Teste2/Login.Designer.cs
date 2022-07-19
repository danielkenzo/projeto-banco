
namespace Teste2
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.lblNomeBanco = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.panelLinhaSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.picBoxSenha = new System.Windows.Forms.PictureBox();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.panelLinhaCPF = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.picBoxCPF = new System.Windows.Forms.PictureBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.picBoxLogin = new System.Windows.Forms.PictureBox();
            this.toolTipSenha = new System.Windows.Forms.ToolTip(this.components);
            this.picBoxTelaFundo = new System.Windows.Forms.PictureBox();
            this.btnFecharApp = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSenha)).BeginInit();
            this.panelCPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelaFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeBanco
            // 
            this.lblNomeBanco.AutoSize = true;
            this.lblNomeBanco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomeBanco.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBanco.Location = new System.Drawing.Point(87, 35);
            this.lblNomeBanco.Name = "lblNomeBanco";
            this.lblNomeBanco.Size = new System.Drawing.Size(520, 51);
            this.lblNomeBanco.TabIndex = 3;
            this.lblNomeBanco.Text = "TESTE BANCO DANIEL 2";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnCriarConta);
            this.panelLogin.Controls.Add(this.lblSenha);
            this.panelLogin.Controls.Add(this.panelSenha);
            this.panelLogin.Controls.Add(this.panelCPF);
            this.panelLogin.Controls.Add(this.lblCPF);
            this.panelLogin.Controls.Add(this.picBoxLogin);
            this.panelLogin.Location = new System.Drawing.Point(200, 100);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(300, 300);
            this.panelLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(152, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 43);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(15, 210);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(119, 43);
            this.btnCriarConta.TabIndex = 7;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(15, 129);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(81, 22);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "SENHA:";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelSenha
            // 
            this.panelSenha.BackColor = System.Drawing.Color.Transparent;
            this.panelSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSenha.Controls.Add(this.panelLinhaSenha);
            this.panelSenha.Controls.Add(this.txtSenha);
            this.panelSenha.Controls.Add(this.picBoxSenha);
            this.panelSenha.Location = new System.Drawing.Point(15, 154);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(250, 37);
            this.panelSenha.TabIndex = 5;
            // 
            // panelLinhaSenha
            // 
            this.panelLinhaSenha.BackColor = System.Drawing.Color.Black;
            this.panelLinhaSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLinhaSenha.Location = new System.Drawing.Point(50, 32);
            this.panelLinhaSenha.Name = "panelLinhaSenha";
            this.panelLinhaSenha.Size = new System.Drawing.Size(50, 2);
            this.panelLinhaSenha.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenha.Location = new System.Drawing.Point(48, 6);
            this.txtSenha.Mask = "0000";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(70, 28);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "1234";
            this.txtSenha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // picBoxSenha
            // 
            this.picBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSenha.Image = global::Teste2.Properties.Resources.padlock;
            this.picBoxSenha.Location = new System.Drawing.Point(0, 0);
            this.picBoxSenha.Name = "picBoxSenha";
            this.picBoxSenha.Size = new System.Drawing.Size(40, 36);
            this.picBoxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSenha.TabIndex = 0;
            this.picBoxSenha.TabStop = false;
            this.toolTipSenha.SetToolTip(this.picBoxSenha, "Pressione o botão esquerdo do mouse para visualizar a senha");
            this.picBoxSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxSenha_MouseDown);
            this.picBoxSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxSenha_MouseUp);
            // 
            // panelCPF
            // 
            this.panelCPF.BackColor = System.Drawing.Color.Transparent;
            this.panelCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCPF.Controls.Add(this.panelLinhaCPF);
            this.panelCPF.Controls.Add(this.txtCPF);
            this.panelCPF.Controls.Add(this.picBoxCPF);
            this.panelCPF.Location = new System.Drawing.Point(15, 56);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(250, 37);
            this.panelCPF.TabIndex = 4;
            // 
            // panelLinhaCPF
            // 
            this.panelLinhaCPF.BackColor = System.Drawing.Color.Black;
            this.panelLinhaCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLinhaCPF.Location = new System.Drawing.Point(48, 32);
            this.panelLinhaCPF.Name = "panelLinhaCPF";
            this.panelLinhaCPF.Size = new System.Drawing.Size(152, 2);
            this.panelLinhaCPF.TabIndex = 7;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCPF.Location = new System.Drawing.Point(48, 6);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(160, 28);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Text = "00000000000";
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Click += new System.EventHandler(this.txtCPF_Click);
            // 
            // picBoxCPF
            // 
            this.picBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCPF.Image = global::Teste2.Properties.Resources.user;
            this.picBoxCPF.Location = new System.Drawing.Point(0, 0);
            this.picBoxCPF.Name = "picBoxCPF";
            this.picBoxCPF.Size = new System.Drawing.Size(40, 36);
            this.picBoxCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCPF.TabIndex = 0;
            this.picBoxCPF.TabStop = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCPF.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(15, 31);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(51, 22);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // picBoxLogin
            // 
            this.picBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxLogin.Image = global::Teste2.Properties.Resources.Login;
            this.picBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogin.Name = "picBoxLogin";
            this.picBoxLogin.Size = new System.Drawing.Size(300, 300);
            this.picBoxLogin.TabIndex = 1;
            this.picBoxLogin.TabStop = false;
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
            // btnFecharApp
            // 
            this.btnFecharApp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFecharApp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharApp.Location = new System.Drawing.Point(215, 415);
            this.btnFecharApp.Name = "btnFecharApp";
            this.btnFecharApp.Size = new System.Drawing.Size(275, 50);
            this.btnFecharApp.TabIndex = 6;
            this.btnFecharApp.Text = "Sair do aplicativo";
            this.btnFecharApp.UseVisualStyleBackColor = false;
            this.btnFecharApp.Click += new System.EventHandler(this.btnFecharApp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnFecharApp);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblNomeBanco);
            this.Controls.Add(this.picBoxTelaFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSenha)).EndInit();
            this.panelCPF.ResumeLayout(false);
            this.panelCPF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelaFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTelaFundo;
        private System.Windows.Forms.Label lblNomeBanco;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox picBoxLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.PictureBox picBoxSenha;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.PictureBox picBoxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Panel panelLinhaCPF;
        private System.Windows.Forms.Panel panelLinhaSenha;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ToolTip toolTipSenha;
        private System.Windows.Forms.Button btnFecharApp;
    }
}

