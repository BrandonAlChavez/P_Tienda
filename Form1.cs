using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace Tienda
{
    public partial class Form1 : Form
    {
        ManejadorProducto mp;
        public Form1()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
            if (ConsultarP.id_producto > 0)
            {
                txtNombre.Text = ConsultarP.nombre;
                txtDescripcion.Text = ConsultarP.descripcion;
                txtPrecio.Text = ConsultarP.precio.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ConsultarP.id_producto > 0)
            {
                mp.Modificar(ConsultarP.id_producto, txtNombre, txtDescripcion, txtPrecio);
            }
            else
            {
                mp.Guardar(txtNombre, txtDescripcion, txtPrecio);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
