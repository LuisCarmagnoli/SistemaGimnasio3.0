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

        #region EVENTS

        private void ClaseDetailsView_Load(object sender, EventArgs e)
        {
            btnCancelar.Select();
            EstablecerPlaceHolders();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
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

        private void txtNombreClase_Enter(object sender, EventArgs e)
        {
            if (txtNombreClase.Text == "Nombre de la clase")
            {
                txtNombreClase.Text = "";
                txtNombreClase.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreClase_Leave(object sender, EventArgs e)
        {
            if (txtNombreClase.Text == "")
            {
                txtNombreClase.Text = "Nombre de la clase";
                txtNombreClase.ForeColor = Color.DimGray;
            }
        }

        private void txtNombreInstructor_Enter(object sender, EventArgs e)
        {
            if (txtNombreInstructor.Text == "Nombre del instructor")
            {
                txtNombreInstructor.Text = "";
                txtNombreInstructor.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreInstructor_Leave(object sender, EventArgs e)
        {
            if (txtNombreInstructor.Text == "")
            {
                txtNombreInstructor.Text = "Nombre del instructor";
                txtNombreInstructor.ForeColor = Color.DimGray;
            }
        }

        private void txtDias_Enter(object sender, EventArgs e)
        {
            if (txtDias.Text == "Dias")
            {
                txtDias.Text = "";
                txtDias.ForeColor = Color.LightGray;
            }
        }

        private void txtDias_Leave(object sender, EventArgs e)
        {
            if (txtDias.Text == "")
            {
                txtDias.Text = "Dias";
                txtDias.ForeColor = Color.DimGray;
            }
        }

        private void txtHorario_Enter(object sender, EventArgs e)
        {
            if (txtHorario.Text == "Horario")
            {
                txtHorario.Text = "";
                txtHorario.ForeColor = Color.LightGray;
            }
        }

        private void txtHorario_Leave(object sender, EventArgs e)
        {
            if (txtHorario.Text == "")
            {
                txtHorario.Text = "Horario";
                txtHorario.ForeColor = Color.DimGray;
            }
        }

        private void txtCapacidad_Enter(object sender, EventArgs e)
        {
            if (txtCapacidad.Text == "Capacidad")
            {
                txtCapacidad.Text = "";
                txtCapacidad.ForeColor = Color.LightGray;
            }
        }

        private void txtCapacidad_Leave(object sender, EventArgs e)
        {
            if (txtCapacidad.Text == "")
            {
                txtCapacidad.Text = "Capacidad";
                txtCapacidad.ForeColor = Color.DimGray;
            }
        }
        #endregion

        private bool GuardarClase()
        {
            // Limpiar los mensajes de error antes de validar
            LimpiarMensajesError();

            try
            {
                Clase clase = new Clase
                {
                    IdClase = IdClase,
                    NombreClase = txtNombreClase.Text,
                    NombreInstructor = txtNombreInstructor.Text,
                    Dias = txtDias.Text,
                    Horario = txtHorario.Text,
                    Capacidad = 0 // Inicializamos con 0; se asignará después de validar
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
                // Manejo de errores en caso de excepciones
                //lblErrorGeneral.Text = "Ocurrió un error: " + ex.Message;
                return false;
            }
        }

        public bool ValidarFormatoCamposDeTexto(Clase clase)
        {
            // Limpiar los mensajes de error antes de validar
            LimpiarMensajesError();

            bool hayError = false;

            // Validar que el nombre de la clase esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreClase) || clase.NombreClase.Length < 3 || clase.NombreClase.Length > 50 || !ValidarCampoDiferenteDePlaceholder(txtNombreClase))
            {
                lblErrorNombreClase.Text = "El nombre de la clase debe tener entre 3 y 50 caracteres.";
                hayError = true;
            }

            // Validar que el nombre del instructor esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreInstructor) || clase.NombreInstructor.Length < 3 || clase.NombreInstructor.Length > 50 || !ValidarCampoDiferenteDePlaceholder(txtNombreInstructor))
            {
                lblErrorNombreInstructor.Text = "El nombre del instructor debe tener entre 3 y 50 caracteres.";
                hayError = true;
            }

            // Validar que los días estén entre 5 y 100 caracteres
            if (string.IsNullOrWhiteSpace(clase.Dias) || clase.Dias.Length < 5 || clase.Dias.Length > 100)
            {
                lblErrorDias.Text = "Los días deben tener entre 5 y 100 caracteres.";
                hayError = true;
            }

            // Validar que el formato de horario sea HH:MM:SS
            if (!ValidarHorario(clase.Horario))
            {
                lblErrorHorario.Text = "Por favor, ingresa un horario válido en formato HH:MM:SS.";
                hayError = true;
            }

            // Validar capacidad
            if (string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                lblErrorCapacidad.Text = "El campo capacidad no puede estar vacío.";
                hayError = true;
            }
            else if (!int.TryParse(txtCapacidad.Text, out int capacidad) || capacidad < 1 || capacidad > 100)
            {
                lblErrorCapacidad.Text = "La capacidad debe ser un número entero entre 1 y 100.";
                hayError = true;
            }
            else
            {
                clase.Capacidad = capacidad; // Asignar el valor validado a la clase
            }

            return !hayError; // Retorna verdadero si no hay errores
        }

        public bool ValidarCampoDiferenteDePlaceholder(TextBox textBox)
        {
            // Ignorar la validación si el texto es igual al placeholder
            if (textBox.Text == textBox.Tag.ToString())
            {
                return false; // No es válido
            }
            return true;
        }

        private bool ValidarHorario(string horario)
        {
            // Expresión regular para validar el formato HH:MM:SS
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            return Regex.IsMatch(horario, pattern);
        }

        private void LimpiarMensajesError()
        {
            // Limpia los textos de los labels de error
            lblErrorNombreClase.Text = "";
            lblErrorNombreInstructor.Text = "";
            lblErrorDias.Text = "";
            lblErrorHorario.Text = "";
            lblErrorCapacidad.Text = "";
        }

        private void EstablecerPlaceHolders()
        {
            // Establecer los placeholders si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(txtNombreClase.Text))
            {
                txtNombreClase.Text = "Nombre de la clase";
                txtNombreClase.ForeColor = Color.DimGray;
            }

            if (string.IsNullOrWhiteSpace(txtNombreInstructor.Text))
            {
                txtNombreInstructor.Text = "Nombre del instructor";
                txtNombreInstructor.ForeColor = Color.DimGray;
            }

            if (string.IsNullOrWhiteSpace(txtDias.Text))
            {
                txtDias.Text = "Dias";
                txtDias.ForeColor = Color.DimGray;
            }

            if (string.IsNullOrWhiteSpace(txtHorario.Text))
            {
                txtHorario.Text = "Horario";
                txtHorario.ForeColor = Color.DimGray;
            }

            if (string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                txtCapacidad.Text = "Capacidad";
                txtCapacidad.ForeColor = Color.DimGray;
            }
        }
    }
}
