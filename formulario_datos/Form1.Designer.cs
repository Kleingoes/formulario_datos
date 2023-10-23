namespace formulario_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txBx1Apellidos = new System.Windows.Forms.TextBox();
            this.txBx2Telefono = new System.Windows.Forms.TextBox();
            this.txBx3Estatura = new System.Windows.Forms.TextBox();
            this.txBx4Edad = new System.Windows.Forms.TextBox();
            this.txBx5Nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2Mujer = new System.Windows.Forms.RadioButton();
            this.rB1Hombre = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.Label();
            this.tbEstatura = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txBx1Apellidos
            // 
            this.txBx1Apellidos.Location = new System.Drawing.Point(111, 91);
            this.txBx1Apellidos.Name = "txBx1Apellidos";
            this.txBx1Apellidos.Size = new System.Drawing.Size(178, 22);
            this.txBx1Apellidos.TabIndex = 0;
            // 
            // txBx2Telefono
            // 
            this.txBx2Telefono.Location = new System.Drawing.Point(111, 143);
            this.txBx2Telefono.Name = "txBx2Telefono";
            this.txBx2Telefono.Size = new System.Drawing.Size(178, 22);
            this.txBx2Telefono.TabIndex = 1;
            // 
            // txBx3Estatura
            // 
            this.txBx3Estatura.Location = new System.Drawing.Point(111, 179);
            this.txBx3Estatura.Name = "txBx3Estatura";
            this.txBx3Estatura.Size = new System.Drawing.Size(178, 22);
            this.txBx3Estatura.TabIndex = 2;
            // 
            // txBx4Edad
            // 
            this.txBx4Edad.Location = new System.Drawing.Point(111, 212);
            this.txBx4Edad.Name = "txBx4Edad";
            this.txBx4Edad.Size = new System.Drawing.Size(178, 22);
            this.txBx4Edad.TabIndex = 3;
            this.txBx4Edad.TextChanged += new System.EventHandler(this.txBx4Edad_TextChanged);
            // 
            // txBx5Nombre
            // 
            this.txBx5Nombre.Location = new System.Drawing.Point(111, 46);
            this.txBx5Nombre.Name = "txBx5Nombre";
            this.txBx5Nombre.Size = new System.Drawing.Size(178, 22);
            this.txBx5Nombre.TabIndex = 4;
            this.txBx5Nombre.TextChanged += new System.EventHandler(this.txBx5Nombre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2Mujer);
            this.groupBox1.Controls.Add(this.rB1Hombre);
            this.groupBox1.Location = new System.Drawing.Point(15, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero ";
            // 
            // rB2Mujer
            // 
            this.rB2Mujer.AutoSize = true;
            this.rB2Mujer.Location = new System.Drawing.Point(165, 41);
            this.rB2Mujer.Name = "rB2Mujer";
            this.rB2Mujer.Size = new System.Drawing.Size(61, 20);
            this.rB2Mujer.TabIndex = 1;
            this.rB2Mujer.TabStop = true;
            this.rB2Mujer.Text = "Mujer";
            this.rB2Mujer.UseVisualStyleBackColor = true;
            // 
            // rB1Hombre
            // 
            this.rB1Hombre.AutoSize = true;
            this.rB1Hombre.Location = new System.Drawing.Point(7, 42);
            this.rB1Hombre.Name = "rB1Hombre";
            this.rB1Hombre.Size = new System.Drawing.Size(77, 20);
            this.rB1Hombre.TabIndex = 0;
            this.rB1Hombre.TabStop = true;
            this.rB1Hombre.Text = "Hombre";
            this.rB1Hombre.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.AutoSize = true;
            this.tbNombre.Location = new System.Drawing.Point(12, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(56, 16);
            this.tbNombre.TabIndex = 6;
            this.tbNombre.Text = "Nombre";
            // 
            // tbApellidos
            // 
            this.tbApellidos.AutoSize = true;
            this.tbApellidos.Location = new System.Drawing.Point(12, 94);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(64, 16);
            this.tbApellidos.TabIndex = 7;
            this.tbApellidos.Text = "Apellidos";
            // 
            // tbTelefono
            // 
            this.tbTelefono.AutoSize = true;
            this.tbTelefono.Location = new System.Drawing.Point(12, 143);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(61, 16);
            this.tbTelefono.TabIndex = 8;
            this.tbTelefono.Text = "Telefono";
            this.tbTelefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbEstatura
            // 
            this.tbEstatura.AutoSize = true;
            this.tbEstatura.Location = new System.Drawing.Point(12, 185);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(56, 16);
            this.tbEstatura.TabIndex = 9;
            this.tbEstatura.Text = "Estatura";
            this.tbEstatura.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbEdad
            // 
            this.tbEdad.AutoSize = true;
            this.tbEdad.Location = new System.Drawing.Point(12, 218);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(39, 16);
            this.tbEdad.TabIndex = 10;
            this.tbEdad.Text = "edad";
            this.tbEdad.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(130, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(130, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 67);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::formulario_datos.Properties.Resources.FB_IMG_1651856440055;
            this.ClientSize = new System.Drawing.Size(962, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txBx5Nombre);
            this.Controls.Add(this.txBx4Edad);
            this.Controls.Add(this.txBx3Estatura);
            this.Controls.Add(this.txBx2Telefono);
            this.Controls.Add(this.txBx1Apellidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBx1Apellidos;
        private System.Windows.Forms.TextBox txBx2Telefono;
        private System.Windows.Forms.TextBox txBx3Estatura;
        private System.Windows.Forms.TextBox txBx4Edad;
        private System.Windows.Forms.TextBox txBx5Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB2Mujer;
        private System.Windows.Forms.RadioButton rB1Hombre;
        private System.Windows.Forms.Label tbNombre;
        private System.Windows.Forms.Label tbApellidos;
        private System.Windows.Forms.Label tbTelefono;
        private System.Windows.Forms.Label tbEstatura;
        private System.Windows.Forms.Label tbEdad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

