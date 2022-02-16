 using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEliminarClientecs : Form
    {


        ClsCliente Al = new ClsCliente();
        List<Object> lst_cliente_tmp;

        public frmEliminarClientecs(ClsCliente Al)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Al = Al;
            btn_eliminar.Enabled = false;
        }
        /// <summary>
        /// Metedo para eliminar un cliente mediante la cedula.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnbuscar_Click(object sender, EventArgs e)
        {

            try
            {
                dgv_listarTodos.Rows.Clear();
                dgv_listarTodos.Refresh();

                lst_cliente_tmp = Al.buscar(txtcedula.Text);

                foreach (var cliente in lst_cliente_tmp)
                {
                    if (cliente != null)
                    {
                        System.Type type = cliente.GetType();

                        String cedula = (String)type.GetProperty("cedula").GetValue(cliente);
                        String nombre = (String)type.GetProperty("nombre").GetValue(cliente);
                        String apellido = (String)type.GetProperty("apellido").GetValue(cliente);
                        Int16 edad = (Int16)type.GetProperty("edad").GetValue(cliente);
                        String domicilio = (String)type.GetProperty("domicilio").GetValue(cliente);
                        String sexo = (String)type.GetProperty("sexo").GetValue(cliente);
                        String imagen = (String)type.GetProperty("imagen").GetValue(cliente);
                        String codigoCliente = (String)type.GetProperty("codigoCliente").GetValue(cliente);


                        dgv_listarTodos.Rows.Add(cedula, nombre, apellido, edad, domicilio, sexo, imagen, codigoCliente);
                        btn_eliminar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            Al.eliminar(txtcedula.Text);
            btn_eliminar.Enabled = false;
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente frmEst = new frmCliente(Al);
            frmEst.Show();

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = false;
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
