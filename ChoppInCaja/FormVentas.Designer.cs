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
			this.GridMesas = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.gridMesaDetalle = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.GridMesas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).BeginInit();
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
			this.GridMesas.Location = new System.Drawing.Point(12, 30);
			this.GridMesas.MultiSelect = false;
			this.GridMesas.Name = "GridMesas";
			this.GridMesas.ReadOnly = true;
			this.GridMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridMesas.Size = new System.Drawing.Size(210, 196);
			this.GridMesas.TabIndex = 0;
			this.GridMesas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMesas_RowEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 18);
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
			this.gridMesaDetalle.Location = new System.Drawing.Point(228, 30);
			this.gridMesaDetalle.Name = "gridMesaDetalle";
			this.gridMesaDetalle.Size = new System.Drawing.Size(421, 196);
			this.gridMesaDetalle.TabIndex = 2;
			this.gridMesaDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMesaDetalle_CellValueChanged);
			this.gridMesaDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridMesaDetalle_DataError);
			this.gridMesaDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridMesaDetalle_EditingControlShowing);
			// 
			// FormVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(661, 238);
			this.Controls.Add(this.gridMesaDetalle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GridMesas);
			this.Name = "FormVentas";
			this.Text = "Mesas";
			this.Load += new System.EventHandler(this.Ventas_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridMesas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridMesaDetalle;
    }
}

