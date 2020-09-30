using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutValidation.Models
{
    public class EmpleadoService
    {
        private static List<Empleado> empleados;

        public EmpleadoService()
        {
            if (empleados == null)
            {
                empleados = new List<Empleado>();
            }
        
        }

        public void Crear(Empleado em)
        {
            empleados.Add(em);
        }

        public List<Empleado> ListarTodos()
        {
            return empleados;
        
        }

    }
}