
namespace Teste2
{
    partial class telaMenuPrincipal
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
            this.picBoxCofre = new System.Windows.Forms.PictureBox();
            this.lblSejaBemVindo = new System.Windows.Forms.Label();
            this.lblAoBancoTeste2 = new System.Windows.Forms.Label();
            this.lblConsultarSaldo = new System.Windows.Forms.Label();
            this.lblSegureAqui = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCofre)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCofre
            // 
            this.picBoxCofre.Image = global::Teste2.Properties.Resources.piggy_bank;
            this.picBoxCofre.Location = new System.Drawing.Point(0, 200);
            this.picBoxCofre.Name = "picBoxCofre";
            this.picBoxCofre.Size = new System.Drawing.Size(603, 500);
            this.picBoxCofre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCofre.TabIndex = 1;
            this.picBoxCofre.TabStop = false;
            // 
            // lblSejaBemVindo
            // 
            this.lblSejaBemVindo.AutoSize = true;
            this.lblSejaBemVindo.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSejaBemVindo.Location = new System.Drawing.Point(66, 22);
            this.lblSejaBemVindo.Name = "lblSejaBemVindo";
            this.lblSejaBemVindo.Size = new System.Drawing.Size(482, 64);
            this.lblSejaBemVindo.TabIndex = 2;
            this.lblSejaBemVindo.Text = "SEJA BEM-VINDO";
            // 
            // lblAoBancoTeste2
            // 
            this.lblAoBancoTeste2.AutoSize = true;
            this.lblAoBancoTeste2.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAoBancoTeste2.Location = new System.Drawing.Point(31, 107);
            this.lblAoBancoTeste2.Name = "lblAoBancoTeste2";
            this.lblAoBancoTeste2.Size = new System.Drawing.Size(537, 64);
            this.lblAoBancoTeste2.TabIndex = 6;
            this.lblAoBancoTeste2.Text = "AO BANCO TESTE 2";
            // 
            // lblConsultarSaldo
            // 
            this.lblConsultarSaldo.AutoSize = true;
            this.lblConsultarSaldo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarSaldo.Location = new System.Drawing.Point(113, 463);
            this.lblConsultarSaldo.Name = "lblConsultarSaldo";
            this.lblConsultarSaldo.Size = new System.Drawing.Size(280, 46);
            this.lblConsultarSaldo.TabIndex = 6;
            this.lblConsultarSaldo.Text = "Consultar saldo:";
            // 
            // lblSegureAqui
            // 
            this.lblSegureAqui.AutoSize = true;
            this.lblSegureAqui.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegureAqui.Location = new System.Drawing.Point(194, 509);
            this.lblSegureAqui.Name = "lblSegureAqui";
            this.lblSegureAqui.Size = new System.Drawing.Size(208, 46);
            this.lblSegureAqui.TabIndex = 7;
            this.lblSegureAqui.Text = "Segure aqui";
            this.lblSegureAqui.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSegureAqui_MouseDown);
            this.lblSegureAqui.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblSegureAqui_MouseUp);
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.Location = new System.Drawing.Point(132, 509);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(67, 46);
            this.lblRS.TabIndex = 6;
            this.lblRS.Text = "R$";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(464, 627);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(124, 27);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "01-01-2000";
            // 
            // telaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.lblSegureAqui);
            this.Controls.Add(this.lblConsultarSaldo);
            this.Controls.Add(this.lblAoBancoTeste2);
            this.Controls.Add(this.lblSejaBemVindo);
            this.Controls.Add(this.picBoxCofre);
            this.Name = "telaMenuPrincipal";
            this.Size = new System.Drawing.Size(600, 700);
            this.Load += new System.EventHandler(this.telaMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCofre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCofre;
        private System.Windows.Forms.Label lblSejaBemVindo;
        private System.Windows.Forms.Label lblAoBancoTeste2;
        private System.Windows.Forms.Label lblConsultarSaldo;
        private System.Windows.Forms.Label lblSegureAqui;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblData;
    }
}
