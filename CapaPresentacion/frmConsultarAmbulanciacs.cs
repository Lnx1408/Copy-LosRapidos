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
    public partial class frmConsultarAmbulanciacs : Form
    {
      //  frmActualizarEstudiantes frActualizar = new frmActualizarEstudiantes();
        List<Object> lst_ambulancia_tmp;
        ClsAmbulancia Ambulancia1;
        frmActualizarAmbulancia frmActualizar = new frmActualizarAmbulancia();


        public frmConsultarAmbulanciacs()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        public frmConsultarAmbulanciacs(ClsAmbulancia Ambulancia1)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.Ambulancia1 = Ambulancia1;
            this.lst_ambulancia_tmp = Ambulancia1.listar();
            llenar_datagridview_ambulancia();
            buttonactualizar.Enabled = false;

        }

     
        public void llenar_datagridview_ambulancia()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var ambulancia in lst_ambulancia_tmp)
            {
                System.Type type = ambulancia.GetType();

                Int16 Id_Ambulancia = (Int16)type.GetProperty("Id_Ambulancia").GetValue(ambulancia);
                String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);
               
                dgv_listarTodos.Rows.Add(Id_Ambulancia,modelo, tipoAmbulancia, placa, matricula);
            }

        }


        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuardarAmbulancia frmEst = new frmGuardarAmbulancia(Ambulancia1);
            frmEst.Show();
        }
        /// <summary>
        /// Metodo para buscar una ambulancia.
        /// Se busca una asmbulancia mediante un parametro de busqueda como la placa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnbuscar_Click(object sender, EventArgs e)
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
                        buttonactualizar.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            buttonactualizar.Enabled = false;
            frmActualizar = new frmActualizarAmbulancia(dgv_listarTodos.CurrentRow.Cells[0].Value.ToString(), Ambulancia1);
            frmActualizar.ShowDialog();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            this.lst_ambulancia_tmp = Ambulancia1.listar();
            llenar_datagridview_ambulancia();
            buttonactualizar.Enabled = false;
        }

        private void txtnunplaca_TextChanged(object sender, EventArgs e)
        {
            buttonactualizar.Enabled = false;
        }
    }
}
