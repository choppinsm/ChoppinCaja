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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMesaDetalle = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAbrirCerrarMesa = new System.Windows.Forms.Button();
            this.CboVentas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnABM = new System.Windows.Forms.Button();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            this.GridMesas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMesaDetalle
            // 
            this.gridMesaDetalle.AllowDrop = true;
            this.gridMesaDetalle.AllowUserToOrderColumns = true;
            this.gridMesaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMesaDetalle.BackgroundColor = System.Drawing.Color.Black;
            this.gridMesaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMesaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMesaDetalle.GridColor = System.Drawing.Color.Black;
            this.gridMesaDetalle.Location = new System.Drawing.Point(14, 449);
            this.gridMesaDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridMesaDetalle.Name = "gridMesaDetalle";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMesaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMesaDetalle.RowHeadersWidth = 70;
            this.gridMesaDetalle.RowTemplate.Height = 40;
            this.gridMesaDetalle.Size = new System.Drawing.Size(1318, 165);
            this.gridMesaDetalle.TabIndex = 2;
            this.gridMesaDetalle.DataSourceChanged += new System.EventHandler(this.gridMesaDetalle_DataSourceChanged);
            this.gridMesaDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMesaDetalle_CellEndEdit);
            this.gridMesaDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridMesaDetalle_DataError);
            this.gridMesaDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridMesaDetalle_EditingControlShowing);
            this.gridMesaDetalle.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridMesaDetalle_NewRowNeeded);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 690);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1344, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Black;
            this.lblEstado.ForeColor = System.Drawing.Color.Lime;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 16F);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(229, 633);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 37);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$";
            // 
            // btnAbrirCerrarMesa
            // 
            this.btnAbrirCerrarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirCerrarMesa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCerrarMesa.Location = new System.Drawing.Point(14, 622);
            this.btnAbrirCerrarMesa.Name = "btnAbrirCerrarMesa";
            this.btnAbrirCerrarMesa.Size = new System.Drawing.Size(188, 54);
            this.btnAbrirCerrarMesa.TabIndex = 5;
            this.btnAbrirCerrarMesa.Text = "Cerrar Mesa";
            this.btnAbrirCerrarMesa.UseVisualStyleBackColor = true;
            this.btnAbrirCerrarMesa.Click += new System.EventHandler(this.btnAbrirCerrarMesa_Click);
            // 
            // CboVentas
            // 
            this.CboVentas.FormattingEnabled = true;
            this.CboVentas.Location = new System.Drawing.Point(496, 14);
            this.CboVentas.Name = "CboVentas";
            this.CboVentas.Size = new System.Drawing.Size(286, 28);
            this.CboVentas.TabIndex = 6;
            this.CboVentas.SelectedIndexChanged += new System.EventHandler(this.CboVentas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ventas:";
            // 
            // BtnABM
            // 
            this.BtnABM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnABM.AutoSize = true;
            this.BtnABM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnABM.BackColor = System.Drawing.Color.Red;
            this.BtnABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnABM.ForeColor = System.Drawing.Color.White;
            this.BtnABM.Location = new System.Drawing.Point(1290, 629);
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
            this.BtnCerrarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Location = new System.Drawing.Point(1095, 622);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(188, 54);
            this.BtnCerrarCaja.TabIndex = 9;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // GridMesas
            // 
            this.GridMesas.AllowDrop = true;
            this.GridMesas.AllowUserToOrderColumns = true;
            this.GridMesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMesas.BackgroundColor = System.Drawing.Color.Black;
            this.GridMesas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMesas.GridColor = System.Drawing.Color.Black;
            this.GridMesas.Location = new System.Drawing.Point(13, 304);
            this.GridMesas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridMesas.Name = "GridMesas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridMesas.RowHeadersWidth = 70;
            this.GridMesas.RowTemplate.Height = 40;
            this.GridMesas.Size = new System.Drawing.Size(88, 135);
            this.GridMesas.TabIndex = 10;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.GridMesas);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.BtnABM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboVentas);
            this.Controls.Add(this.btnAbrirCerrarMesa);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridMesaDetalle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridMesaDetalle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAbrirCerrarMesa;
        private System.Windows.Forms.ComboBox CboVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnABM;
        private System.Windows.Forms.Button BtnCerrarCaja;
        private System.Windows.Forms.DataGridView GridMesas;
    }
}

