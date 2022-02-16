
namespace CapaPresentacion
{
    partial class frmAsignar
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
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.id_ambulancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAmbulancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnunplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdregistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.dgv_listarConductores = new System.Windows.Forms.DataGridView();
            this.btnBuscarConductores = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarConductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.AllowUserToAddRows = false;
            this.dgv_listarTodos.AllowUserToDeleteRows = false;
            this.dgv_listarTodos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ambulancia,
            this.modelo,
            this.tipoAmbulancia,
            this.placa,
            this.matricula});
            this.dgv_listarTodos.Location = new System.Drawing.Point(21, 96);
            this.dgv_listarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.RowHeadersWidth = 51;
            this.dgv_listarTodos.RowTemplate.Height = 24;
            this.dgv_listarTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listarTodos.Size = new System.Drawing.Size(584, 93);
            this.dgv_listarTodos.TabIndex = 82;
            // 
            // id_ambulancia
            // 
            this.id_ambulancia.HeaderText = "Numero Ambulancia";
            this.id_ambulancia.Name = "id_ambulancia";
            this.id_ambulancia.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 130;
            // 
            // tipoAmbulancia
            // 
            this.tipoAmbulancia.HeaderText = "Tipo Ambulancia";
            this.tipoAmbulancia.Name = "tipoAmbulancia";
            this.tipoAmbulancia.ReadOnly = true;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Location = new System.Drawing.Point(254, 67);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 22);
            this.btnbuscar.TabIndex = 81;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtnunplaca
            // 
            this.txtnunplaca.Location = new System.Drawing.Point(113, 69);
            this.txtnunplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtnunplaca.MaxLength = 8;
            this.txtnunplaca.Name = "txtnunplaca";
            this.txtnunplaca.Size = new System.Drawing.Size(128, 20);
            this.txtnunplaca.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Ingrese su placa: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "ASIGNAR AMBULANCIAS";
            // 
            // cmdregistrar
            // 
            this.cmdregistrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdregistrar.FlatAppearance.BorderSize = 0;
            this.cmdregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregistrar.Image = global::CapaPresentacion.Properties.Resources.guardar2;
            this.cmdregistrar.Location = new System.Drawing.Point(306, 424);
            this.cmdregistrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdregistrar.Name = "cmdregistrar";
            this.cmdregistrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdregistrar.Size = new System.Drawing.Size(76, 56);
            this.cmdregistrar.TabIndex = 86;
            this.cmdregistrar.Text = "Registrar";
            this.cmdregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdregistrar.UseVisualStyleBackColor = false;
            this.cmdregistrar.Click += new System.EventHandler(this.cmdregistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "ASIGNAR CONDUCTORES";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Image = global::CapaPresentacion.Properties.Resources.voler3;
            this.btnregresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnregresar.Location = new System.Drawing.Point(396, 421);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(76, 56);
            this.btnregresar.TabIndex = 88;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // dgv_listarConductores
            // 
            this.dgv_listarConductores.AllowUserToAddRows = false;
            this.dgv_listarConductores.AllowUserToDeleteRows = false;
            this.dgv_listarConductores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listarConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarConductores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaID,
            this.columnaCedula,
            this.columnaNombre,
            this.columnaApellido,
            this.columnaEdad,
            this.columnaDomicilio,
            this.columnaSexo,
            this.columnaLicencia});
            this.dgv_listarConductores.Location = new System.Drawing.Point(21, 297);
            this.dgv_listarConductores.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listarConductores.Name = "dgv_listarConductores";
            this.dgv_listarConductores.ReadOnly = true;
            this.dgv_listarConductores.RowHeadersWidth = 51;
            this.dgv_listarConductores.RowTemplate.Height = 24;
            this.dgv_listarConductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listarConductores.Size = new System.Drawing.Size(776, 93);
            this.dgv_listarConductores.TabIndex = 89;
            // 
            // btnBuscarConductores
            // 
            this.btnBuscarConductores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarConductores.FlatAppearance.BorderSize = 0;
            this.btnBuscarConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConductores.Location = new System.Drawing.Point(313, 267);
            this.btnBuscarConductores.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarConductores.Name = "btnBuscarConductores";
            this.btnBuscarConductores.Size = new System.Drawing.Size(57, 22);
            this.btnBuscarConductores.TabIndex = 92;
            this.btnBuscarConductores.Text = "Buscar";
            this.btnBuscarConductores.UseVisualStyleBackColor = false;
            this.btnBuscarConductores.Click += new System.EventHandler(this.btnBuscarConductores_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(172, 269);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(128, 20);
            this.txtCedula.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Ingrese su número de cédula:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.chofer_Ambulancia;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(21, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // columnaID
            // 
            this.columnaID.HeaderText = "Número Conductor";
            this.columnaID.Name = "columnaID";
            this.columnaID.ReadOnly = true;
            this.columnaID.Width = 70;
            // 
            // columnaCedula
            // 
            this.columnaCedula.HeaderText = "Cédula";
            this.columnaCedula.Name = "columnaCedula";
            this.columnaCedula.ReadOnly = true;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaApellido
            // 
            this.columnaApellido.HeaderText = "Apellido";
            this.columnaApellido.Name = "columnaApellido";
            this.columnaApellido.ReadOnly = true;
            // 
            // columnaEdad
            // 
            this.columnaEdad.HeaderText = "Edad";
            this.columnaEdad.Name = "columnaEdad";
            this.columnaEdad.ReadOnly = true;
            this.columnaEdad.Width = 50;
            // 
            // columnaDomicilio
            // 
            this.columnaDomicilio.HeaderText = "Domicilio";
            this.columnaDomicilio.Name = "columnaDomicilio";
            this.columnaDomicilio.ReadOnly = true;
            // 
            // columnaSexo
            // 
            this.columnaSexo.HeaderText = "Sexo";
            this.columnaSexo.Name = "columnaSexo";
            this.columnaSexo.ReadOnly = true;
            // 
            // columnaLicencia
            // 
            this.columnaLicencia.HeaderText = "Licencia";
            this.columnaLicencia.Name = "columnaLicencia";
            this.columnaLicencia.ReadOnly = true;
            // 
            // frmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscarConductores);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_listarConductores);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdregistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnunplaca);
            this.Controls.Add(this.label1);
            this.Name = "frmAsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsignar";
            this.Shown += new System.EventHandler(this.frmAsignar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarConductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ambulancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAmbulancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnunplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdregistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView dgv_listarConductores;
        private System.Windows.Forms.Button btnBuscarConductores;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaLicencia;
    }
}