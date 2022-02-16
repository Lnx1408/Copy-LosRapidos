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
    public partial class frmGuardarAmbulancia : Form
    {

        ClsAmbulancia Ambulancia1 = new ClsAmbulancia();
        public bool vacio;
        List<Object> lst_ambulancia_tmp;


        public frmGuardarAmbulancia()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public frmGuardarAmbulancia(ClsAmbulancia Ambulancia1)
        {
            InitializeComponent();
            this.Ambulancia1 = Ambulancia1;
            this.lst_ambulancia_tmp = Ambulancia1.listar();

        }


       /// <summary>
       /// Metodo para registrar una ambulancia.
       /// Se guarda una ambulancia mediante los parametros ingresados si cumple 
       /// Como condicion de guardado la placa ni la matricula se deben repetir
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void cmdregistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                Ambulancia1.Modelo = comboBoxModelo.Text;
                Ambulancia1.TipoAmbulancia = comboBoxTipo.Text;
                Ambulancia1.Placa = txtplaca.Text;
                Ambulancia1.Matricula = txtMatricula.Text;
             

                msj = Ambulancia1.registrar();
                MessageBox.Show(msj);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
}


        private void txtconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarAmbulanciacs frmEstCons = new frmConsultarAmbulanciacs(Ambulancia1);
            frmEstCons.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarAmbulancia frmEliminar = new frmEliminarAmbulancia(Ambulancia1);
            frmEliminar.Show();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void txtAñoActivacion_KeyPress(object sender, KeyPressEventArgs e)
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
