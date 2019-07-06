namespace ChoppInCaja
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMesaDetalle = new System.Windows.Forms.DataGridView();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnAbrirCerrarMesa = new System.Windows.Forms.Button();
            this.BtnABM = new System.Windows.Forms.Button();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LstProductos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMesaDetalle
            // 
            this.gridMesaDetalle.AllowUserToAddRows = false;
            this.gridMesaDetalle.AllowUserToDeleteRows = false;
            this.gridMesaDetalle.AllowUserToOrderColumns = true;
            this.gridMesaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMesaDetalle.BackgroundColor = System.Drawing.Color.Black;
            this.gridMesaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMesaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMesaDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridMesaDetalle.GridColor = System.Drawing.Color.Black;
            this.gridMesaDetalle.Location = new System.Drawing.Point(14, 504);
            this.gridMesaDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridMesaDetalle.Name = "gridMesaDetalle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMesaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridMesaDetalle.RowHeadersWidth = 70;
            this.gridMesaDetalle.RowTemplate.Height = 40;
            this.gridMesaDetalle.Size = new System.Drawing.Size(1318, 173);
            this.gridMesaDetalle.TabIndex = 2;
            this.gridMesaDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMesaDetalle_CellEndEdit);
            this.gridMesaDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridMesaDetalle_DataError);
            this.gridMesaDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridMesaDetalle_EditingControlShowing);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.Black;
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblEstado,
            this.LblTotal});
            this.StatusBar.Location = new System.Drawing.Point(0, 682);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.StatusBar.Size = new System.Drawing.Size(1344, 30);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // LblEstado
            // 
            this.LblEstado.BackColor = System.Drawing.Color.Black;
            this.LblEstado.ForeColor = System.Drawing.Color.Lime;
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(66, 25);
            this.LblEstado.Text = "Estado";
            // 
            // LblTotal
            // 
            this.LblTotal.ForeColor = System.Drawing.Color.Lime;
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(49, 25);
            this.LblTotal.Text = "Total";
            // 
            // BtnAbrirCerrarMesa
            // 
            this.BtnAbrirCerrarMesa.AutoSize = true;
            this.BtnAbrirCerrarMesa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAbrirCerrarMesa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirCerrarMesa.Location = new System.Drawing.Point(872, 108);
            this.BtnAbrirCerrarMesa.Name = "BtnAbrirCerrarMesa";
            this.BtnAbrirCerrarMesa.Size = new System.Drawing.Size(165, 38);
            this.BtnAbrirCerrarMesa.TabIndex = 5;
            this.BtnAbrirCerrarMesa.Text = "Cerrar Mesa";
            this.BtnAbrirCerrarMesa.UseVisualStyleBackColor = true;
            this.BtnAbrirCerrarMesa.Click += new System.EventHandler(this.btnAbrirCerrarMesa_Click);
            // 
            // BtnABM
            // 
            this.BtnABM.AutoSize = true;
            this.BtnABM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnABM.BackColor = System.Drawing.Color.Red;
            this.BtnABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnABM.ForeColor = System.Drawing.Color.White;
            this.BtnABM.Location = new System.Drawing.Point(1288, 108);
            this.BtnABM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnABM.Name = "BtnABM";
            this.BtnABM.Size = new System.Drawing.Size(29, 39);
            this.BtnABM.TabIndex = 8;
            this.BtnABM.Text = "!";
            this.BtnABM.UseVisualStyleBackColor = false;
            this.BtnABM.Click += new System.EventHandler(this.BtnABM_Click);
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.AutoSize = true;
            this.BtnCerrarCaja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Location = new System.Drawing.Point(1093, 101);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(165, 38);
            this.BtnCerrarCaja.TabIndex = 9;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(14, 211);
            this.TxtBusqueda.MaxLength = 3;
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(142, 26);
            this.TxtBusqueda.TabIndex = 11;
            this.TxtBusqueda.Text = "T";
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            this.TxtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusqueda_KeyPress);
            // 
            // LstProductos
            // 
            this.LstProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LstProductos.Location = new System.Drawing.Point(14, 354);
            this.LstProductos.Name = "LstProductos";
            this.LstProductos.Size = new System.Drawing.Size(1318, 134);
            this.LstProductos.TabIndex = 12;
            this.LstProductos.TabStop = true;
            this.LstProductos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LstProductos_PreviewKeyDown);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.LstProductos);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.BtnABM);
            this.Controls.Add(this.BtnAbrirCerrarMesa);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.gridMesaDetalle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridMesaDetalle;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel LblEstado;
        private System.Windows.Forms.Button BtnAbrirCerrarMesa;
        private System.Windows.Forms.Button BtnABM;
        private System.Windows.Forms.Button BtnCerrarCaja;
        private System.Windows.Forms.ToolStripStatusLabel LblTotal;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Panel LstProductos;
    }
}

