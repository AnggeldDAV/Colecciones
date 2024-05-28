using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05LinqBasico
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
        public override string ToString()
        {
            return $"{this.Nombre} {this.FechaNacimiento} {this.Sueldo}";
        }
    }
}
