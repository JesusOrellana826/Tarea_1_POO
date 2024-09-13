using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01_POO_1_Jesus_Orellana
{
    public class Coordinador
    {
        // ATRIBUTOS
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public int Telefono { get; set; }

        // MÉTODOS
        public double Sueldo()
        {
            double Sueldo;
            switch (Categoria)
            {
                case 1: Sueldo = 8500; break;
                case 2: Sueldo = 6850; break;
                default: Sueldo = 5500; break;
            }
            return Sueldo;
        }
    }
}
