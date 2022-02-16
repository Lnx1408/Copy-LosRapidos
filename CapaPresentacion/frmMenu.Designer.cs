namespace CapaPresentacion
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConductor = new System.Windows.Forms.Label();
            this.btnAmbulancia = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Label();
            this.pboxConductor = new System.Windows.Forms.PictureBox();
            this.pboxAmbulancia = new System.Windows.Forms.PictureBox();
            this.pboxCliente = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxConductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAmbulancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnConductor);
            this.panel1.Controls.Add(this.btnAmbulancia);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.pboxConductor);
            this.panel1.Controls.Add(this.pboxAmbulancia);
            this.panel1.Controls.Add(this.pboxCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 386);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asignar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.conductor;
            this.pictureBox1.Location = new System.Drawing.Point(758, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(151)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 55);
            this.panel2.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(581, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(312, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bienvenido, iniciaste sesión como:";
            // 
            // btnConductor
            // 
            this.btnConductor.AutoSize = true;
            this.btnConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductor.Location = new System.Drawing.Point(575, 250);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(73, 17);
            this.btnConductor.TabIndex = 5;
            this.btnConductor.Text = "Conductor";
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // btnAmbulancia
            // 
            this.btnAmbulancia.AutoSize = true;
            this.btnAmbulancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbulancia.Location = new System.Drawing.Point(361, 250);
            this.btnAmbulancia.Name = "btnAmbulancia";
            this.btnAmbulancia.Size = new System.Drawing.Size(81, 17);
            this.btnAmbulancia.TabIndex = 4;
            this.btnAmbulancia.Text = "Ambulancia";
            this.btnAmbulancia.Click += new System.EventHandler(this.btnAmbulancia_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(175, 250);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(51, 17);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pboxConductor
            // 
            this.pboxConductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxConductor.Image = ((System.Drawing.Image)(resources.GetObject("pboxConductor.Image")));
            this.pboxConductor.Location = new System.Drawing.Point(561, 125);
            this.pboxConductor.Name = "pboxConductor";
            this.pboxConductor.Size = new System.Drawing.Size(96, 96);
            this.pboxConductor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxConductor.TabIndex = 2;
            this.pboxConductor.TabStop = false;
            this.pboxConductor.Click += new System.EventHandler(this.pboxConductor_Click);
            // 
            // pboxAmbulancia
            // 
            this.pboxAmbulancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxAmbulancia.Image = global::CapaPresentacion.Properties.Resources.ambulancia1;
            this.pboxAmbulancia.Location = new System.Drawing.Point(354, 125);
            this.pboxAmbulancia.Name = "pboxAmbulancia";
            this.pboxAmbulancia.Size = new System.Drawing.Size(96, 96);
            this.pboxAmbulancia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxAmbulancia.TabIndex = 1;
            this.pboxAmbulancia.TabStop = false;
            this.pboxAmbulancia.Click += new System.EventHandler(this.pboxAmbulancia_Click);
            // 
            // pboxCliente
            // 
            this.pboxCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCliente.Image = global::CapaPresentacion.Properties.Resources.user;
            this.pboxCliente.Location = new System.Drawing.Point(154, 125);
            this.pboxCliente.Name = "pboxCliente";
            this.pboxCliente.Size = new System.Drawing.Size(96, 96);
            this.pboxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxCliente.TabIndex = 0;
            this.pboxCliente.TabStop = false;
            this.pboxCliente.Click += new System.EventHandler(this.pboxCliente_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(151)))), ((int)(((byte)(199)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::CapaPresentacion.Properties.Resources.salir;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(924, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(49, 49);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCerrarSesion, "CERRAR SESION");
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(985, 386);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxConductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAmbulancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnConductor;
        private System.Windows.Forms.Label btnAmbulancia;
        private System.Windows.Forms.Label btnCliente;
        private System.Windows.Forms.PictureBox pboxConductor;
        private System.Windows.Forms.PictureBox pboxAmbulancia;
        private System.Windows.Forms.PictureBox pboxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}