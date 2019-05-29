namespace ChoppInCaja
{
    partial class FormCaja
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
            this.LblEfectivo = new System.Windows.Forms.Label();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEfectivo
            // 
            this.LblEfectivo.AutoSize = true;
            this.LblEfectivo.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEfectivo.Location = new System.Drawing.Point(32, 58);
            this.LblEfectivo.Name = "LblEfectivo";
            this.LblEfectivo.Size = new System.Drawing.Size(125, 37);
            this.LblEfectivo.TabIndex = 0;
            this.LblEfectivo.Text = "label1";
            this.LblEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.CausesValidation = false;
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Location = new System.Drawing.Point(27, 305);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(276, 69);
            this.BtnCerrarCaja.TabIndex = 0;
            this.BtnCerrarCaja.TabStop = false;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarjeta.Location = new System.Drawing.Point(32, 139);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(125, 37);
            this.LblTarjeta.TabIndex = 2;
            this.LblTarjeta.Text = "label1";
            this.LblTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(32, 229);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(125, 37);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "label1";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(338, 305);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(378, 69);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(728, 415);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTarjeta);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.LblEfectivo);
            this.Name = "FormCaja";
            this.Text = "FormCaja";
            this.Shown += new System.EventHandler(this.FormCaja_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEfectivo;
        private System.Windows.Forms.Button BtnCerrarCaja;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnCancelar;
    }
}