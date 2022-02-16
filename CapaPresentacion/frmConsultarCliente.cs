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
    public partial class frmConsultarCliente : Form
    {

        ClsCliente Al;
        List<Object> lst_cliente_tmp;
        String rutaimagen;
        frmActualizarCliente frmActualizar = new frmActualizarCliente();

        public frmConsultarCliente()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        public frmConsultarCliente(ClsCliente Al)
        {
            InitializeComponent();
            this.Al = Al;
            this.lst_cliente_tmp = Al.listar();
            llenar_datagridview_alumnos();
            buttonactualizar.Enabled = false;

        }

        public void llenar_datagridview_alumnos()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var cliente in lst_cliente_tmp)
            {
                System.Type type = cliente.GetType();
                Int16 Id_Cliente = (Int16)type.GetProperty("Id_Cliente").GetValue(cliente);
                String cedula = (String)type.GetProperty("cedula").GetValue(cliente);
                String nombre = (String)type.GetProperty("nombre").GetValue(cliente);
                String apellido = (String)type.GetProperty("apellido").GetValue(cliente);
                Int16 edad = (Int16)type.GetProperty("edad").GetValue(cliente);
                String domicilio = (String)type.GetProperty("domicilio").GetValue(cliente);
                String sexo = (String)type.GetProperty("sexo").GetValue(cliente);
                String imagen = (String)type.GetProperty("imagen").GetValue(cliente);
                String codigoCliente = (String)type.GetProperty("codigoCliente").GetValue(cliente);


                dgv_listarTodos.Rows.Add(Id_Cliente, cedula, nombre, apellido, edad, domicilio, sexo, imagen, codigoCliente);
            }

        }
        /// <summary>
        /// Metodo para buscar un cliente mediante un parametro solicitado que es la cedula.
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
                      
                        Int16 Id_Cliente = (Int16)type.GetProperty("Id_Cliente").GetValue(cliente);
                        String cedula = (String)type.GetProperty("cedula").GetValue(cliente);
                        String nombre = (String)type.GetProperty("nombre").GetValue(cliente);
                        String apellido = (String)type.GetProperty("apellido").GetValue(cliente);
                        Int16 edad = (Int16)type.GetProperty("edad").GetValue(cliente);
                        String domicilio = (String)type.GetProperty("domicilio").GetValue(cliente);
                        String sexo = (String)type.GetProperty("sexo").GetValue(cliente);
                        String imagen = (String)type.GetProperty("imagen").GetValue(cliente);
                        String codigoCliente = (String)type.GetProperty("codigoCliente").GetValue(cliente);


                        dgv_listarTodos.Rows.Add(Id_Cliente,cedula, nombre, apellido, edad, domicilio, sexo, imagen, codigoCliente);
                        buttonactualizar.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            this.lst_cliente_tmp = Al.listar();
            llenar_datagridview_alumnos();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCliente frmEst = new frmCliente(Al);
            frmEst.Show();
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

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            buttonactualizar.Enabled = false;
            frmActualizar = new frmActualizarCliente(dgv_listarTodos.CurrentRow.Cells[0].Value.ToString(), Al);
            frmActualizar.ShowDialog();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            buttonactualizar.Enabled = false;
        }
    }


}
