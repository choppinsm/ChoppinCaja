namespace ChoppInCaja
{
    partial class Ventas
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
            this.gridMesas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gridMesaDetalle = new System.Windows.Forms.DataGridView();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMesas
            // 
            this.gridMesas.AllowUserToAddRows = false;
            this.gridMesas.AllowUserToDeleteRows = false;
            this.gridMesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridMesas.BackgroundColor = System.Drawing.Color.Black;
            this.gridMesas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMesas.GridColor = System.Drawing.Color.Black;
            this.gridMesas.Location = new System.Drawing.Point(12, 30);
            this.gridMesas.MultiSelect = false;
            this.gridMesas.Name = "gridMesas";
            this.gridMesas.ReadOnly = true;
            this.gridMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMesas.Size = new System.Drawing.Size(210, 408);
            this.gridMesas.TabIndex = 0;
            this.gridMesas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMesas_RowEnter);
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
            this.gridMesaDetalle.Location = new System.Drawing.Point(228, 37);
            this.gridMesaDetalle.Name = "gridMesaDetalle";
            this.gridMesaDetalle.Size = new System.Drawing.Size(560, 375);
            this.gridMesaDetalle.TabIndex = 2;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(759, 8);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(29, 23);
            this.btnAgregarItem.TabIndex = 3;
            this.btnAgregarItem.Text = "+";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.gridMesaDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMesas);
            this.Name = "Ventas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridMesaDetalle;
        private System.Windows.Forms.Button btnAgregarItem;
    }
}

