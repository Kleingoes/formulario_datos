using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formulario_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbEdad.TextChanged += validarEdad;
            txBx3Estatura.TextChanged += validarEstatura;
            txBx2Telefono.TextChanged += validarTelefono;
            txBx5Nombre.TextChanged += validarNombre;
            txBx1Apellidos.TextChanged += validarApellidos;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  //Obtener los datos de los TexBox
            string nombres = txBx5Nombre.Text;
            string apellidos = txBx1Apellidos.Text;
            string edad = tbEdad.Text;
            string estatura = txBx3Estatura.Text;
            string telelfono = txBx2Telefono.Text;


            //Obtener el genero seleccinado
            string genero = "";
            if (rB1Hombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rB2Mujer.Checked)
            {
                genero = "Mujer";
            }
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telelfono) && EstextoValido(nombres)
                && EstextoValido(apellidos))
            {


                //Crear una cadena con los datos 
                string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telelfono} kg\r\nEstatura: {estatura}cm\r\nEdad: {edad} años\n\nGenero: {genero}";

                //Guardar los datos en un archivo de texto
                string rutaArchivo = "C:/Users/MARIO/OneDrive/Documentos/prueba.txt";
                File.WriteAllText(rutaArchivo, datos);
                //Verificar si el el archcivo ya existe 
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            // Si el archivo existe, añadir un separador antes del nuevo regristro 
                            writer.WriteLine();
                        }
                        writer.WriteLine(datos);


                    }

                    //Mostrar un mensaje con los datos capturados
                    MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }
        private bool EstextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txBx4Edad.Clear();
            txBx3Estatura.Clear();
            txBx2Telefono.Clear();
            txBx5Nombre.Clear();
            txBx1Apellidos.Clear();

            rB1Hombre.Checked = false;
            rB2Mujer.Checked = false;
        }
        private void validarEdad(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            string input = textBox.Text;
            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    MessageBox.Show("Por favor ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (!EstextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarApellidos(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (!EstextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese apellidos válidos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void txBx5Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBx4Edad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

