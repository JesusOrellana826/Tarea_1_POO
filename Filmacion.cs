using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01_POO_1_Jesus_Orellana
{
    public class Filmacion
    {
        //ATRIBUTOS
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int DuracionMinutos { get; set; }
        public double Precio { get; set; }

        //CONSTRUCTOR
        public Filmacion()
        {
            Precio = 3.59;
        }

        //MÉTODOS
        public double PrecioDolares()
        {
            return Precio / 3.59;
        }
    }
}
