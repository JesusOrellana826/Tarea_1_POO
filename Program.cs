using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01_POO_1_Jesus_Orellana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region INSTANCIA DE LA CLASE FILMACION
            //Filmacion fil1 = new Filmacion();
            //fil1.Codigo = 1001;
            //fil1.Titulo = "Escena de acción";
            //fil1.DuracionMinutos = 10;
            //fil1.Precio = 359;

            //Listar("Código               : " + fil1.Codigo);
            //Listar("Título               : " + fil1.Titulo);
            //Listar("Minutos de duración  : " + fil1.DuracionMinutos + " min");
            //Listar("Precio en Soles      : " + "S/. " + fil1.Precio);
            //Listar("Precio en dólares    : " + "$ " + fil1.PrecioDolares());

            //Console.ReadKey();
            #endregion

            #region INSTANCIA DE LA CLASE PERSONA

            Persona p1 = new Persona();
            //p1.Nombre = "pedro";
            //p1.Apellido = "lópez";
            //p1.Edad = 35;
            //p1.Estatura = 1.75;
            //p1.Peso = 70;

            //Listar("nombre             : " + p1.Nombre);
            //Listar("apellido           : " + p1.Apellido);
            //Listar("edad               : " + p1.Edad);
            //Listar("estatura en metros : " + p1.Estatura);
            //Listar("peso               : " + p1.Peso + " kg");
            //Listar("estado             : " + p1.EstadoEdad());
            //Listar("imc                : " + p1.CalcularMasaCorporal().ToString("f2") + " kg");

            //Console.ReadKey();

            #endregion

            #region INSTANCIA DE LA CLASE COORDINADOR
            Coordinador coo1 = new Coordinador();
            coo1.Codigo = 2001;
            coo1.Nombre = "Jimena";
            coo1.Categoria = 3;
            coo1.Telefono = 965444333;

            Listar("Código    : " + coo1.Codigo);
            Listar("Nombre    : " + coo1.Nombre);
            Listar("Categoria : " + coo1.Categoria);
            Listar("Teléfono  : " + coo1.Telefono);
            Listar("Sueldo    : " + coo1.Sueldo());

            Console.ReadKey();
            #endregion
        }

        public static void Listar(string Mensaje)
        {
            Console.WriteLine(Mensaje);
        }
    }
}
