using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmRegistrarProducto : Form
    {
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtReferenciaProducto.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir la referencia del producto");
            }
            else if (TxtNombreProducto.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir el nombre del producto");
            }
            else if (CmbExistProducto.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar la existencia del producto");
            }
            else if (TxtPrecioProducto.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir el precio del producto");
            }
            else if (CmbEstadoProducto.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger el estado del producto");
            }
            else if (TxtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir la cantidad a registrar");
            }
            
            Registrar();
        }

        private void Registrar()
        {
            try
            {
                Producto producto = new(TxtReferenciaProducto.Text, TxtNombreProducto.Text, CmbExistProducto.Text, decimal.Parse(TxtPrecioProducto.Text), CmbEstadoProducto.Text, int.Parse(TxtCantidad.Text));
                ProductoService service = new();
                string mensaje = service.Guardar(producto);
                MessageBox.Show(mensaje, "Se Registro Exitosamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al momento de guardar!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 47))
            {
                MessageBox.Show("Solo se aceptan números", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
