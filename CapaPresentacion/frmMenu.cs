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
using CapaPresentacion.Login;

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        frmCliente cliente = new frmCliente();
        frmGuardarAmbulancia guardarAmbulancia = new frmGuardarAmbulancia();
        FrmConductores conductores = new FrmConductores();
  


        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            cliente.Show();
            this.Hide();
        }

        private void pboxAmbulancia_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Hide();
        }

        private void pboxConductor_Click(object sender, EventArgs e)
        {
            conductores.Show();
            this.Hide();
        }

        private void pboxCliente_Click(object sender, EventArgs e)
        {
            cliente.Show();
            this.Hide();
        }

        private void btnAmbulancia_Click(object sender, EventArgs e)
        {
            guardarAmbulancia.Show();
            this.Hide();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            conductores.Show();
            this.Hide();
        }

  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAsignar asignar = new frmAsignar();
            asignar.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
