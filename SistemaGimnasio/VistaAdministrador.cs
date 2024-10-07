using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio.View
{
    public partial class VistaAdministrador : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public VistaAdministrador()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();

            // Suscribir el evento CellClick
            gridClases.CellClick += gridClases_CellClick;
        }

        #region EVENTS
        private void VistaAdministrador_Load(object sender, EventArgs e)
        {
            PopulateClases();

            if (gridClases.Rows.Count > 0)
            {
                // Seleccionar la primera fila
                gridClases.Rows[0].Selected = true;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
            gridClases.Rows[0].Selected = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (gridClases.SelectedRows.Count > 0)
            {
                // Obtener la clase seleccionada
                Clase claseSeleccionada = (Clase)gridClases.SelectedRows[0].DataBoundItem;
                
                // Abrir la ventana de detalles de clase con los datos de la clase seleccionada
                ClaseDetailsView claseDetailsView = new ClaseDetailsView(claseSeleccionada);
                claseDetailsView.ShowDialog(this);

                // Después de cerrar el diálogo, restablecer la selección
                int index = gridClases.Rows.Cast<DataGridViewRow>()
                    .ToList() // Convierte a lista para evitar problemas de enumeración
                    .FindIndex(r => r.DataBoundItem is Clase clase && clase.IdClase == claseSeleccionada.IdClase);

                if (index >= 0)
                {
                    gridClases.ClearSelection(); // Limpiar selección actual
                    gridClases.Rows[index].Selected = true; // Seleccionar la fila editada
                    gridClases.FirstDisplayedScrollingRowIndex = index; // Desplazar si es necesario
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase para editar.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (gridClases.SelectedRows.Count > 0)
            {
                // Obtener la clase seleccionada
                Clase claseSeleccionada = (Clase)gridClases.SelectedRows[0].DataBoundItem;

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta clase?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar a la capa de negocio para eliminar la clase
                    _businessLogicLayer.BorrarClase(claseSeleccionada.IdClase);

                    // Actualizar el DataGridView
                    PopulateClases();
                }

                gridClases.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase para borrar.");
            }

            gridClases.Rows[0].Selected = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Llamar a la capa de negocio para buscar las clases
                List<Clase> resultados = _businessLogicLayer.SearchClases(searchTerm);

                // Actualizar el DataGridView con los resultados
                gridClases.DataSource = resultados;
            }
            else
            {
                // Si el campo de búsqueda está vacío, volver a cargar todas las clases
                PopulateClases();
            }
        }

        private void gridClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Permitir seleccionar la fila completa al hacer clic en cualquier celda
            if (e.RowIndex >= 0)
            {
                gridClases.Rows[e.RowIndex].Selected = true;
            }
        }
        #endregion

        #region PRIVATE METHODS

        private void OpenContactDetailsDialog()
        {
            ClaseDetailsView claseDetailsView = new ClaseDetailsView();
            claseDetailsView.ShowDialog(this);
        }
        public void PopulateClases()
        {
            List<Clase> clases = _businessLogicLayer.GetClases();
            gridClases.DataSource = clases;
        }

        #endregion

        private void VistaAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
