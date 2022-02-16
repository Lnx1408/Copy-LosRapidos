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
    public partial class frmActualizarAmbulancia : Form
    {
        String idnumero;
        ClsAmbulancia Ambulancia1 = new ClsAmbulancia();
        


        public frmActualizarAmbulancia()
        {
            InitializeComponent();
            txtplaca.Enabled = false;
        }
        public frmActualizarAmbulancia(string idnumero, ClsAmbulancia Ambulancia1)
        {
            InitializeComponent();
            textBoxnumambuancia.Enabled = false;
            textBoxnumambuancia.Text = idnumero;
            this.Ambulancia1 = Ambulancia1;
            this.idnumero = idnumero;
            obtenerDatos();
            txtplaca.Enabled = false;
        //    this.lst_alumnos_tmp = Ambulancia1.listar();
        }

        private void obtenerDatos()
        {
            List<Object> lst_ambulancia = Ambulancia1.listar();
            foreach (var Amb in lst_ambulancia)
            {
                System.Type type = Amb.GetType();
                Int16 NumeroAmbulancia = (Int16)type.GetProperty("Id_Ambulancia").GetValue(Amb);
                if (int.Parse(this.idnumero) == NumeroAmbulancia)
                {
                 comboBoxModelo.SelectedItem = (String)type.GetProperty("modelo").GetValue(Amb);
                 comboBoxTipo.SelectedItem = (String)type.GetProperty("tipoAmbulancia").GetValue(Amb);
                 txtplaca.Text = (String)type.GetProperty("placa").GetValue(Amb);
                 txtMatricula.Text = (String)type.GetProperty("matricula").GetValue(Amb);
               }
            }
        }
        /// <summary>
        /// Metodo para actualizar ambulancia.
        /// Se actualiza una asmbulancia mediante una busqueda previamente realizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonActualizarCambios_Click(object sender, EventArgs e)
        {
            try
            {
               Ambulancia1.Modelo = comboBoxModelo.Text;
               Ambulancia1.TipoAmbulancia =comboBoxTipo.Text;
               Ambulancia1.Placa = txtplaca.Text;
               Ambulancia1.Matricula =txtMatricula.Text;
               int resultado = Ambulancia1.actualizar_x_placa();
               MessageBox.Show("Los datos se actualizon correctamente");
                this.Hide();
                frmConsultarAmbulanciacs frmconsultar = new frmConsultarAmbulanciacs(Ambulancia1);
                frmconsultar.Show();
            }
            catch (Exception ex)
            {
            MessageBox.Show("Error en la actualizacion verifique que los datos de matricula o placa no esten duplicados");
            }

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
