using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Manejador.ManejaadorProductos;

namespace ProyectoTienda
{
    public partial class FrmProductos : Form
    {
        ManejadorProductos me;
        public FrmProductos()
        {
            InitializeComponent();
            me = new ManejadorProductos();
            if (FrmAgregarProductos.producto._Idproductos > 0)
            {
                txtNombre.Text = FrmAgregarProductos.producto._Nombre.ToString();
                txtDescripcion.Text = FrmAgregarProductos.producto._Descripcion.ToString();
                txtPrecio.Text = FrmAgregarProductos.producto._Precio.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (FrmAgregarProductos.producto._Idproductos > 0)
            {
                me.Modificar(new Productos(FrmAgregarProductos.producto._Idproductos,
                txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text)));
            }
            else
            {
                MessageBox.Show(me.Guardar(new Productos(0, txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text))));
            }
            Close();
        }
    }
}
