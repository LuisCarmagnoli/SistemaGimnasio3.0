using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio.View
{
    public partial class ClaseDetailsView : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public int IdClase { get; set; }

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
                _businessLogicLayer.GuardarClase(clase);
                return true; // Indicar que se guardó correctamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Indicar que hubo un error
            }
        }
    }
}
