namespace ChoppInCaja
{
    partial class FormProducto
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.CtrCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CtrDiferencia = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblImporte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.CboAplica = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CtrCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrDiferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(436, 356);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(207, 41);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAceptar.Location = new System.Drawing.Point(19, 356);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(207, 41);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.TabStop = false;
            this.BtnAceptar.Text = "Actualizar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(19, 13);
            this.LblProducto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(118, 29);
            this.LblProducto.TabIndex = 3;
            this.LblProducto.Text = "Producto";
            // 
            // CtrCantidad
            // 
            this.CtrCantidad.Location = new System.Drawing.Point(305, 121);
            this.CtrCantidad.Margin = new System.Windows.Forms.Padding(5);
            this.CtrCantidad.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CtrCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrCantidad.Name = "CtrCantidad";
            this.CtrCantidad.Size = new System.Drawing.Size(78, 35);
            this.CtrCantidad.TabIndex = 0;
            this.CtrCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diferencia:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // CtrDiferencia
            // 
            this.CtrDiferencia.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CtrDiferencia.Location = new System.Drawing.Point(305, 209);
            this.CtrDiferencia.Margin = new System.Windows.Forms.Padding(5);
            this.CtrDiferencia.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CtrDiferencia.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.CtrDiferencia.Name = "CtrDiferencia";
            this.CtrDiferencia.Size = new System.Drawing.Size(120, 35);
            this.CtrDiferencia.TabIndex = 2;
            this.CtrDiferencia.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(15, 84);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(285, 29);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Precio:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Location = new System.Drawing.Point(300, 84);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(283, 29);
            this.LblPrecio.TabIndex = 8;
            this.LblPrecio.Text = "Precio:";
            this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblImporte
            // 
            this.LblImporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImporte.Location = new System.Drawing.Point(300, 312);
            this.LblImporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(283, 29);
            this.LblImporte.TabIndex = 10;
            this.LblImporte.Text = "Precio:";
            this.LblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(15, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importe:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Motivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMotivo.Location = new System.Drawing.Point(305, 249);
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(326, 35);
            this.TxtMotivo.TabIndex = 3;
            this.TxtMotivo.Visible = false;
            // 
            // CboAplica
            // 
            this.CboAplica.FormattingEnabled = true;
            this.CboAplica.Location = new System.Drawing.Point(305, 164);
            this.CboAplica.Name = "CboAplica";
            this.CboAplica.Size = new System.Drawing.Size(326, 37);
            this.CboAplica.TabIndex = 1;
            this.CboAplica.Tag = "";
            this.CboAplica.SelectedIndexChanged += new System.EventHandler(this.CboAplica_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aplica Diferencia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormProducto
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(662, 415);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CboAplica);
            this.Controls.Add(this.TxtMotivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.CtrDiferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CtrCantidad);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CtrCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrDiferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.NumericUpDown CtrCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CtrDiferencia;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMotivo;
        private System.Windows.Forms.ComboBox CboAplica;
        private System.Windows.Forms.Label label5;
    }
}