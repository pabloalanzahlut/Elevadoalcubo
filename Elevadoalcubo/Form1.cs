using System;
using System.Windows.Forms;


namespace Elevadoalcubo
{
    public partial class Form1 : Form
    {
        // Declaración de variables
        double numero;
        double resultado;

        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Manejar el evento de clic en el botón "Calcular"
        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            asignarDatos();
            calcular();
        }
        private void asignarDatos()
        {
            // Convertir el texto de los cuadros de texto a double
            numero = Convert.ToDouble(txtnumero.Text);
            lblresultado.Text = resultado.ToString(); 
        }

        private void calcular()
        {
            // Calcular el cubo del número ingresado
            resultado = numero * numero * numero;
            // Mostrar el resultado en el cuadro de texto txtBox2
            lblresultado.Text = resultado.ToString();

        }




        // Manejar el evento de clic en el botón "Salir"

        private void btnsalir_Click(object sender, EventArgs e)
        {
            
                // Cerrar la aplicación
                Application.Exit();
            
        }
        
        // Manejar el evento de clic en el botón "Reintentar"
        private void btnreset_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto para permitir que el usuario ingrese un nuevo número
            txtnumero.Text = "";
            lblresultado.Text = "";
            txtnumero.Focus(); // Poner el foco en el cuadro de texto
        }

        
    }



}

