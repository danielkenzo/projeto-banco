
namespace Teste2
{
    partial class MenuPrincipal
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
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.panelSair = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelExtrato = new System.Windows.Forms.Panel();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.panelAlterarDados = new System.Windows.Forms.Panel();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.panelSaque = new System.Windows.Forms.Panel();
            this.btnSaqueTransferenciaDeposito = new System.Windows.Forms.Button();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.picBoxBanco = new System.Windows.Forms.PictureBox();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.telaExtrato1 = new Teste2.telaExtrato();
            this.telaAlterarDados1 = new Teste2.telaAlterarDados();
            this.telaMenuPrincipal2 = new Teste2.telaMenuPrincipal();
            this.telaSaqueTransferenciaDeposito2 = new Teste2.telaSaqueTransferenciaDeposito();
            this.panelEsquerda.SuspendLayout();
            this.panelSair.SuspendLayout();
            this.panelExtrato.SuspendLayout();
            this.panelAlterarDados.SuspendLayout();
            this.panelSaque.SuspendLayout();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanco)).BeginInit();
            this.panelDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEsquerda.Controls.Add(this.panelSair);
            this.panelEsquerda.Controls.Add(this.panelExtrato);
            this.panelEsquerda.Controls.Add(this.panelAlterarDados);
            this.panelEsquerda.Controls.Add(this.panelSaque);
            this.panelEsquerda.Controls.Add(this.panelMenuPrincipal);
            this.panelEsquerda.Controls.Add(this.picBoxBanco);
            this.panelEsquerda.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(200, 700);
            this.panelEsquerda.TabIndex = 0;
            // 
            // panelSair
            // 
            this.panelSair.Controls.Add(this.btnSair);
            this.panelSair.Location = new System.Drawing.Point(0, 600);
            this.panelSair.Name = "panelSair";
            this.panelSair.Size = new System.Drawing.Size(200, 100);
            this.panelSair.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 100);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelExtrato
            // 
            this.panelExtrato.Controls.Add(this.btnExtrato);
            this.panelExtrato.Location = new System.Drawing.Point(0, 500);
            this.panelExtrato.Name = "panelExtrato";
            this.panelExtrato.Size = new System.Drawing.Size(200, 100);
            this.panelExtrato.TabIndex = 4;
            // 
            // btnExtrato
            // 
            this.btnExtrato.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExtrato.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.Location = new System.Drawing.Point(0, 0);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(200, 100);
            this.btnExtrato.TabIndex = 3;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = false;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // panelAlterarDados
            // 
            this.panelAlterarDados.Controls.Add(this.btnAlterarDados);
            this.panelAlterarDados.Location = new System.Drawing.Point(0, 400);
            this.panelAlterarDados.Name = "panelAlterarDados";
            this.panelAlterarDados.Size = new System.Drawing.Size(200, 100);
            this.panelAlterarDados.TabIndex = 2;
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAlterarDados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDados.Location = new System.Drawing.Point(0, 0);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(200, 100);
            this.btnAlterarDados.TabIndex = 2;
            this.btnAlterarDados.Text = "Alterar dados";
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // panelSaque
            // 
            this.panelSaque.Controls.Add(this.btnSaqueTransferenciaDeposito);
            this.panelSaque.Location = new System.Drawing.Point(0, 300);
            this.panelSaque.Name = "panelSaque";
            this.panelSaque.Size = new System.Drawing.Size(200, 100);
            this.panelSaque.TabIndex = 3;
            // 
            // btnSaqueTransferenciaDeposito
            // 
            this.btnSaqueTransferenciaDeposito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaqueTransferenciaDeposito.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueTransferenciaDeposito.Location = new System.Drawing.Point(0, 0);
            this.btnSaqueTransferenciaDeposito.Name = "btnSaqueTransferenciaDeposito";
            this.btnSaqueTransferenciaDeposito.Size = new System.Drawing.Size(200, 100);
            this.btnSaqueTransferenciaDeposito.TabIndex = 1;
            this.btnSaqueTransferenciaDeposito.Text = "Saque, Transferência, Depósito";
            this.btnSaqueTransferenciaDeposito.UseVisualStyleBackColor = false;
            this.btnSaqueTransferenciaDeposito.Click += new System.EventHandler(this.btnSaqueTransferenciaDeposito_Click);
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Controls.Add(this.btnMenuPrincipal);
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 200);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 100);
            this.panelMenuPrincipal.TabIndex = 1;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(200, 100);
            this.btnMenuPrincipal.TabIndex = 2;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // picBoxBanco
            // 
            this.picBoxBanco.Image = global::Teste2.Properties.Resources.bank;
            this.picBoxBanco.Location = new System.Drawing.Point(-3, 0);
            this.picBoxBanco.Name = "picBoxBanco";
            this.picBoxBanco.Size = new System.Drawing.Size(203, 194);
            this.picBoxBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBanco.TabIndex = 0;
            this.picBoxBanco.TabStop = false;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDireita.Controls.Add(this.telaExtrato1);
            this.panelDireita.Controls.Add(this.telaAlterarDados1);
            this.panelDireita.Controls.Add(this.telaMenuPrincipal2);
            this.panelDireita.Controls.Add(this.telaSaqueTransferenciaDeposito2);
            this.panelDireita.Location = new System.Drawing.Point(200, 0);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(600, 700);
            this.panelDireita.TabIndex = 1;
            // 
            // telaExtrato1
            // 
            this.telaExtrato1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.telaExtrato1.Location = new System.Drawing.Point(0, 0);
            this.telaExtrato1.Name = "telaExtrato1";
            this.telaExtrato1.Size = new System.Drawing.Size(600, 700);
            this.telaExtrato1.TabIndex = 3;
            // 
            // telaAlterarDados1
            // 
            this.telaAlterarDados1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.telaAlterarDados1.Location = new System.Drawing.Point(0, 0);
            this.telaAlterarDados1.Name = "telaAlterarDados1";
            this.telaAlterarDados1.Size = new System.Drawing.Size(600, 700);
            this.telaAlterarDados1.TabIndex = 2;
            // 
            // telaMenuPrincipal2
            // 
            this.telaMenuPrincipal2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.telaMenuPrincipal2.Location = new System.Drawing.Point(0, 0);
            this.telaMenuPrincipal2.Name = "telaMenuPrincipal2";
            this.telaMenuPrincipal2.Size = new System.Drawing.Size(600, 700);
            this.telaMenuPrincipal2.TabIndex = 1;
            // 
            // telaSaqueTransferenciaDeposito2
            // 
            this.telaSaqueTransferenciaDeposito2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.telaSaqueTransferenciaDeposito2.Location = new System.Drawing.Point(0, 0);
            this.telaSaqueTransferenciaDeposito2.Name = "telaSaqueTransferenciaDeposito2";
            this.telaSaqueTransferenciaDeposito2.Size = new System.Drawing.Size(600, 700);
            this.telaSaqueTransferenciaDeposito2.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.panelDireita);
            this.Controls.Add(this.panelEsquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelEsquerda.ResumeLayout(false);
            this.panelSair.ResumeLayout(false);
            this.panelExtrato.ResumeLayout(false);
            this.panelAlterarDados.ResumeLayout(false);
            this.panelSaque.ResumeLayout(false);
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanco)).EndInit();
            this.panelDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.PictureBox picBoxBanco;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.Panel panelSaque;
        private System.Windows.Forms.Panel panelExtrato;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Panel panelAlterarDados;
        private System.Windows.Forms.Panel panelSair;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnSaqueTransferenciaDeposito;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private telaAlterarDados telaAlterarDados1;
        private telaMenuPrincipal telaMenuPrincipal2;
        private telaSaqueTransferenciaDeposito telaSaqueTransferenciaDeposito2;
        private telaExtrato telaExtrato1;
    }
}