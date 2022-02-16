
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
    public partial class frmAsignar : Form
    {
        ClsAmbulancia Ambulancia1 = new ClsAmbulancia();
        ClsConductores Conductor1 = new ClsConductores();
        List<Object> lst_ambulancia_tmp;
        List<Object> lst_conductor_tmp;
        ClsAsignacion Asignacion = new ClsAsignacion();


        public frmAsignar()
        {
            InitializeComponent();
        }

        //Buscar placa ingresada
        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgv_listarTodos.Rows.Clear();
                dgv_listarTodos.Refresh();
                lst_ambulancia_tmp = Ambulancia1.buscar(txtnunplaca.Text);

                foreach (var ambulancia in lst_ambulancia_tmp)
                {
                    if (ambulancia != null)
                    {
                        System.Type type = ambulancia.GetType();

                        Int16 Id_Ambulancia = (Int16)type.GetProperty("Id_Ambulancia").GetValue(ambulancia);
                        String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                        String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                        String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                        String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);

                        dgv_listarTodos.Rows.Add(Id_Ambulancia, modelo, tipoAmbulancia, placa, matricula);
                        cmdregistrar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la ambulancia");

            }
        }

        private void cmdregistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                Asignacion.ID_AmbulanciaAsignacion = Int16.Parse(dgv_listarTodos.CurrentRow.Cells[0].Value.ToString());

                /*Reemplaza en esta linea por el nombre de tu tabla*/
                Asignacion.ID_ConductorAsignacion = Int16.Parse(dgv_listarConductores.CurrentRow.Cells[0].Value.ToString());

                msj = Asignacion.registrar();
                MessageBox.Show(msj);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmEst = new frmMenu();
            frmEst.Show();
        }

        /*Metodo importante*/
        private void frmAsignar_Shown(object sender, EventArgs e)
        {
            this.lst_ambulancia_tmp = Ambulancia1.listar();
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

        }

        //Buscar cedula ingresada
        private void btnBuscarConductores_Click(object sender, EventArgs e)
        {
            dgv_listarConductores.Rows.Clear();
            dgv_listarConductores.Refresh();

            if (txtCedula.TextLength == 10)
            {
                Conductor1.Cedula = txtCedula.Text;
                lst_conductor_tmp = Conductor1.buscar(Conductor1.Cedula);

                try
                {

                    foreach (var conductor in lst_conductor_tmp)
                    {
                        Type type = conductor.GetType();

                        Int16 Id_Conductor = (Int16)type.GetProperty("id_conductor").GetValue(conductor);
                        String cedula = (String)type.GetProperty("cedula").GetValue(conductor);
                        String nombre = (String)type.GetProperty("nombre").GetValue(conductor);
                        String apellido = (String)type.GetProperty("apellido").GetValue(conductor);
                        String edad = ((short)type.GetProperty("edad").GetValue(conductor)).ToString();
                        String domicilio = (String)type.GetProperty("domicilio").GetValue(conductor);
                        String sexo = (String)type.GetProperty("sexo").GetValue(conductor);
                        String licencia = (String)type.GetProperty("licencia").GetValue(conductor);

                        dgv_listarConductores.Rows.Add(Id_Conductor, cedula, nombre, apellido, edad, domicilio, sexo, licencia);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Faltan caracteres");
            }

        }
    }
}
