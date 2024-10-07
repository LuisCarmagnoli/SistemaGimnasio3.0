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
        private readonly int idUsuario;
        public VistaSocio(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            _businessLogicLayer = new BusinessLogicLayer();

            // Suscribir el evento CellClick
            gridReservas.CellClick += gridReservas_CellClick;

        }

        private void VistaSocio_Load(object sender, EventArgs e)
        {
            PopulateReservas(idUsuario);

            if (gridReservas.Rows.Count > 0)
            {
                // Seleccionar la primera fila
                gridReservas.Rows[0].Selected = true;
            }
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

        #endregion

        #region PRIVATE METHODS

        public void PopulateReservas(int idUsuario)
        {
            List<Reserva> reservas = _businessLogicLayer.GetReservas(idUsuario);
            gridReservas.DataSource = reservas;
        }

        #endregion

        private void btnReservarLugar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (gridReservas.SelectedRows.Count > 0)
            {
                // Obtener la clase seleccionada
                Reserva reserva = (Reserva)gridReservas.SelectedRows[0].DataBoundItem;

                _businessLogicLayer.ReservarLugar(reserva, idUsuario);

                PopulateReservas(idUsuario);

                SelectReserva(reserva);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (gridReservas.SelectedRows.Count > 0)
            {
                // Obtener la clase seleccionada
                Reserva reserva = (Reserva)gridReservas.SelectedRows[0].DataBoundItem;

                _businessLogicLayer.CancelarReserva(reserva, idUsuario);

                PopulateReservas(idUsuario);

                SelectReserva(reserva);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }

        private void VistaSocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gridReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Permitir seleccionar la fila completa al hacer clic en cualquier celda
            if (e.RowIndex >= 0)
            {
                gridReservas.Rows[e.RowIndex].Selected = true;
            }
        }

        private void SelectReserva(Reserva reserva)
        {
            // Buscar la fila correspondiente a la reserva
            foreach (DataGridViewRow row in gridReservas.Rows)
            {
                if (row.DataBoundItem is Reserva r && r.IdReserva == reserva.IdReserva) // Asegúrate de que ID es el identificador único de la reserva
                {
                    row.Selected = true;
                    gridReservas.CurrentCell = row.Cells[0]; // Opcional: enfocar la primera celda de la fila
                    break;
                }
            }
        }
    }
}
