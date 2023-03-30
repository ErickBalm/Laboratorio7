using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    internal class Datos
    {
        String nombre;
        String apellido;
        String numerodeCasa;
        int cuotadeMantenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NumerodeCasa { get => numerodeCasa; set => numerodeCasa = value; }
        public int CuotadeMantenimiento { get => cuotadeMantenimiento; set => cuotadeMantenimiento = value; }
    }
}
