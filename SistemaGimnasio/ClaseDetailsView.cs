using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio.View
{
    public partial class ClaseDetailsView : Form
    {
        public int IdClase { get; set; }

        private BusinessLogicLayer _businessLogicLayer;

        public ClaseDetailsView()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        public ClaseDetailsView(Clase clase)
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();

            // Rellenar los TextBox con los datos de la clase recibida
            txtNombreClase.Text = clase.NombreClase;
            txtNombreInstructor.Text = clase.NombreInstructor;
            txtDias.Text = clase.Dias;
            txtHorario.Text = clase.Horario;
            txtCapacidad.Text = clase.Capacidad.ToString();

            // Almacenar el ID de la clase para la actualización
            IdClase = clase.IdClase;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (GuardarClase())
            {
                this.Close();
                ((VistaAdministrador)this.Owner).PopulateClases();
            }
        }

        private bool GuardarClase()
        {
            try
            {
                Clase clase = new Clase
                {
                    IdClase = IdClase,
                    NombreClase = txtNombreClase.Text,
                    NombreInstructor = txtNombreInstructor.Text,
                    Dias = txtDias.Text,
                    Horario = txtHorario.Text,
                    Capacidad = int.Parse(txtCapacidad.Text)
                };

                if (ValidarFormatoCamposDeTexto(clase))
                {
                    _businessLogicLayer.GuardarClase(clase);
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidarFormatoCamposDeTexto(Clase clase)
        {
            // Validar que el nombre de la clase esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreClase) || clase.NombreClase.Length < 3 || clase.NombreClase.Length > 50)
            {
                MessageBox.Show("El nombre de la clase debe tener entre 3 y 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el nombre del instructor esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreInstructor) || clase.NombreInstructor.Length < 3 || clase.NombreInstructor.Length > 50)
            {
                MessageBox.Show("El nombre del instructor debe tener entre 3 y 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que los días estén entre 5 y 100 caracteres
            if (string.IsNullOrWhiteSpace(clase.Dias) || clase.Dias.Length < 5 || clase.Dias.Length > 100)
            {
                MessageBox.Show("Los días deben tener entre 5 y 100 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el formato de horario sea HH:MM:SS
            if (!ValidarHorario(clase.Horario))
            {
                MessageBox.Show("Por favor, ingresa un horario válido en formato HH:MM:SS.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que la capacidad no esté vacía y sea un número entre 1 y 100
            if (!int.TryParse(clase.Capacidad.ToString(), out int capacidad) || capacidad < 1 || capacidad > 100)
            {
                MessageBox.Show("La capacidad debe ser un número entero entre 1 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarHorario(string horario)
        {
            // Expresión regular para validar el formato HH:MM:SS
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            return Regex.IsMatch(horario, pattern);
        }
    }
}
