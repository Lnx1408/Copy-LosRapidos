
namespace CapaPresentacion
{
    partial class FrmConsultarConductores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarConductores));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblIngreseCedula = new System.Windows.Forms.Label();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.columnaCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(340, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(186, 23);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(142, 20);
            this.txtCedula.TabIndex = 8;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // lblIngreseCedula
            // 
            this.lblIngreseCedula.AutoSize = true;
            this.lblIngreseCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreseCedula.Location = new System.Drawing.Point(40, 26);
            this.lblIngreseCedula.Name = "lblIngreseCedula";
            this.lblIngreseCedula.Size = new System.Drawing.Size(144, 13);
            this.lblIngreseCedula.TabIndex = 7;
            this.lblIngreseCedula.Text = "Ingrese el número de cédula:";
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(441, 21);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodos.TabIndex = 10;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(661, 21);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.AllowUserToAddRows = false;
            this.dgv_listarTodos.AllowUserToDeleteRows = false;
            this.dgv_listarTodos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCedula,
            this.columnaNombre,
            this.columnaApellido,
            this.columnaEdad,
            this.columnaDireccion,
            this.columnaSexo,
            this.columnaLicencia});
            this.dgv_listarTodos.Location = new System.Drawing.Point(43, 68);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.Size = new System.Drawing.Size(693, 288);
            this.dgv_listarTodos.TabIndex = 12;
            // 
            // columnaCedula
            // 
            this.columnaCedula.HeaderText = "Cédula";
            this.columnaCedula.Name = "columnaCedula";
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            // 
            // columnaApellido
            // 
            this.columnaApellido.HeaderText = "Apellido";
            this.columnaApellido.Name = "columnaApellido";
            // 
            // columnaEdad
            // 
            this.columnaEdad.HeaderText = "Edad";
            this.columnaEdad.Name = "columnaEdad";
            this.columnaEdad.Width = 50;
            // 
            // columnaDireccion
            // 
            this.columnaDireccion.HeaderText = "Dirección";
            this.columnaDireccion.Name = "columnaDireccion";
            // 
            // columnaSexo
            // 
            this.columnaSexo.HeaderText = "Sexo";
            this.columnaSexo.Name = "columnaSexo";
            // 
            // columnaLicencia
            // 
            this.columnaLicencia.HeaderText = "Licencia";
            this.columnaLicencia.Name = "columnaLicencia";
            // 
            // FrmConsultarConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 386);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblIngreseCedula);
            this.Name = "FrmConsultarConductores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarConductores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblIngreseCedula;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaLicencia;
    }
}