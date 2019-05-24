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
			((System.ComponentModel.ISupportInitialize)(this.GridTabla)).BeginInit();
			this.SuspendLayout();
			// 
			// GridTabla
			// 
			this.GridTabla.AllowDrop = true;
			this.GridTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridTabla.Location = new System.Drawing.Point(12, 39);
			this.GridTabla.Name = "GridTabla";
			this.GridTabla.Size = new System.Drawing.Size(776, 304);
			this.GridTabla.TabIndex = 0;
			this.GridTabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTabla_CellEndEdit);
			this.GridTabla.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridTabla_DataError);
			// 
			// CboTablas
			// 
			this.CboTablas.FormattingEnabled = true;
			this.CboTablas.Location = new System.Drawing.Point(82, 12);
			this.CboTablas.Name = "CboTablas";
			this.CboTablas.Size = new System.Drawing.Size(261, 21);
			this.CboTablas.TabIndex = 1;
			this.CboTablas.SelectedIndexChanged += new System.EventHandler(this.CboTablas_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tablas";
			// 
			// lblEstado
			// 
			this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(12, 428);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(35, 13);
			this.lblEstado.TabIndex = 3;
			this.lblEstado.Text = "label2";
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAgregar.Location = new System.Drawing.Point(764, 10);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(24, 23);
			this.BtnAgregar.TabIndex = 4;
			this.BtnAgregar.Text = "+";
			this.BtnAgregar.UseVisualStyleBackColor = true;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// BtnEjecutar
			// 
			this.BtnEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnEjecutar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEjecutar.Location = new System.Drawing.Point(12, 402);
			this.BtnEjecutar.Name = "BtnEjecutar";
			this.BtnEjecutar.Size = new System.Drawing.Size(103, 23);
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
			this.TxtSql.Location = new System.Drawing.Point(12, 349);
			this.TxtSql.Multiline = true;
			this.TxtSql.Name = "TxtSql";
			this.TxtSql.Size = new System.Drawing.Size(776, 47);
			this.TxtSql.TabIndex = 6;
			this.TxtSql.Text = "INSERT INTO Productos(IdProducto, Nombre, Precio)\r\nVALUES(5, \'producto\', 1)";
			// 
			// FormABM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TxtSql);
			this.Controls.Add(this.BtnEjecutar);
			this.Controls.Add(this.BtnAgregar);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CboTablas);
			this.Controls.Add(this.GridTabla);
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
	}
}