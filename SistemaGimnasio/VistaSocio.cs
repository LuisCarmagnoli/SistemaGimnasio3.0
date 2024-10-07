using SistemaGimnasio.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio
{
    public partial class VistaSocio : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private int idUsuario = 2;
        public VistaSocio()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();

            // Suscribir el evento CellClick
            gridReservas.CellClick += gridReservas_CellClick;

        }

        private void VistaSocio_Load(object sender, EventArgs e)
        {
            PopulateReservas(idUsuario);
        }

        #region EVENTS
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Llamar a la capa de negocio para buscar las clases
                List<Reserva> resultados = _businessLogicLayer.SearchReservas(searchTerm, idUsuario);

                // Actualizar el DataGridView con los resultados
                gridReservas.DataSource = resultados;
            }
            else
            {
                // Si el campo de búsqueda está vacío, volver a cargar todas las clases
                PopulateReservas(idUsuario);
            }
        }


        private void gridReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Permitir seleccionar la fila completa al hacer clic en cualquier celda
            if (e.RowIndex >= 0)
            {
                gridReservas.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region PRIVATE METHODS

        public void PopulateReservas(int idUsuario)
        {
            List<Reserva> reservas = _businessLogicLayer.GetReservas(idUsuario);
            gridReservas.DataSource = reservas;
        }

        #endregion

        private void gridReservas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Permitir seleccionar la fila completa al hacer clic en cualquier celda
            if (e.RowIndex >= 0)
            {
                gridReservas.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnReservarLugar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (gridReservas.SelectedRows.Count > 0)
            {
                // Obtener la clase seleccionada
                Reserva reserva = (Reserva)gridReservas.SelectedRows[0].DataBoundItem;

                _businessLogicLayer.ReservarLugar(reserva, idUsuario);

                PopulateReservas(idUsuario);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (gridReservas.SelectedRows.Count > 0)
            {
                // Obtener la clase seleccionada
                Reserva reserva = (Reserva)gridReservas.SelectedRows[0].DataBoundItem;

                _businessLogicLayer.CancelarReserva(reserva, idUsuario);

                PopulateReservas(idUsuario);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }
    }
}
