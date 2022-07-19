
namespace Teste2
{
    partial class telaSaqueTransferenciaDeposito
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnSaqueRapido = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.panelLinha1 = new System.Windows.Forms.Panel();
            this.lblSaque = new System.Windows.Forms.Label();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.btnSaqueEnvio = new System.Windows.Forms.Button();
            this.btnSaqueRapido20 = new System.Windows.Forms.Button();
            this.btnSaqueRapido50 = new System.Windows.Forms.Button();
            this.btnSaqueRapido100 = new System.Windows.Forms.Button();
            this.panelLinha2 = new System.Windows.Forms.Panel();
            this.lblTransferenciaValor = new System.Windows.Forms.Label();
            this.txtTransferenciaValor = new System.Windows.Forms.TextBox();
            this.lblTransferenciaCPF = new System.Windows.Forms.Label();
            this.btnTransferenciaEnvio = new System.Windows.Forms.Button();
            this.txtTransferenciaCPF = new System.Windows.Forms.MaskedTextBox();
            this.panelLinha3 = new System.Windows.Forms.Panel();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.btnDepositoEnvio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(420, 33);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(160, 95);
            this.btnSaque.TabIndex = 1;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnSaqueRapido
            // 
            this.btnSaqueRapido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueRapido.Location = new System.Drawing.Point(420, 183);
            this.btnSaqueRapido.Name = "btnSaqueRapido";
            this.btnSaqueRapido.Size = new System.Drawing.Size(160, 95);
            this.btnSaqueRapido.TabIndex = 2;
            this.btnSaqueRapido.Text = "Saque Rápido";
            this.btnSaqueRapido.UseVisualStyleBackColor = true;
            this.btnSaqueRapido.Click += new System.EventHandler(this.btnSaqueRapido_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.Location = new System.Drawing.Point(420, 365);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(160, 95);
            this.btnTransferencia.TabIndex = 3;
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(420, 567);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(160, 95);
            this.btnDeposito.TabIndex = 4;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // panelLinha1
            // 
            this.panelLinha1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLinha1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLinha1.Location = new System.Drawing.Point(15, 152);
            this.panelLinha1.Name = "panelLinha1";
            this.panelLinha1.Size = new System.Drawing.Size(565, 5);
            this.panelLinha1.TabIndex = 17;
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaque.Location = new System.Drawing.Point(10, 33);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(333, 27);
            this.lblSaque.TabIndex = 18;
            this.lblSaque.Text = "Digite a quantia que deseja sacar:";
            // 
            // txtSaque
            // 
            this.txtSaque.Enabled = false;
            this.txtSaque.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaque.Location = new System.Drawing.Point(15, 70);
            this.txtSaque.Multiline = true;
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(167, 45);
            this.txtSaque.TabIndex = 19;
            this.txtSaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaque_KeyPress);
            // 
            // btnSaqueEnvio
            // 
            this.btnSaqueEnvio.Enabled = false;
            this.btnSaqueEnvio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueEnvio.Location = new System.Drawing.Point(188, 80);
            this.btnSaqueEnvio.Name = "btnSaqueEnvio";
            this.btnSaqueEnvio.Size = new System.Drawing.Size(87, 35);
            this.btnSaqueEnvio.TabIndex = 20;
            this.btnSaqueEnvio.Text = "Sacar";
            this.btnSaqueEnvio.UseVisualStyleBackColor = true;
            this.btnSaqueEnvio.Click += new System.EventHandler(this.btnSaqueEnvio_Click);
            // 
            // btnSaqueRapido20
            // 
            this.btnSaqueRapido20.Enabled = false;
            this.btnSaqueRapido20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueRapido20.Location = new System.Drawing.Point(14, 182);
            this.btnSaqueRapido20.Name = "btnSaqueRapido20";
            this.btnSaqueRapido20.Size = new System.Drawing.Size(115, 95);
            this.btnSaqueRapido20.TabIndex = 21;
            this.btnSaqueRapido20.Text = "R$ 20,00";
            this.btnSaqueRapido20.UseVisualStyleBackColor = true;
            this.btnSaqueRapido20.Click += new System.EventHandler(this.btnSaqueRapido20_Click);
            // 
            // btnSaqueRapido50
            // 
            this.btnSaqueRapido50.Enabled = false;
            this.btnSaqueRapido50.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueRapido50.Location = new System.Drawing.Point(147, 182);
            this.btnSaqueRapido50.Name = "btnSaqueRapido50";
            this.btnSaqueRapido50.Size = new System.Drawing.Size(115, 95);
            this.btnSaqueRapido50.TabIndex = 22;
            this.btnSaqueRapido50.Text = "R$ 50,00";
            this.btnSaqueRapido50.UseVisualStyleBackColor = true;
            this.btnSaqueRapido50.Click += new System.EventHandler(this.btnSaqueRapido50_Click);
            // 
            // btnSaqueRapido100
            // 
            this.btnSaqueRapido100.Enabled = false;
            this.btnSaqueRapido100.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueRapido100.Location = new System.Drawing.Point(278, 182);
            this.btnSaqueRapido100.Name = "btnSaqueRapido100";
            this.btnSaqueRapido100.Size = new System.Drawing.Size(124, 95);
            this.btnSaqueRapido100.TabIndex = 23;
            this.btnSaqueRapido100.Text = "R$ 100,00";
            this.btnSaqueRapido100.UseVisualStyleBackColor = true;
            this.btnSaqueRapido100.Click += new System.EventHandler(this.btnSaqueRapido100_Click);
            // 
            // panelLinha2
            // 
            this.panelLinha2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLinha2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLinha2.Location = new System.Drawing.Point(15, 305);
            this.panelLinha2.Name = "panelLinha2";
            this.panelLinha2.Size = new System.Drawing.Size(565, 5);
            this.panelLinha2.TabIndex = 18;
            // 
            // lblTransferenciaValor
            // 
            this.lblTransferenciaValor.AutoSize = true;
            this.lblTransferenciaValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferenciaValor.Location = new System.Drawing.Point(10, 330);
            this.lblTransferenciaValor.Name = "lblTransferenciaValor";
            this.lblTransferenciaValor.Size = new System.Drawing.Size(371, 27);
            this.lblTransferenciaValor.TabIndex = 24;
            this.lblTransferenciaValor.Text = "Digite a quantia que deseja transferir:";
            // 
            // txtTransferenciaValor
            // 
            this.txtTransferenciaValor.Enabled = false;
            this.txtTransferenciaValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferenciaValor.Location = new System.Drawing.Point(14, 365);
            this.txtTransferenciaValor.Multiline = true;
            this.txtTransferenciaValor.Name = "txtTransferenciaValor";
            this.txtTransferenciaValor.Size = new System.Drawing.Size(168, 45);
            this.txtTransferenciaValor.TabIndex = 25;
            this.txtTransferenciaValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransferenciaValor_KeyPress);
            // 
            // lblTransferenciaCPF
            // 
            this.lblTransferenciaCPF.AutoSize = true;
            this.lblTransferenciaCPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferenciaCPF.Location = new System.Drawing.Point(10, 433);
            this.lblTransferenciaCPF.Name = "lblTransferenciaCPF";
            this.lblTransferenciaCPF.Size = new System.Drawing.Size(392, 27);
            this.lblTransferenciaCPF.TabIndex = 26;
            this.lblTransferenciaCPF.Text = "Digite o CPF da pessoa que irá receber:";
            // 
            // btnTransferenciaEnvio
            // 
            this.btnTransferenciaEnvio.Enabled = false;
            this.btnTransferenciaEnvio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferenciaEnvio.Location = new System.Drawing.Point(188, 469);
            this.btnTransferenciaEnvio.Name = "btnTransferenciaEnvio";
            this.btnTransferenciaEnvio.Size = new System.Drawing.Size(111, 36);
            this.btnTransferenciaEnvio.TabIndex = 27;
            this.btnTransferenciaEnvio.Text = "Transferir";
            this.btnTransferenciaEnvio.UseVisualStyleBackColor = true;
            this.btnTransferenciaEnvio.Click += new System.EventHandler(this.btnTransferenciaEnvio_Click);
            // 
            // txtTransferenciaCPF
            // 
            this.txtTransferenciaCPF.Enabled = false;
            this.txtTransferenciaCPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferenciaCPF.Location = new System.Drawing.Point(15, 470);
            this.txtTransferenciaCPF.Mask = "000.000.000-00";
            this.txtTransferenciaCPF.Name = "txtTransferenciaCPF";
            this.txtTransferenciaCPF.Size = new System.Drawing.Size(167, 35);
            this.txtTransferenciaCPF.TabIndex = 29;
            this.txtTransferenciaCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panelLinha3
            // 
            this.panelLinha3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLinha3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLinha3.Location = new System.Drawing.Point(15, 535);
            this.panelLinha3.Name = "panelLinha3";
            this.panelLinha3.Size = new System.Drawing.Size(565, 5);
            this.panelLinha3.TabIndex = 19;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(10, 578);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(371, 27);
            this.lblDeposito.TabIndex = 30;
            this.lblDeposito.Text = "Digite a quantia que deseja depositar:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Enabled = false;
            this.txtDeposito.Location = new System.Drawing.Point(15, 617);
            this.txtDeposito.Multiline = true;
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(167, 45);
            this.txtDeposito.TabIndex = 31;
            this.txtDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposito_KeyPress);
            // 
            // btnDepositoEnvio
            // 
            this.btnDepositoEnvio.Enabled = false;
            this.btnDepositoEnvio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositoEnvio.Location = new System.Drawing.Point(188, 628);
            this.btnDepositoEnvio.Name = "btnDepositoEnvio";
            this.btnDepositoEnvio.Size = new System.Drawing.Size(111, 34);
            this.btnDepositoEnvio.TabIndex = 32;
            this.btnDepositoEnvio.Text = "Depositar";
            this.btnDepositoEnvio.UseVisualStyleBackColor = true;
            this.btnDepositoEnvio.Click += new System.EventHandler(this.btnDepositoEnvio_Click);
            // 
            // telaSaqueTransferenciaDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnDepositoEnvio);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.panelLinha3);
            this.Controls.Add(this.txtTransferenciaCPF);
            this.Controls.Add(this.btnTransferenciaEnvio);
            this.Controls.Add(this.lblTransferenciaCPF);
            this.Controls.Add(this.txtTransferenciaValor);
            this.Controls.Add(this.lblTransferenciaValor);
            this.Controls.Add(this.panelLinha2);
            this.Controls.Add(this.btnSaqueRapido100);
            this.Controls.Add(this.btnSaqueRapido50);
            this.Controls.Add(this.btnSaqueRapido20);
            this.Controls.Add(this.btnSaqueEnvio);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.lblSaque);
            this.Controls.Add(this.panelLinha1);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnSaqueRapido);
            this.Controls.Add(this.btnSaque);
            this.Name = "telaSaqueTransferenciaDeposito";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnSaqueRapido;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Panel panelLinha1;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Button btnSaqueEnvio;
        private System.Windows.Forms.Button btnSaqueRapido20;
        private System.Windows.Forms.Button btnSaqueRapido50;
        private System.Windows.Forms.Button btnSaqueRapido100;
        private System.Windows.Forms.Panel panelLinha2;
        private System.Windows.Forms.Label lblTransferenciaValor;
        private System.Windows.Forms.TextBox txtTransferenciaValor;
        private System.Windows.Forms.Label lblTransferenciaCPF;
        private System.Windows.Forms.Button btnTransferenciaEnvio;
        private System.Windows.Forms.MaskedTextBox txtTransferenciaCPF;
        private System.Windows.Forms.Panel panelLinha3;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Button btnDepositoEnvio;
    }
}
