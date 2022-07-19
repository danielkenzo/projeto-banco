
namespace Teste2
{
    partial class telaExtrato
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
            this.btnSaques = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.dgvExtratos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtratos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaques
            // 
            this.btnSaques.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaques.Location = new System.Drawing.Point(30, 69);
            this.btnSaques.Name = "btnSaques";
            this.btnSaques.Size = new System.Drawing.Size(159, 110);
            this.btnSaques.TabIndex = 2;
            this.btnSaques.Text = "Extrato saques";
            this.btnSaques.UseVisualStyleBackColor = true;
            this.btnSaques.Click += new System.EventHandler(this.btnSaques_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositos.Location = new System.Drawing.Point(219, 69);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(160, 110);
            this.btnDepositos.TabIndex = 3;
            this.btnDepositos.Text = "Extrato depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.btnDepositos_Click);
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencias.Location = new System.Drawing.Point(407, 69);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(154, 110);
            this.btnTransferencias.TabIndex = 4;
            this.btnTransferencias.Text = "Extrato transferências";
            this.btnTransferencias.UseVisualStyleBackColor = true;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencias_Click);
            // 
            // dgvExtratos
            // 
            this.dgvExtratos.AllowUserToAddRows = false;
            this.dgvExtratos.AllowUserToDeleteRows = false;
            this.dgvExtratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtratos.Location = new System.Drawing.Point(30, 219);
            this.dgvExtratos.Name = "dgvExtratos";
            this.dgvExtratos.ReadOnly = true;
            this.dgvExtratos.RowHeadersWidth = 62;
            this.dgvExtratos.Size = new System.Drawing.Size(531, 401);
            this.dgvExtratos.TabIndex = 5;
            // 
            // telaExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvExtratos);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.btnDepositos);
            this.Controls.Add(this.btnSaques);
            this.Name = "telaExtrato";
            this.Size = new System.Drawing.Size(600, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaques;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Button btnTransferencias;
        private System.Windows.Forms.DataGridView dgvExtratos;
    }
}
