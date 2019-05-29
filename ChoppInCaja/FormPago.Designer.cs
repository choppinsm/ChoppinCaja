namespace ChoppInCaja
{
    partial class FormPago
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.BtnPagado = new System.Windows.Forms.Button();
            this.ChkTarjeta = new System.Windows.Forms.CheckBox();
            this.LblEfectivo = new System.Windows.Forms.Label();
            this.TxtTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 311);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 37);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label1";
            // 
            // BtnPagado
            // 
            this.BtnPagado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPagado.Location = new System.Drawing.Point(12, 381);
            this.BtnPagado.Name = "BtnPagado";
            this.BtnPagado.Size = new System.Drawing.Size(776, 57);
            this.BtnPagado.TabIndex = 1;
            this.BtnPagado.Text = "Pagado";
            this.BtnPagado.UseVisualStyleBackColor = true;
            this.BtnPagado.Click += new System.EventHandler(this.BtnPagado_Click);
            // 
            // ChkTarjeta
            // 
            this.ChkTarjeta.AutoSize = true;
            this.ChkTarjeta.Location = new System.Drawing.Point(12, 35);
            this.ChkTarjeta.Name = "ChkTarjeta";
            this.ChkTarjeta.Size = new System.Drawing.Size(84, 24);
            this.ChkTarjeta.TabIndex = 2;
            this.ChkTarjeta.Text = "Tarjeta";
            this.ChkTarjeta.UseVisualStyleBackColor = true;
            this.ChkTarjeta.CheckedChanged += new System.EventHandler(this.ChkTarjeta_CheckedChanged);
            // 
            // LblEfectivo
            // 
            this.LblEfectivo.AutoSize = true;
            this.LblEfectivo.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEfectivo.Location = new System.Drawing.Point(12, 201);
            this.LblEfectivo.Name = "LblEfectivo";
            this.LblEfectivo.Size = new System.Drawing.Size(125, 37);
            this.LblEfectivo.TabIndex = 3;
            this.LblEfectivo.Text = "label1";
            // 
            // TxtTarjeta
            // 
            this.TxtTarjeta.Font = new System.Drawing.Font("Consolas", 16F);
            this.TxtTarjeta.Location = new System.Drawing.Point(125, 20);
            this.TxtTarjeta.Mask = "$9999.00";
            this.TxtTarjeta.Name = "TxtTarjeta";
            this.TxtTarjeta.Size = new System.Drawing.Size(268, 45);
            this.TxtTarjeta.TabIndex = 5;
            this.TxtTarjeta.TextChanged += new System.EventHandler(this.TxtTarjeta_TextChanged);
            this.TxtTarjeta.Validated += new System.EventHandler(this.TxtTarjeta_Validated);
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarjeta.Location = new System.Drawing.Point(12, 254);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(125, 37);
            this.LblTarjeta.TabIndex = 6;
            this.LblTarjeta.Text = "label1";
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTarjeta);
            this.Controls.Add(this.TxtTarjeta);
            this.Controls.Add(this.LblEfectivo);
            this.Controls.Add(this.ChkTarjeta);
            this.Controls.Add(this.BtnPagado);
            this.Controls.Add(this.lblTotal);
            this.Name = "FormPago";
            this.Text = "FormPago";
            this.Shown += new System.EventHandler(this.FormPago_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button BtnPagado;
        private System.Windows.Forms.CheckBox ChkTarjeta;
        private System.Windows.Forms.Label LblEfectivo;
        private System.Windows.Forms.MaskedTextBox TxtTarjeta;
        private System.Windows.Forms.Label LblTarjeta;
    }
}