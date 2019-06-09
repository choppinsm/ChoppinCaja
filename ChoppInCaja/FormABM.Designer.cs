namespace ChoppInCaja
{
	partial class FormABM
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
            this.GridTabla = new System.Windows.Forms.DataGridView();
            this.CboTablas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.BtnMostrarSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTabla
            // 
            this.GridTabla.AllowDrop = true;
            this.GridTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTabla.Location = new System.Drawing.Point(18, 60);
            this.GridTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridTabla.Name = "GridTabla";
            this.GridTabla.Size = new System.Drawing.Size(1164, 468);
            this.GridTabla.TabIndex = 0;
            this.GridTabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTabla_CellEndEdit);
            this.GridTabla.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridTabla_DataError);
            // 
            // CboTablas
            // 
            this.CboTablas.FormattingEnabled = true;
            this.CboTablas.Location = new System.Drawing.Point(123, 18);
            this.CboTablas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboTablas.Name = "CboTablas";
            this.CboTablas.Size = new System.Drawing.Size(390, 28);
            this.CboTablas.TabIndex = 1;
            this.CboTablas.SelectedIndexChanged += new System.EventHandler(this.CboTablas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tablas";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(18, 658);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 20);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "label2";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(1146, 15);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(36, 35);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEjecutar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjecutar.Location = new System.Drawing.Point(18, 618);
            this.BtnEjecutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(154, 35);
            this.BtnEjecutar.TabIndex = 5;
            this.BtnEjecutar.Text = "Ejecutar SQL";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // TxtSql
            // 
            this.TxtSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSql.Location = new System.Drawing.Point(18, 537);
            this.TxtSql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.Size = new System.Drawing.Size(1162, 70);
            this.TxtSql.TabIndex = 6;
            this.TxtSql.Text = "INSERT INTO Productos(IdProducto, Nombre, Precio)\r\nVALUES(5, \'producto\', 1)";
            // 
            // BtnMostrarSQL
            // 
            this.BtnMostrarSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMostrarSQL.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarSQL.Location = new System.Drawing.Point(215, 618);
            this.BtnMostrarSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMostrarSQL.Name = "BtnMostrarSQL";
            this.BtnMostrarSQL.Size = new System.Drawing.Size(154, 35);
            this.BtnMostrarSQL.TabIndex = 7;
            this.BtnMostrarSQL.Text = "Mostrar SQL";
            this.BtnMostrarSQL.UseVisualStyleBackColor = true;
            this.BtnMostrarSQL.Click += new System.EventHandler(this.BtnMostrarSQL_Click);
            // 
            // FormABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnMostrarSQL);
            this.Controls.Add(this.TxtSql);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTablas);
            this.Controls.Add(this.GridTabla);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormABM";
            this.Text = "ABM";
            ((System.ComponentModel.ISupportInitialize)(this.GridTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridTabla;
		private System.Windows.Forms.ComboBox CboTablas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Button BtnAgregar;
		private System.Windows.Forms.Button BtnEjecutar;
		private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.Button BtnMostrarSQL;
    }
}