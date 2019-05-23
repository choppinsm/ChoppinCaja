using ChoppInCaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			GridMesas.AutoGenerateColumns = true;
			gridMesaDetalle.AutoGenerateColumns = false;
			var columns = gridMesaDetalle.Columns;
			var column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Id";
			column.ReadOnly = true;
			column.Width = 50;
			columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Cant";
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
			column.ReadOnly = true;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Precio";
			column.ValueType = typeof(decimal);
			column.ReadOnly = true;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "PxC";
			column.ValueType = typeof(decimal);
			column.ReadOnly = true;
			columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Diferencia";
			column.ValueType = typeof(decimal);
			columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "AplicaDiferencia";
			column.ValueType = typeof(decimal);
			columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = column.HeaderText = column.Name = "Motivo";
			column.ValueType = typeof(decimal);
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
			if(mesa.IdMesa == ultimaIdMesaSeleccionada)
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
				else {
					RefrescarMesa(ventaAbierta.IdVenta);
				}
			}
		}

		private void RefrescarMesa(int idVenta)
		{
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
				if(registros.Count == 0)
				{
					registros.Add(NuevoItem(idVenta));
				}
				gridMesaDetalle.DataSource = registros;
				MostrarDetalle();
			}
		}

		private static VentaDetalleVM NuevoItem(int idVenta)
		{
			return new VentaDetalleVM
			{
				IdVenta = idVenta,
				Cantidad = 1,
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
				}
				RefrescarMesa(ventaAbierta.IdVenta);
			}else{
				OcultarDetalle();
			}
		}

		private void OcultarDetalle()
		{
			gridMesaDetalle.Hide();
		}

		private void MostrarDetalle()
		{
			gridMesaDetalle.Show();
		}

		private void BtnAgregarItem_Click(object sender, EventArgs e)
		{
			var items = (List<VentasDetalle>)gridMesaDetalle.DataSource;
			var idVenta = items[0].IdVenta;

			//var idVenta = ((Mesas)GridMesas[0, 0]).IdVenta);
			//((List<VentasDetalle>)gridMesaDetalle.DataSource).Add(nuevoItem(1));
		}

		private void gridMesaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void gridMesaDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (gridMesaDetalle.CurrentCell.ColumnIndex == 2)
			{
				ComboBox cmbox = e.Control as ComboBox;
				cmbox.SelectedValueChanged -= GridMesaDetalle_CboProducto_SelectedValueChanged;
				cmbox.SelectedValueChanged += GridMesaDetalle_CboProducto_SelectedValueChanged;
			}
		}

		private void GridMesaDetalle_CboProducto_SelectedValueChanged(object sender, EventArgs e)
		{
			var idxProducto = ((DataGridViewComboBoxEditingControl)sender).SelectedIndex;
			var producto = productos[idxProducto];
			var idxItem = gridMesaDetalle.SelectedCells[0].RowIndex;
			((VentaDetalleVM)gridMesaDetalle.Rows[idxItem].DataBoundItem).Precio = producto.Precio;
		}

		private void gridMesaDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			var idxItem = gridMesaDetalle.SelectedCells[0].RowIndex;
			var item = ((VentaDetalleVM)gridMesaDetalle.Rows[idxItem].DataBoundItem);
			if(item.IdVentaDetalle == 0)
			{
				using (var context = new ChoppinEntities()){
					context.VentasDetalles.Add(new VentasDetalle
					{
						IdVenta = item.IdVenta,
						IdProducto = item.IdProducto,
						Cantidad = item.Cantidad,
						Precio = item.Precio,
						Diferencia = item.Diferencia,
						DiferenciaIdAplica = (int?)item.AplicaDiferencia,
						DiferenciaMotivo = item.Motivo,
						Fecha = DateTime.Now
					});
				}
			}
		}
	}
}
