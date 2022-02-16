using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Usuario;

namespace CapaPresentacion.Usuario
{
    public partial class frmRegistrarUsuario : Form
    {
        public clsUsuario clsUsuario = new clsUsuario();
        String RutaImagen ="";

        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene los datos que el usuario ingresa y los lleva a la capa de negocio al método que los registra en la base de datos.
        /// </summary>
        /// <param name="clsUsuario">Objeto que contiene los datos del usuario.</param>
        /// <returns>Un mensajebox indicando si el registro fue exitoso o no.</returns>
        public String RegistrarUsuario(clsUsuario clsUsuario)
        {
            String Mensaje = "";
                Tuple<String, bool> resultado = clsUsuario.registrarUsuario();
                Mensaje =resultado.Item1;
                if (resultado.Item2)
                {
                    limpiarDatos();
                    this.Close();
                }
                else
                {
                    txtNombre.Focus();
                }
            return Mensaje;
        }

        /// <summary>
        /// Pasa los datos ingresados en el formulario al objeto de tipo "ClsUsuario".
        /// </summary>
        /// <param name="sender">Objeto que recibe por defecto</param>
        /// <param name="e">Evnto que recibe por defecto</param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (datosLlenos())
            {
                clsUsuario.Nombre = txtNombre.Text;
                clsUsuario.Apellido = txtApellidos.Text;
                clsUsuario.Cedula = txtCedula.Text;
                clsUsuario.Usuario = txtUsuario.Text;
                clsUsuario.Password = txtConfirmaPass.Text;
                validarImagen(this.RutaImagen);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pboxPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                clsUsuario.RutaImagen = ms.GetBuffer();

                MessageBox.Show(RegistrarUsuario(clsUsuario), "Resultado de registro");

            }
            else
            {
                txtNombre.Focus();
                MessageBox.Show("¡Atención!:\n\n- Ingrese todos los datos solicitados", "Error de datos");
            }
            
        }
        /// <summary>
        /// Permite abrir un cuadro de dialogo para seleccionar un archivo de tipo imagen.
        /// </summary>
        /// <param name="sender">Objeto que recibe por defecto</param>
        /// <param name="e">Evnto que recibe por defecto</param>
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen (*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = openFileDialog1.FileName;

                    this.RutaImagen = imagen;
                    
                    pboxPerfil.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo no es válido");
                Console.Write(ex);
            }
        }

        /// <summary>
        /// Asigna una imagen por defecto si detecta que la ruta del archivo está vacía.
        /// </summary>
        /// <param name="Imagen">Contine la ruta de la imagen.</param>
        /// <returns></returns>
        public String validarImagen(String Imagen)
        {
            String ruta;
            if (Imagen.Equals(""))
            {
                ruta = Path.Combine(Environment.CurrentDirectory, "..\\..\\Resourses\\A-Usuario.png");

            }
            else
            {
                ruta = Imagen;
            }

            return ruta;
        }

        /// <summary>
        /// Bloquea el ingreso por teclado cuando se presiona una tecla y no es un número.
        /// </summary>
        /// <param name="k">Evento KeyPressEventArgs</param>
        public void validarNumeros(KeyPressEventArgs k)
        {
            if (Char.IsDigit(k.KeyChar) || Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else k.Handled = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        private void frmRegistrarUsuario_Shown(object sender, EventArgs e)
        {
            pboxPerfil.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "..\\..\\Resources\\A-Usuario.png"));
            txtNombre.Focus();
        }

        /// <summary>
        /// Limpoa los datos que hay en los objetos del formulario.
        /// </summary>
        private void limpiarDatos()
        {
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtConfirmaPass.Text = "";
            this.RutaImagen = "";

        }

        /// <summary>
        /// Método para saber si los objetos del formulario tienen o no datos ingresados por el usuario, para evitar el ingreso de datos vacíos.
        /// </summary>
        /// <returns>Verdadero si los datos han sido ingresados o falso en el caso contrario.</returns>
        private bool datosLlenos()
        {
            bool estanllenos = true;
            if (txtApellidos.Text.Equals("") || txtNombre.Text.Equals("") || (txtCedula.Text.Length<10) || txtUsuario.Text.Equals("")) {
                estanllenos = false;
            }

            return estanllenos;
        }

        /// <summary>
        /// Muestra el nivel de seguridad de la contraseña que será ingresada por el usuario y desbloquea el botón de registro si es una contraseña segura.
        /// </summary>
        /// <param name="password">Contraseña ingresada por el usuario</param>
        /// <returns>Verdadero: Si la contraseña es segura, Falso: Cuando la contraseña no cumple los requisitos para ser segura.</returns>
        private bool nivelSeguridad(string password)
        {
            String Mayuscula ="mayuscula, "; String Minus ="minuscula, "; String Num = "numeros, "; String Caracter = "caracter especial, "; String Longitud="Al menos 8 caracteres";
            bool validado = false; bool mayuscula = false; bool minuscula = false; bool numero = false;  bool carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    Mayuscula = "";
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    Minus = "";
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    Num = "";
                    numero = true;
                }
                else
                {
                    Caracter = "";
                    carespecial = true;
                }
            }

            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                lblNivelSeguridad.BackColor = Color.Green;
                validado = true;
                Longitud = "";
                lblSeguridad.Text = "";
                txtConfirmaPass.Enabled = true;
                txtConfirmaPass.ReadOnly = false;

            }
            else
            {
                lblNivelSeguridad.BackColor = Color.Red;
                lblSeguridad.Text = "Debe incluir: " + Mayuscula + Minus + Num + Caracter + Longitud;
                validado = false;
                txtConfirmaPass.Enabled = false;
                txtConfirmaPass.ReadOnly = true;
            }
            return validado;
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            nivelSeguridad(txtPass.Text);
        }

        private void txtConfirmaPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPass.Text.Equals(txtConfirmaPass.Text) || !nivelSeguridad(txtPass.Text))
            {
                lblPassIdenticas.Text = "¡Todo listo!";
                btnRegistrar.Enabled = true;
            }
            else
            {
                lblPassIdenticas.Text = "Las contraseñas no coinciden";
            }
        }

        private void txtPass_MouseHover(object sender, EventArgs e)
        {
            MostrarContra(txtPass);
        }

        /// <summary>
        /// Muestra la contraseña del textbox
        /// </summary>
        /// <param name="txt">Textbox donde se ingresa la contraseña</param>
        private void MostrarContra(TextBox txt)
        {
            txt.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// Oculta la contraseña del textbox con caracteres "*****".
        /// </summary>
        /// <param name="txt">Textbox donde se ingresa la contraseña</param>
        private void OcultarContra(TextBox txt)
        {
            txt.UseSystemPasswordChar = true;
        }

        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            OcultarContra(txtPass);
        }

        private void txtConfirmaPass_MouseHover(object sender, EventArgs e)
        {
            MostrarContra(txtConfirmaPass);
        }

        private void txtConfirmaPass_MouseLeave(object sender, EventArgs e)
        {
            OcultarContra(txtConfirmaPass);
        }
    }
}
