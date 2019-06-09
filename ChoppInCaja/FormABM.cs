using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoppInCaja
{
	public partial class FormABM : Form
	{
		public FormABM(List<string> tablas)
		{
			InitializeComponent();

			CboTablas.DataSource = tablas;
		}

		private string TablaNombre => CboTablas.SelectedValue?.ToString();

		private void CboTablas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TablaNombre != null)
			{
				RefrescarTabla();
			}
		}

		private void RefrescarTabla()
		{
            try {
			using (var context = new ChoppinEntities())
			{
				var contextTabla = context.GetType().GetProperty(TablaNombre);
				var data = contextTabla.GetValue(context);
				var datos = ((IEnumerable<object>)data).ToList();
				var registros = datos;
				GridTabla.AutoGenerateColumns = true;
				GridTabla.DataSource = registros;
				GridTabla.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void GridTabla_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void GridTabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var registro = GridTabla.Rows[e.RowIndex].DataBoundItem;
			using (var context = new ChoppinEntities())
			{
				var contextTabla = context.GetType().GetProperty(TablaNombre);
				var data = contextTabla.GetValue(context);
				var methodAdd = data.GetType().GetMethod("Add");
				methodAdd.Invoke(data, new []{ registro } );
				context.Entry(registro).State = EntityState.Modified;
				var count = context.SaveChanges();
				lblEstado.Text = $"Actualizado {DateTime.Now} - {count}";
			}
		}

		private void BtnAgregar_Click(object sender, EventArgs e)
		{
			using (var context = new ChoppinEntities())
			{
				var contextTabla = context.GetType().GetProperty(TablaNombre);
				var data = contextTabla.GetValue(context);
				var typeData = data.GetType().GenericTypeArguments[0];
				var registro = Activator.CreateInstance(GridTabla.Rows[0].DataBoundItem.GetType());
				var registros = ((IList<object>)GridTabla.DataSource);
				registros.Add(registro);
				GridTabla.DataSource = registros;
				GridTabla.Refresh();
			}
		}

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ChoppinEntities())
                {
                    context.Database.ExecuteSqlCommand(TxtSql.Text);
                }
                RefrescarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMostrarSQL_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ChoppinEntities())
                {
                    var connection = context.Database.Connection;
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        var dt = new DataTable();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = TxtSql.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            GridTabla.DataSource = dt;
                            GridTabla.Refresh();
                        }
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
