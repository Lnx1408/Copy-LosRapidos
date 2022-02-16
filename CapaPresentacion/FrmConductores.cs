using System;
using CapaNegocio;
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
    public partial class FrmConductores : Form
    {
        ClsConductores chofer = new ClsConductores();
        List<Object> lstConductor = new List<Object>();
        frmCliente metodosAux = new frmCliente(); //para llamar a los metodos 'SoloNumeros' y 'SoloLetras'
        
        public FrmConductores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                chofer.Cedula = txtCedula.Text;
                chofer.Nombre = txtNombre.Text;
                chofer.Apellido = txtApellido.Text;
                chofer.Edad = Int16.Parse(txtEdad.Text);
                chofer.Domicilio = txtDireccion.Text;
                if (rButtonFemenino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonFemenino.Text;
                }
                if (rButtonMasculino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonMasculino.Text;
                }
                chofer.Licencia = txtLicencia.Text;

                msj = chofer.registrar();
                MessageBox.Show(msj);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            chofer.eliminar(txtCedula.Text);
            limpiarCampos();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.TextLength == 10)
            {
                chofer.Cedula = txtCedula.Text;
                lstConductor=chofer.buscar(chofer.Cedula);
                if (lstConductor.Count == 0)
                {
                    btnRegistrar.Enabled = true;
                }
                else if(lstConductor.Count == 1)
                {
                    try
                    {

                        foreach (var conductor in lstConductor)
                        {
                            Type type = conductor.GetType();

                            String cedula = (String)type.GetProperty("cedula").GetValue(conductor);
                            String nombre = (String)type.GetProperty("nombre").GetValue(conductor);
                            String apellido = (String)type.GetProperty("apellido").GetValue(conductor);
                            String edad = ((short)type.GetProperty("edad").GetValue(conductor)).ToString();
                            String domicilio = (String)type.GetProperty("domicilio").GetValue(conductor);
                            String sexo = (String)type.GetProperty("sexo").GetValue(conductor);
                            String licencia = (String)type.GetProperty("licencia").GetValue(conductor);

                            txtCedula.Text = cedula;
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                            txtEdad.Text = edad;
                            txtDireccion.Text = domicilio;
                            if (sexo == "Masculino")
                            {
                                rButtonMasculino.Checked = true;
                            }
                            else
                            {
                                rButtonFemenino.Checked = true;
                            }
                            txtLicencia.Text = licencia;
                            btnEliminar.Enabled = true;
                            btnModificar.Enabled = true;
                            btnRegistrar.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }else if(txtCedula.TextLength == 9)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
                rButtonMasculino.Checked = false;
                rButtonFemenino.Checked = false;
                txtLicencia.Text = "";
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void limpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            rButtonMasculino.Checked = false;
            rButtonFemenino.Checked = false;
            txtLicencia.Text = "";
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultarConductores frmConsultar = new FrmConsultarConductores(chofer);
            frmConsultar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                chofer.Cedula = txtCedula.Text;
                chofer.Nombre = txtNombre.Text;
                chofer.Apellido = txtApellido.Text;
                chofer.Edad = Int16.Parse(txtEdad.Text);
                chofer.Domicilio = txtDireccion.Text;
                if (rButtonFemenino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonFemenino.Text;
                }
                if (rButtonMasculino.Checked.Equals(true))
                {
                    chofer.Sexo = rButtonMasculino.Text;
                }
                chofer.Licencia = txtLicencia.Text;

                if (chofer.actualizar_x_cedula() == 1)
                {
                    MessageBox.Show("Datos modificados exitorsamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloLetras(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }

        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodosAux.SoloNumeros(e);
        }
    }
}
