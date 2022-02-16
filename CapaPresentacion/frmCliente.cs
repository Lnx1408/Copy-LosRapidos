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
    public partial class frmCliente : Form
    {


        ClsCliente Al = new ClsCliente();
        List<Object> lst_cliente_tmp;
        String rutaimagen;


        public frmCliente()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public frmCliente(ClsCliente Al)
        {
            InitializeComponent();
            this.Al = Al;
            this.lst_cliente_tmp = Al.listar();
        }
        /// <summary>
        /// Metodo para registrar un cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdregistrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                Al.Cedula = txtcedula.Text;

                Al.Nombre = txtnombres.Text;
                Al.Apellido = txtapellidos.Text;
                Al.Edad = Int16.Parse(txtedad.Text);
                Al.Domicilio = txtdireccion.Text;
                if (radioButtonFemenino.Checked.Equals(true))
                {
                    Al.Sexo = radioButtonFemenino.Text;
                }
                if (radioButtonMasculino.Checked.Equals(true))
                {
                    Al.Sexo = radioButtonMasculino.Text;
                }

                Al.Imagen = this.rutaimagen;

                Al.CodigoCliente = textCC.Text;
                msj = Al.registrar();
                MessageBox.Show(msj);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Asigna una imagen  de modo que el cliente lo solicite.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = openFileDialog1.FileName;
                    this.rutaimagen = imagen;
                    pictureBox1.Image = Image.FromFile(imagen);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo no es un tipo de imagen valido");
            }

        }

        private void txtconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarCliente frm = new frmConsultarCliente(Al);
            frm.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarClientecs frmEliminar = new frmEliminarClientecs(Al);
            frmEliminar.Show();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
           
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

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }





        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
      

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }


}

