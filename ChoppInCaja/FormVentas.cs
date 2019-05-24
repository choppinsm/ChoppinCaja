using ChoppInCaja.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ChoppInCaja
{
	public partial class FormVentas : Form
	{
		public FormVentas(List<Mesa> mesas, List<Producto> productos)
		{
			this.mesas = mesas;
			this.productos = productos;
			InitializeComponent();

			CboVentas.ValueMember = "IdVenta";
			CboVentas.DisplayMember = "IdVenta";
			RefrescarCboVentas();
			CboVentas.SelectedItem = null;
			CboVentas.Text = "";

			GridMesas.AutoGenerateColumns = false;
			var columns = GridMesas.Columns;
			var column = new DataGridViewTextBoxColumn();
			column.HeaderText = column.Name = "Id";
			column.DataPropertyName = "IdMesa";
			column.ReadOnly = true;
			column.Width = 50;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.HeaderText = column.Name = "Mesa";
			column.DataPropertyName = "Nombre";
			column.ReadOnly = true;
			column.Width = 150;
			columns.Add(column);

			gridMesaDetalle.AutoGenerateColumns = false;
			gridMesaDetalle.EnableHeadersVisualStyles = false;
			columns = gridMesaDetalle.Columns;
			column = new DataGridViewTextBoxColumn();
			column.HeaderText = column.Name = "Id";
			column.DataPropertyName = "IdVentaDetalle";
			column.ReadOnly = true;
			column.Width = 50;
			columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.HeaderText = column.Name = "Cant";
			column.DataPropertyName = "Cantidad";
			column.ValueType = typeof(int);
			column.Width = 100;
			columns.Add(column);

			var cmb = new DataGridViewComboBoxColumn();
			cmb.HeaderText = "Producto";
			cmb.ValueMember = "IdProducto";
			cmb.DisplayMember = "Nombre";
			cmb.DataPropertyName = "IdProducto";
			cmb.MaxDropDownItems = 5;
			cmb.DataSource = productos;
			columns.Add(cmb);


			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Importe";
			column.ValueType = typeof(decimal);
			column.DefaultCellStyle.Format = "C2";
			column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
			column.ReadOnly = true;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Precio";
			column.ValueType = typeof(decimal);
			column.DefaultCellStyle.Format = "C2";
			column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
			column.ReadOnly = true;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "PxC";
			column.ValueType = typeof(decimal);
			column.DefaultCellStyle.Format = "C2";
			column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
			column.ReadOnly = true;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Diferencia";
			column.ValueType = typeof(decimal);
			column.DefaultCellStyle.Format = "C2";
			column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
			columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "AplicaDiferencia";
			column.ValueType = typeof(decimal);
			column.DefaultCellStyle.Format = "C2";
			column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
			column.Visible = false;
			columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Motivo";
			column.ValueType = typeof(decimal);
			column.DefaultCellStyle.Format = "C2";
			column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
			columns.Add(column);
		}

		private void Ventas_Load(object sender, EventArgs e)
		{
			GridMesas.DataSource = mesas;
		}

		private int ultimaIdMesaSeleccionada = -1;
		private List<Mesa> mesas;
		private List<Producto> productos;

		private void GridMesas_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var mesa = (Mesa)GridMesas.Rows[e.RowIndex].DataBoundItem;
			if (mesa.IdMesa == ultimaIdMesaSeleccionada)
			{
				return;
			}
			ultimaIdMesaSeleccionada = mesa.IdMesa;
			using (var context = new ChoppinEntities())
			{
				var ventaAbierta = (from venta in context.Ventas
									where venta.IdMesa == mesa.IdMesa && venta.Cierre == null
									select venta
								   ).FirstOrDefault();
				if (ventaAbierta == null)
				{
					BeginInvoke((Action)(() =>
					{
						AgregarVenta(mesa.IdMesa);
					}));
				}
				else
				{
					RefrescarVenta(ventaAbierta.IdVenta);
				}
			}
		}

		private void RefrescarVenta(int idVenta)
		{
			lblEstado.Text = $"IdVenta = {idVenta}";
			using (var context = new ChoppinEntities())
			{
				var venta = from item in context.VentasDetalles
							where item.IdVenta == idVenta
							select new VentaDetalleVM
							{
								IdVentaDetalle = item.IdVentaDetalle,
								IdVenta = item.IdVenta,
								IdProducto = item.IdProducto,
								Precio = item.Precio,
								Cantidad = item.Cantidad,
								Diferencia = item.Diferencia,
								AplicaDiferencia = (Equipo?)item.DiferenciaIdAplica,
								Motivo = item.DiferenciaMotivo,
								Fecha = item.Fecha
							};
				var registros = venta.ToList();
				registros.Add(NuevoItem(idVenta));
				gridMesaDetalle.DataSource = registros;
				MostrarDetalle();
			}
		}

		private static VentaDetalleVM NuevoItem(int idVenta)
		{
			return new VentaDetalleVM
			{
				IdVenta = idVenta,
				Cantidad = 0,
				IdProducto = 0,
				Diferencia = 0,
				Precio = 0,
				Fecha = DateTime.Now
			};
		}

		private void AgregarVenta(int idMesa)
		{
			var confirmResult = MessageBox.Show(this, "¿Abrir la mesa?", "Confirm Delete!!", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				var ventaAbierta = new Venta
				{
					Apertura = DateTime.Now,
					IdMesa = idMesa
				};
				using (var context = new ChoppinEntities())
				{
					context.Ventas.Add(ventaAbierta);
					context.SaveChanges();
					RefrescarCboVentas();
					CboVentas.SelectedItem = null;
					CboVentas.Text = "";
				}
				RefrescarVenta(ventaAbierta.IdVenta);
			}
			else
			{
				OcultarDetalle();
			}
		}

		private void OcultarDetalle()
		{
			gridMesaDetalle.Hide();
			lblEstado.Text = "";
			lblTotal.Text = "$";
		}

		private void MostrarDetalle()
		{
			gridMesaDetalle.Show();
			RefrescarDetalle();
		}

		private void gridMesaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void gridMesaDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (gridMesaDetalle.CurrentCell.ColumnIndex == 2)
			{
				ComboBox cmbox = e.Control as ComboBox;
				try {
					cmbox.SelectedValueChanged -= GridMesaDetalle_CboProducto_SelectedValueChanged;
				}
				catch { }
				try {
					cmbox.SelectedValueChanged += GridMesaDetalle_CboProducto_SelectedValueChanged;
				}
				catch { }
			}
		}

		private void GridMesaDetalle_CboProducto_SelectedValueChanged(object sender, EventArgs e)
		{
			var idxProducto = ((DataGridViewComboBoxEditingControl)sender).SelectedIndex;
			if (idxProducto < 0)
				return;
			var producto = productos[idxProducto];
			var idxItem = gridMesaDetalle.SelectedCells[0].RowIndex;
			((VentaDetalleVM)gridMesaDetalle.Rows[idxItem].DataBoundItem).Precio = producto.Precio;
		}

		private void gridMesaDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			var idxItem = gridMesaDetalle.SelectedCells[0].RowIndex;
			var items = ((List<VentaDetalleVM>)gridMesaDetalle.DataSource);
			var item = items[idxItem];
			try
			{
				using (var context = new ChoppinEntities())
				{
					VentasDetalle itemActual;
					if (item.IdVentaDetalle == 0)
					{
						itemActual = new VentasDetalle
						{
							IdVenta = item.IdVenta,
							IdProducto = item.IdProducto,
							Cantidad = item.Cantidad,
							Precio = item.Precio,
							Diferencia = item.Diferencia,
							DiferenciaIdAplica = (int?)item.AplicaDiferencia,
							DiferenciaMotivo = item.Motivo,
							Fecha = DateTime.Now
						};
						context.VentasDetalles.Add(itemActual);
					}
					else
					{
						itemActual = context.VentasDetalles
							.Single(v => v.IdVentaDetalle == item.IdVentaDetalle);
						itemActual.IdProducto = item.IdProducto;
						itemActual.Cantidad = item.Cantidad;
						itemActual.Precio = item.Precio;
						itemActual.Diferencia = item.Diferencia;
						itemActual.DiferenciaIdAplica = (int?)item.AplicaDiferencia;
						itemActual.DiferenciaMotivo = item.Motivo;
						itemActual.Fecha = DateTime.Now;
					}
					context.SaveChanges();
					item.IdVentaDetalle = itemActual.IdVentaDetalle;
					item.Fecha = itemActual.Fecha;
					RefrescarDetalle();

					var header = gridMesaDetalle.Rows[idxItem].HeaderCell;
					header.Value = "C";
				}
			}
			catch
			{
				gridMesaDetalle.Rows[idxItem].HeaderCell.Value = "!";
			}
		}

		private void RefrescarDetalle()
		{
			gridMesaDetalle.Refresh();
			var items = ((List<VentaDetalleVM>)gridMesaDetalle.DataSource);
			lblTotal.Text = items.Sum(i => i.Importe).ToString("C2", new CultureInfo("es-AR"));
			lblEstado.Text = $"IdVenta:{items[0].IdVenta}, diferencia: {items.Sum(i => i.Diferencia).ToString("C2", new CultureInfo("es-AR"))}";
		}

		private void GridMesas_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void btnCerrarMesa_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show(this, "¿Cerrar la mesa? \r\nPor favor solo cerrar cuando se haya pagado", "Mesa", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				var idVenta = ((VentaDetalleVM)gridMesaDetalle.Rows[0].DataBoundItem).IdVenta;
				using (var context = new ChoppinEntities())
				{
					var venta = context.Ventas
						.Single(v => v.IdVenta == idVenta)
						.Cierre = DateTime.Now;
					context.SaveChanges();
					OcultarDetalle();
					RefrescarCboVentas();
				}
			}
		}

		private void RefrescarCboVentas()
		{
			using (var context = new ChoppinEntities())
			{
				var ventas = context.Ventas.ToList();
				ventas.Insert(0, new Venta
				{
					IdVenta = 0
				});
				CboVentas.DataSource = context.Ventas.ToList();
				RefrescarVenta(0);
			}
		}

		private void CboVentas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CboVentas.SelectedItem != null)
			{
				var idVenta = ((Venta)CboVentas.SelectedItem).IdVenta;
				RefrescarVenta(idVenta);
				MostrarDetalle();
			}
		}
	}
}
