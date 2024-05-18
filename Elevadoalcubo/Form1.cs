using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Elevadoalcubo
{
    public partial class Form1 : Form
    {
        // Declaración de variables
        double numero1, numero2;
        double resultado;
        List<string> historial = new List<string>();

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Agregar los tipos de operaciones al ComboBox
            cmbTipoOperacion.Items.Add("+");
            cmbTipoOperacion.Items.Add("-");
            cmbTipoOperacion.Items.Add("*");
            cmbTipoOperacion.Items.Add("/");
            cmbTipoOperacion.Items.Add("^3");
            // Agrega más tipos de operaciones si es necesario
        }

        // Manejar el evento de clic en el botón "Calcular"
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            asignarDatos();
            calcular();
            AgregarAlHistorial($"{numero1} elevado al cubo = {resultado}");
            MostrarHistorial();
        }

        private void asignarDatos()
        {
            // Convertir el texto de los cuadros de texto a double
            numero1 = Convert.ToDouble(txtnumero.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            lblresultado.Text = resultado.ToString();
        }

        private void calcular()
        {
            // Calcular el cubo del número ingresado
            resultado = numero1 * numero1 * numero1;
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
            txtnumero2.Text = "";
            lblresultado.Text = "";

            // Poner el foco en el cuadro de texto
            txtnumero.Focus();
        }

        // Manejar el evento de clic en el botón de suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarIngresoNumeros();
                AsignarDatosSuma();
                CalculoSuma();
                AgregarAlHistorial($"{numero1} + {numero2} = {resultado}");
                MostrarHistorial();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarDatosSuma()
        {
            // Convertir el texto de los cuadros de texto a double
            numero1 = Convert.ToDouble(txtnumero.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = resultado.ToString();
        }

        private void CalculoSuma()
        {
            resultado = numero1 + numero2;
            lblresultado.Text = resultado.ToString();
        }

        // Manejar el evento de clic en el botón de resta
        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarIngresoNumeros();
                AsignarDatosResta();
                CalculoResta();
                AgregarAlHistorial($"{numero1} - {numero2} = {resultado}");
                MostrarHistorial();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarDatosResta()
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

        // Manejar el evento de clic en el botón de división
        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarIngresoNumeros();
                AsignarDatosDivision();
                CalculoDivision();
                AgregarAlHistorial($"{numero1} / {numero2} = {resultado}");
                MostrarHistorial();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        // Manejar el evento de clic en el botón de multiplicación
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarIngresoNumeros();
                AsignarDatosMultiplicacion();
                CalculoMultiplicacion();
                AgregarAlHistorial($"{numero1} * {numero2} = {resultado}");
                MostrarHistorial();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        // Función para verificar si se han ingresado ambos números antes de realizar una operación
        private void VerificarIngresoNumeros()
        {
            if (string.IsNullOrEmpty(txtnumero.Text) || string.IsNullOrEmpty(txtnumero2.Text))
            {
                throw new InvalidOperationException("Debes ingresar ambos números antes de realizar la operación.");
            }
        }

        // Función para agregar al historial
        private void AgregarAlHistorial(string calculo)
        {
            historial.Add(calculo);
        }

        // Función para mostrar el historial en la interfaz de usuario
        private void MostrarHistorial()
        {
            lstHistorial.Items.Clear();
            foreach (string item in historial)
            {
                lstHistorial.Items.Add(item);
            }
        }

        // Función para borrar el último cálculo del historial
        private void BorrarUltimo()
        {
            if (historial.Count > 0)
            {
                historial.RemoveAt(historial.Count - 1);
                MostrarHistorial();
            }
        }

        // Función para borrar todo el historial
        private void BorrarTodo()
        {
            historial.Clear();
            MostrarHistorial();
        }

        // Función para exportar el historial a un archivo de texto
        private void ExportarHistorial()
        {
            try
            {
                // Crear un cuadro de diálogo de guardar archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar historial";

                // Mostrar el cuadro de diálogo y esperar la selección del usuario
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta completa seleccionada por el usuario
                    string filePath = saveFileDialog.FileName;

                    // Escribir el historial en el archivo seleccionado
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (string item in historial)
                        {
                            writer.WriteLine(item);
                        }
                    }

                    MessageBox.Show("Historial exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para filtrar el historial por cierto criterio (por ejemplo, resultados mayores que un valor)
        private void FiltrarHistorial(double valor)
        {
            var filtrados = historial.Where(item =>
            {
                // Dividir el item en partes para obtener los números y el resultado, y compararlos con el valor de filtro
                string[] partes = item.Split('=');
                if (partes.Length == 2)
                {
                    string operacion = partes[0].Trim();
                    string[] numeros = operacion.Split(new[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                    List<double> valores = new List<double>();
                    foreach (string numero in numeros)
                    {
                        if (double.TryParse(numero.Trim(), out double valorNumero))
                        {
                            valores.Add(valorNumero);
                        }
                    }
                    if (valores.Count > 0)
                    {
                        double resultado;
                        if (double.TryParse(partes[1].Trim(), out resultado))
                        {
                            return resultado > valor || valores.Any(v => v > valor);
                        }
                    }
                }
                return false;
            }).ToList();

            // Mostrar los elementos filtrados en la lista de historial
            MostrarFiltrados(filtrados);
        }

        // Función para mostrar los elementos filtrados en la lista de historial
        private void MostrarFiltrados(List<string> filtrados)
        {
            lstHistorial.Items.Clear();
            foreach (string item in filtrados)
            {
                lstHistorial.Items.Add(item);
            }

            // Mostrar un mensaje si no se encontraron resultados después de aplicar el filtro
            if (filtrados.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados que cumplan con el criterio de filtrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Función para guardar el historial en un archivo binario con opción de selección de ubicación y nombre
        private void GuardarHistorial()
        {
            try
            {
                // Crear un cuadro de diálogo de guardar archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos binarios (*.bin)|*.bin|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar historial en formato binario";

                // Mostrar el cuadro de diálogo y esperar la selección del usuario
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta completa seleccionada por el usuario
                    string filePath = saveFileDialog.FileName;

                    // Crear un flujo de archivo para escribir en el archivo seleccionado
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        // Crear un formateador binario para serializar el historial
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        // Serializar el historial y escribirlo en el archivo
                        binaryFormatter.Serialize(fileStream, historial);
                    }

                    MessageBox.Show("Historial guardado correctamente en formato binario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de clic en el botón "Borrar último cálculo"
        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            BorrarUltimo();
        }

        // Evento de clic en el botón "Borrar todo el historial"
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            BorrarTodo();
        }

        // Evento de clic en el botón "Exportar historial"
        private void btnExportarHistorial_Click(object sender, EventArgs e)
        {
            ExportarHistorial();
        }

        // Evento de clic en el botón "Guardar historial"
        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            GuardarHistorial();
        }

        // Evento de clic en el botón "Filtrar historial"
        private void btnFiltrarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado un tipo de operación
                if (cmbTipoOperacion.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona un tipo de operación para filtrar el historial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el tipo de operación seleccionado por el usuario
                string tipoOperacion = cmbTipoOperacion.SelectedItem.ToString();

                // Verificar si se ha ingresado un valor de filtro
                if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                {
                    MessageBox.Show("Por favor, ingresa un valor para filtrar el historial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar si el valor de filtro es un número válido
                if (!double.TryParse(txtFiltro.Text, out double valorFiltro))
                {
                    MessageBox.Show("Por favor, ingresa un número válido para filtrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aplicar el filtro al historial
                FiltrarHistorial(tipoOperacion, valorFiltro);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de una excepción
                MessageBox.Show($"Error al filtrar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para filtrar el historial por tipo de operación y valor de filtro
        private void FiltrarHistorial(string tipoOperacion, double valorFiltro)
        {
            // Limpiar la lista de historial
            lstHistorial.Items.Clear();

            // Filtrar el historial por el tipo de operación seleccionado y el valor de filtro
            foreach (string item in historial)
            {
                // Verificar si el tipo de operación del elemento del historial coincide con el tipo seleccionado
                if (item.Contains(tipoOperacion) && item.Contains(valorFiltro.ToString()))
                {
                    // Dividir el item en partes para obtener los números y el resultado, y compararlos con el valor de filtro
                    string[] partes = item.Split('=');
                    if (partes.Length == 2)
                    {
                        string operacion = partes[0].Trim();
                        string[] numeros = operacion.Split(new[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                        List<double> valores = new List<double>();
                        foreach (string numero in numeros)
                        {
                            if (double.TryParse(numero.Trim(), out double valorNumero))
                            {
                                valores.Add(valorNumero);
                            }
                        }
                        if (valores.Count > 0)
                        {
                            double resultado;
                            if (double.TryParse(partes[1].Trim(), out resultado))
                            {
                                // Si el resultado o alguno de los números de la operación es mayor que el valor de filtro, agregar al historial
                                if (resultado > valorFiltro || valores.Any(v => v > valorFiltro))
                                {
                                    lstHistorial.Items.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            //Emite mensaje de error si no encuentra valor numérico en el filtro
            if (lstHistorial.Items.Count == 0)
            {
                MessageBox.Show($"Error al filtrar el historial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
    

