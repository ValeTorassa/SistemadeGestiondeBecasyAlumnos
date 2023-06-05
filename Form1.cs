/*
Dado un escenario de una universidad nos manifiestan la necesidad de desarrollar un sistema para administrar las becas que se les otorgan a los alumnos. 
Para las becas a los beneficiarios se los clasifica en tres grupos: Ingresantes, Grado y Posgrado.
Las becas se otorgan en pesos.
Una beca posee un beneficiario y estos pueden tener como máximo una beca. 
Las becas y los beneficiarios de estas se crean por separado. La beca creada se le asigna al beneficiario seleccionado en la grilla de beneficiarios al momento de crearla. Las becas asignadas no pueden modificarse, pero si quitársela a un beneficiario y como máximo un beneficiario puede tener dos.
Las becas se identifican por un código de 6 caracteres alfanuméricos. Los primeros 4 son números y las 2 siguientes letras. Los códigos deben validarse cuando se ingresan y no se debe permitir valores incorrectos y/o repetidos. Las becas también poseen una fecha de otorgamiento.
Los Alumnos se identifican por su legajo. También se desea saber el nombre, el apellido y el dni.
El importe asignado en una beca no puede superar el 100% de la cuota que abona el alumno en concepto de pago mensual (este valor puede colocarlo como atributo del alumno). 
Simular el pago (informar cuanto debe pagar) de una cuota sabiendo que:
Si es Ingresante posee un beneficio del 10% sobre el valor neto (cuota-beca) a pagar.
Si es alumnos de Grado el beneficio es del 5% sobre sobre el valor neto (cuota-beca) a pagar.
Si es alumnos de Posgrado el beneficio es del 1% sobre sobre el valor neto (cuota-beca) a pagar.

Los datos deben mostrarse en grillas. 

1.	Todos los Beneficiarios. (grilla 1)
Legajo	Nombre	Apellido	dni

2.	Todas las becas. (grilla 2)
Código	Fecha de otorgamiento	Importe
3.	Las becas del beneficiario seleccionado en la grilla 1. (al cambiar de fila en la grilla 1 se debe actualizar la grilla 3)
Código	Fecha de otorgamiento	Importe


Genere además de las operaciones mencionadas, la posibilidad de realizar altas, bajas y modificaciones sobre los alumnos. También la posibilidad de asignar becas y quitarlas. Finalmente realizar pagos de cuotas.
Validar todos los datos para que no existan datos repetidos (p.e. legajos, códigos etc)
Utilizar Try … Catch para administrar las excepciones del sistema.
No utilizar controles de tipo menú, toda la GUI debe estar en un formulario.
Observe la usabilidad (fácil de utilizar por el usuario, cantidad de clic para una operación, suma claridad en lo que el usuario debe realizar para utilizar en sistema).

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaBecasUniversitarias_TorassaColomberoValentin.Form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaBecasUniversitarias_TorassaColomberoValentin
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        List<Becas> becas = new List<Becas>();

        public Form()
        {
            InitializeComponent();
        }

        //ALUMNOS
        //----------------------------------------------------------------------------------------------------------------
        // BOTON AGREGAR ALUMNO
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Metodo esatatico para instanciar la clase Alumno y agregar un nuevo alumno a la lista.
            MetodosAuxiliares.CrearAlumno(alumnos);

            // Reinicio el origen de datos del DataGridView para que refleje los cambios en la lista de alumnos.
            dtgvAlumnos.DataSource = null;
            dtgvAlumnos.DataSource = alumnos;

            // Ajusto automáticamente el tamaño de las columnas del DataGridView para que se ajusten al contenido.
            dtgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Actualizo el DataGridView para mostrar los cambios.
            dtgvAlumnos.Refresh();
        }

        //BOTON MODIFICAR ALUMNO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una celda seleccionada en el DataGridView de alumnos.
            if (dtgvAlumnos.SelectedCells.Count == 1)
            {
                try
                {
                    int filaAlumnoIndex = dtgvAlumnos.SelectedCells[0].RowIndex;
                    DataGridViewRow alumnoFila = dtgvAlumnos.Rows[filaAlumnoIndex];
                    Alumno alumnoSeleccionado = alumnoFila.DataBoundItem as Alumno;

                    // Solicita ingresar el nuevo nombre utilizando el cuadro de diálogo.
                    string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre:", "Modificar Alumno", alumnoSeleccionado.Nombre);

                    // Solicita ingresar el nuevo apellido.
                    string nuevoApellido = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo apellido:", "Modificar Alumno", alumnoSeleccionado.Apellido);

                    // Solicita ingresar el nuevo DNI y lo convierte a entero.
                    int dni = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("DNI:", "Ingresar DNI"));

                    // Realiza la modificación de los datos del alumno seleccionado.
                    alumnoSeleccionado.Nombre = nuevoNombre;
                    alumnoSeleccionado.Apellido = nuevoApellido;

                    // Actualiza el DataGridView de alumnos para reflejar los cambios.
                    dtgvAlumnos.Refresh();
                }
                catch (Exception)
                {
                    // Si ocurre una excepción durante la modificación, muestra un mensaje de error.
                    MessageBox.Show("Ha completado el campo con un valor inválido o se ha cancelado la operación");
                }
            }
        }

        //BOTON ELIMINAR ALUMNO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una celda seleccionada en el DataGridView de alumnos.
            if (dtgvAlumnos.SelectedCells.Count == 1)
            {
                int filaAlumnoIndex = dtgvAlumnos.SelectedCells[0].RowIndex;

                DataGridViewRow alumnoFila = dtgvAlumnos.Rows[filaAlumnoIndex];

                Alumno alumnoSeleccionado = alumnoFila.DataBoundItem as Alumno;

                // Remueve el alumno seleccionado de la lista de alumnos.
                alumnos.Remove(alumnoSeleccionado);

                dtgvAlumnos.DataSource = null;
                dtgvAlumnos.DataSource = alumnos;

                dtgvAlumnos.Refresh();
            }
        }

        // SE EJECUTA CUANDO SE SALE DEL dtgvALUMNOS
        private void dtgvAlumnos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Limpia el origen de datos actual del DataGridView dgtvSeleccionado.
            dgtvSeleccionado.DataSource = null;

            // Actualiza el DataGridView dgtvSeleccionado para refrescar su contenido.
            dgtvSeleccionado.Refresh();
        }

        //SE EJECUTA CUANDO SE HACE CLICK EN UNA CELDA DEL dgtvAlUMNOS
        private void dtgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtiene el índice de la fila seleccionada en el DataGridView de alumnos.
            int filaAlumnoIndex = dtgvAlumnos.SelectedCells[0].RowIndex;

            // Obtiene la fila completa correspondiente al índice de la fila seleccionada en el DataGridView de alumnos.
            DataGridViewRow alumnoFila = dtgvAlumnos.Rows[filaAlumnoIndex];

            // Obtiene el objeto Alumno asociado a la fila seleccionada en el DataGridView de alumnos.
            Alumno alumnoSeleccionado = alumnoFila.DataBoundItem as Alumno;

            // Muestra la beca del alumno seleccionado en el DataGridView dgtvSeleccionado.
            alumnoSeleccionado.MostrarBeca(dgtvSeleccionado);
        }


        //BECAS
        //----------------------------------------------------------------------------------------------------------------
        //BOTON CREAR BECA
        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Llama al método estático CrearBeca de la clase MetodosAuxiliares y pasa la lista de becas como argumento.
            MetodosAuxiliares.CrearBeca(becas);

            // Limpia el origen de datos actual del DataGridView de becas.
            dgtvBecas.DataSource = null;
            // Establece la lista de becas como el nuevo origen de datos del DataGridView.
            dgtvBecas.DataSource = becas;

            dgtvBecas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvBecas.Refresh();
        }

        //BOTON BORRAR BECA
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verifica si hay 1 celdas seleccionadas en el DataGridView de becas.
            if (dgtvBecas.SelectedCells.Count == 1)
            {
                int filaBecaIndex = dgtvBecas.SelectedCells[0].RowIndex;

                DataGridViewRow becaFila = dgtvBecas.Rows[filaBecaIndex];

                // Obtiene el objeto Becas asociado a la fila seleccionada en el DataGridView de becas.
                Becas becaSeleccionada = becaFila.DataBoundItem as Becas;

                // Remueve la beca seleccionada de la lista de becas.
                becas.Remove(becaSeleccionada);

                dgtvBecas.DataSource = null;
                dgtvBecas.DataSource = becas;

                dgtvBecas.Refresh();
            }
        }


        //BECAS-ALUMNO
        //-----------------------------------------------------------------------
        //BOTON ASIGNAR BECA A ALUMNO
        private void btnAsignar_Click(object sender, EventArgs e)
        {

            // Verifica si hay una celda seleccionada tanto en el DataGridView de alumnos como en el DataGridView de becas.
            if (dtgvAlumnos.SelectedCells.Count == 1 && dgtvBecas.SelectedCells.Count == 1)
            {
                // Obtiene el índice de la fila seleccionada en el DataGridView de alumnos.
                int filaAlumnoIndex = dtgvAlumnos.SelectedCells[0].RowIndex;

                // Obtiene el índice de la fila seleccionada en el DataGridView de becas.
                int filaBecaIndex = dgtvBecas.SelectedCells[0].RowIndex;

                // Obtiene la fila completa correspondiente al índice de la fila seleccionada en el DataGridView de alumnos.
                DataGridViewRow alumnoFila = dtgvAlumnos.Rows[filaAlumnoIndex];

                // Obtiene la fila completa correspondiente al índice de la fila seleccionada en el DataGridView de becas.
                DataGridViewRow becaFila = dgtvBecas.Rows[filaBecaIndex];

                // Obtiene el objeto Alumno asociado a la fila seleccionada en el DataGridView de alumnos.
                Alumno alumnoSeleccionado = alumnoFila.DataBoundItem as Alumno;

                // Obtiene el objeto Becas asociado a la fila seleccionada en el DataGridView de becas.
                Becas becaSeleccionada = becaFila.DataBoundItem as Becas;

                // Asigna la beca seleccionada al alumno seleccionado.
                alumnoSeleccionado.AsignarBeca(becaSeleccionada);

                // Muestra la beca asignada al alumno en el dgtvSeleccionado
                alumnoSeleccionado.MostrarBeca(dgtvSeleccionado);

                // Remueve la beca seleccionada de la lista de becas.
                becas.Remove(becaSeleccionada);

                dgtvBecas.DataSource = null;
                dgtvBecas.DataSource = becas;

                dgtvBecas.Refresh();
            }

        }

        //BOTON REMOVER BECA A ALUMNO
        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica si hay una celda seleccionada en el DataGridView de alumnos.
            if (dtgvAlumnos.SelectedCells.Count == 1)
            {
                // Intenta realizar la operación de remover la beca del alumno seleccionado y agregarla a la lista de becas.
                try
                {
                    int filaAlumnoIndex = dtgvAlumnos.SelectedCells[0].RowIndex;
                    DataGridViewRow alumnoFila = dtgvAlumnos.Rows[filaAlumnoIndex];
                    Alumno alumnoSeleccionado = alumnoFila.DataBoundItem as Alumno;

                    // Invoca el método invocarBeca del alumno seleccionado y agrega la beca devuelta a la lista de becas.
                    becas.Add(alumnoSeleccionado.invocarBeca());

                    dgtvBecas.DataSource = null;
                    dgtvBecas.DataSource = becas;
                    dgtvBecas.Refresh();

                    // Remueve la beca del alumno seleccionado.
                    alumnoSeleccionado.RemoverBeca();

                    dgtvSeleccionado.DataSource = null;

                    dgtvBecas.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha completado el campo con un valor inválido o se ha cancelado la operación");
                }
            }
        }
        //------------------------------------------------------------------

        //BOTON DE SIMULAR PAGO
        private void btnSimularPago_Click(object sender, EventArgs e)
        {
            try
            {
                int filaAlumnoIndex = dtgvAlumnos.SelectedCells[0].RowIndex;
                DataGridViewRow alumnoFila = dtgvAlumnos.Rows[filaAlumnoIndex];
                Alumno alumnoSeleccionado = alumnoFila.DataBoundItem as Alumno;

                // Verificar si el alumno tiene asignada una beca
                if (alumnoSeleccionado.invocarBeca() != null)
                {
                    // Obtener el importe de la beca asignada al alumno
                    int importeBeca = alumnoSeleccionado.invocarBeca().Importe;

                    // Restar el importe deducido del importe original del pago
                    int importe = 30000 - importeBeca;
                    double porcentaje = importeBeca * 100 / 30000;

                    // Mostrar el importe final en algún lugar (por ejemplo, un TextBox)
                    MessageBox.Show($"El alumno debe ${importe}. Gracias a una beca que cubre el {porcentaje}% de la cuota");
                }
                else
                {
                    // El alumno no tiene asignada una beca, mostrar un mensaje o realizar alguna acción adicional
                    MessageBox.Show("El alumno debe $30000.");
                }
            }
            catch (Exception)
            {
                // Manejar cualquier excepción que ocurra durante el proceso
                MessageBox.Show("Ha ocurrido un error al simular el pago.");
            }
        }
    }

    //CLASE BECAS
    public class Becas
    {
        // Propiedades de la clase Becas
        public string Codigo { get { return _codigo; } set { _codigo = value; } }
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public int Importe { get { return _importe; } set { _importe = value; } }

        // Constructor predeterminado de la clase Becas
        public Becas()
        {
        }

        // Constructor parametrizado de la clase Becas
        public Becas(string codigo, string fecha, int importe)
        {
            _codigo = codigo;
            _fecha = fecha;
            _importe = importe;
        }

        // Campos privados de la clase Becas
        private string _codigo;
        private string _fecha;
        private int _importe;
    }

    //CLASE ALUMNO
    public class Alumno
    {
        // Propiedades de la clase Alumno
        public int Legajo { get => _legajo; set => _legajo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }

        // Constructor de la clase Alumno
        public Alumno(int legajo, string nombre, string apellido, int dni)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
        }

        // Método para asignar una beca al alumno
        public void AsignarBeca(Becas beca)
        {
            _becaAlumno = beca;
        }

        // Método para remover la beca del alumno
        public void RemoverBeca()
        {
            _becaAlumno = null;
        }

        // Método para obtener la beca del alumno
        public Becas invocarBeca()
        {
            return _becaAlumno;
        }

        // Método para mostrar la beca del alumno en un DataGridView especificado
        public void MostrarBeca(DataGridView seleccionado)
        {
            if (_becaAlumno != null)
            {
                List<Becas> becas = new List<Becas>();
                becas.Add(_becaAlumno);
                seleccionado.DataSource = becas;
                seleccionado.Refresh();
            }
        }

        // Campos privados de la clase Alumno
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private Becas _becaAlumno;
    }


    //CLASE ESTATICA METODOS AUXILIARES
    public static class MetodosAuxiliares
    {

        //METODO PARA CREAR UN OBJETO DE LA CLASE ALUMNO
        public static void CrearAlumno(List<Alumno> alumnos)
        {
            // Método estático para crear un nuevo alumno y agregarlo a la lista de alumnos
            Random random = new Random();
            try
            {
                // Generar un número de legajo aleatorio
                int legajo = random.Next(1000);
                // Solicitar el nombre del alumno
                string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre:", "Ingresar nombre");
                ValidarInput(nombre); // Llamada a una función de validación (debe estar definida en otro lugar)

                // Solicitar el apellido del alumno
                string apellido = Microsoft.VisualBasic.Interaction.InputBox("Apellido:", "Ingresar Apellido");

                // Solicitar el DNI del alumno y convertirlo a entero
                int dni = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("DNI:", "Ingresar DNI"));

                // Crear un nuevo objeto de la clase Alumno con los valores proporcionados
                alumnos.Add(new Alumno(legajo, nombre, apellido, dni));
            }
            catch (Exception)
            {
                MessageBox.Show("Ha completado el campo con un valor inválido o se ha cancelado la operación");
            }
        }

        //METODO PARA CREAR UN OBJETO DE LA CLASE BECA
        public static void CrearBeca(List<Becas> becas)
        {
            try
            {
                // Solicitar al usuario el código alfanumérico de la beca
                string codigo = Microsoft.VisualBasic.Interaction.InputBox("Codigo Alfanumerico (4 digitos y 2 letras):", "Ingresar Codigo Alfanumerico");

                // Verificar que el código cumpla con el patrón especificado (4 dígitos seguidos de 2 letras)
                if (!Regex.IsMatch(codigo, @"^\d{4}[a-zA-Z]{2}$"))
                {
                    throw new InvalidOperationException();
                }

                // Solicitar al usuario la fecha de otorgamiento de la beca
                string fecha = Microsoft.VisualBasic.Interaction.InputBox("Fecha de Otorgamiento:", "Ingresar Fecha de Otorgamiento", "dd/mm/yyyy");

                // Verificar que la fecha pueda ser parseada correctamente
                DateTime.Parse(fecha);

                // Solicitar al usuario el monto a deducir de la cuota (debe ser menor a $30000)
                int monto = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Monto a Deducir (Menor a $30000):", "Ingresar Monto a Deducir de la cuota"));

                // Crear un nuevo objeto de la clase Becas con los valores proporcionados
                becas.Add(new Becas(codigo, fecha, monto));
            }
            catch (Exception)
            {
                MessageBox.Show("Ha completado el campo con un valor inválido o se ha cancelado la operación");
            }
        }

        //METODO PARA VALIDAR ENTRADA
        public static void ValidarInput(string input)
        {
            // Verificar si el valor de entrada es nulo o vacío
            if (string.IsNullOrEmpty(input) || input == null)
            {
                // Si es nulo o vacío, lanzar una excepción de tipo InvalidOperationException
                throw new InvalidOperationException();
            }
        }

    }

}
