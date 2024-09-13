using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01_POO_1_Jesus_Orellana
{
    public class Persona
    {
        //ATRIBUTOS
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }

        //MÉTODOS
        public string EstadoEdad()
        {
            if (Edad <= 18) return "Eres menor de edad";
            else return "Ya eres mayor de edad";
        }

        public double CalcularMasaCorporal()
        {
            return Peso / (Estatura * Estatura);
        }
    }
}
