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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridMesas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gridMesaDetalle = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAbrirCerrarMesa = new System.Windows.Forms.Button();
            this.CboVentas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnABM = new System.Windows.Forms.Button();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridMesas
            // 
            this.GridMesas.AllowUserToAddRows = false;
            this.GridMesas.AllowUserToDeleteRows = false;
            this.GridMesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridMesas.BackgroundColor = System.Drawing.Color.Black;
            this.GridMesas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMesas.GridColor = System.Drawing.Color.Black;
            this.GridMesas.Location = new System.Drawing.Point(14, 46);
            this.GridMesas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridMesas.MultiSelect = false;
            this.GridMesas.Name = "GridMesas";
            this.GridMesas.ReadOnly = true;
            this.GridMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMesas.Size = new System.Drawing.Size(320, 615);
            this.GridMesas.TabIndex = 0;
            this.GridMesas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridMesas_DataError);
            this.GridMesas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMesas_RowEnter);
            this.GridMesas.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridMesas_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesas:";
            // 
            // gridMesaDetalle
            // 
            this.gridMesaDetalle.AllowDrop = true;
            this.gridMesaDetalle.AllowUserToOrderColumns = true;
            this.gridMesaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMesaDetalle.BackgroundColor = System.Drawing.Color.Black;
            this.gridMesaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMesaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMesaDetalle.GridColor = System.Drawing.Color.Black;
            this.gridMesaDetalle.Location = new System.Drawing.Point(340, 46);
            this.gridMesaDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridMesaDetalle.Name = "gridMesaDetalle";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMesaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMesaDetalle.RowHeadersWidth = 70;
            this.gridMesaDetalle.RowTemplate.Height = 40;
            this.gridMesaDetalle.Size = new System.Drawing.Size(1185, 615);
            this.gridMesaDetalle.TabIndex = 2;
            this.gridMesaDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridMesaDetalle_DataError);
            this.gridMesaDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridMesaDetalle_EditingControlShowing);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 763);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1538, 22);
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
            this.lblTotal.Location = new System.Drawing.Point(352, 676);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 37);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$";
            // 
            // btnAbrirCerrarMesa
            // 
            this.btnAbrirCerrarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirCerrarMesa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCerrarMesa.Location = new System.Drawing.Point(22, 669);
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
            this.BtnABM.Location = new System.Drawing.Point(1156, 675);
            this.BtnABM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnABM.Name = "BtnABM";
            this.BtnABM.Size = new System.Drawing.Size(254, 48);
            this.BtnABM.TabIndex = 8;
            this.BtnABM.Text = "ABM";
            this.BtnABM.UseVisualStyleBackColor = true;
            this.BtnABM.Click += new System.EventHandler(this.BtnABM_Click);
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Location = new System.Drawing.Point(939, 675);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(188, 54);
            this.BtnCerrarCaja.TabIndex = 9;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1538, 785);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.BtnABM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboVentas);
            this.Controls.Add(this.btnAbrirCerrarMesa);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridMesaDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridMesas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridMesaDetalle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAbrirCerrarMesa;
        private System.Windows.Forms.ComboBox CboVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnABM;
        private System.Windows.Forms.Button BtnCerrarCaja;
    }
}

