using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernizacionEcuadorPractico.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public int HorasExtras { get; set; }

        // Propiedad calculada: El salario base + $15 por cada hora extra
        public decimal SalarioTotal
        {
            get { return SalarioBase + (HorasExtras * 15); }
        }
    }
}
