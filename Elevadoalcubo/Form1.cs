using System;
using System.Windows.Forms;


namespace Elevadoalcubo
{
    public partial class Form1 : Form
    {
        // Declaración de variables
        double numero1, numero2;
        double resultado;

        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Manejar el evento de clic en el botón "Calcular"
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            asignarDatos();
            calcular();
        }
    
        private void asignarDatos()
        {
            // Convertir el texto de los cuadros de texto a double
            numero1 = Convert.ToDouble(txtnumero.Text);
            numero1 = Convert.ToDouble(txtnumero2.Text);
            lblresultado.Text = resultado.ToString(); 
        }

        private void calcular()
        {
            // Calcular el cubo del número ingresado
            resultado = numero1 * numero1* numero1;
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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            AsignarDatosSuma();
            CalculoSuma();
        }
        private void AsignarDatosSuma() 
        
        {
            numero1 = Convert.ToDouble(txtnumero.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            asignarDatosResta();
            CalculoResta();
        }

        private void asignarDatosResta() 
        
        {
            numero1 = Convert.ToDouble(txtnumero.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = resultado.ToString();

        }

        private void CalculoResta() 
       
        {
            resultado = numero1 - numero2;
            lblresultado.Text = resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            AsignarDatosDivision();
            CalculoDivision();
        }

        private void AsignarDatosDivision()
        {

            numero1 = Convert.ToDouble(txtnumero.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = resultado.ToString();
        }

        private void CalculoDivision() 
        {
            resultado = numero1 / numero2;
            lblresultado.Text = resultado.ToString();

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            AsignarDatosMultiplicacion();
            CalculoMultiplicacion();
        }
        private void AsignarDatosMultiplicacion() 
        {
            numero1 = Convert.ToDouble(txtnumero.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = resultado.ToString();
        }
        private void CalculoMultiplicacion() 
        {
            resultado = numero1 * numero2;
            lblresultado.Text = resultado.ToString();
        }

        private void CalculoSuma()
        {
            resultado = numero1 + numero2;
            lblresultado.Text = resultado.ToString();
        
        }

        
        
    }



}

