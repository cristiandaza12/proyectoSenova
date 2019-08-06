using System;
using System.Collections.Generic;
using System.Text;

namespace proyectoSenova
{
    public class Proyecto
    {
        #region Atributos

        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion

        #region contructores
        public Proyecto(string nombre, double codigo, string area, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {

        }
        public Proyecto(string area, int duracion)
        {
            Area = area;
            Duracion = duracion;

        }
        #endregion

        #region metodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el area del proyecto");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion del proyecto");
            var dura = Console.ReadLine();
            Duracion = int.Parse(dura);

        }
        public void ImprimirProyecto()
        {
            Console.WriteLine($"el nombre del proyecto es:{Nombre}");
            Console.WriteLine($"el codigo del proyecto es:{Codigo}");
            Console.WriteLine($"la duracion del proyecto es:{Duracion}");
            Console.WriteLine($"el area del proyecto es:{Area}");
        }


        #endregion
    }
}
