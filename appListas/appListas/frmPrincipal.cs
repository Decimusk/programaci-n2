using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = Productos;
        }

        private void reseteo()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvListado.SelectedRows[0];
            int posicion = dgvListado.Rows.IndexOf(selected);
            edit_indice = posicion;

            Producto product = Productos[posicion];

            txtNombre.Text = product.Nombre;
            txtDescripcion.Text = product.Descripcion;
            txtMarca.Text = product.Marca;
            txtPrecio.Text = Convert.ToString(product.Precio);
            txtStock.Text = Convert.ToString(product.Stock);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto product = new Producto();
            product.Nombre = txtNombre.Text;
            product.Descripcion = txtDescripcion.Text;
            product.Marca = txtMarca.Text;
            product.Precio = float.Parse(txtPrecio.Text);
            product.Stock = int.Parse(txtStock.Text);

            if (edit_indice > -1)
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product);
            }

            actualizarGrid();
            reseteo();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1;
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble Clic sobre algun elemento");
            }
        }
    }
}
