using ModernizacionEcuadorPractico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernizacionEcuadorPractico.Controlador
{
    public class NominaController
    {
        // Simulamos una base de datos en memoria con una lista
        private List<Empleado> _empleados;
        private int _contadorId = 1;

        public NominaController()
        {
            _empleados = new List<Empleado>();
        }

        public void RegistrarEmpleado(string nombre, decimal salarioBase, int horasExtras)
        {
            var nuevoEmpleado = new Empleado
            {
                Id = _contadorId++,
                Nombre = nombre,
                SalarioBase = salarioBase,
                HorasExtras = horasExtras
            };

            _empleados.Add(nuevoEmpleado);
        }

        public List<Empleado> ObtenerTodos()
        {
            return _empleados.ToList();
        }
    }
}
