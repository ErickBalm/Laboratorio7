using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    internal class Propiedades
    {String numerodeCasa; 
           String dpi;
           int cuotadeMantenimiento;
           

        public string NumerodeCasa { get => numerodeCasa; set => numerodeCasa = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public int CuotadeMantenimiento { get => cuotadeMantenimiento; set => cuotadeMantenimiento = value; }
    }
}
