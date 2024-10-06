using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public Clase GuardarClase(Clase clase)
        {
            if (clase.IdClase == 0)
                _dataAccessLayer.InsertClase(clase);
            else
                _dataAccessLayer.UpdateClase(clase); // Agregar llamada a método de actualización
            return clase;
        }

        public void BorrarClase(int idClase)
        {
            _dataAccessLayer.DeleteClase(idClase);
        }

        public List<Clase> GetClases()
        {
            return _dataAccessLayer.GetClases();
        }

        public List<Clase> SearchClases(string searchTerm)
        {
            return _dataAccessLayer.SearchClases(searchTerm);
        }
    }
}
