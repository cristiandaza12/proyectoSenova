using System;

namespace proyectoSenova
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int puntaje = 0;
            Proyecto miProyecto = new Proyecto();
            Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            Proyecto miProyecto4 = new Proyecto("Realidad aumentada", 12540, "sistemas", 10);

            //miProyecto3.IngresarProyecto();
            //miProyecto3.IngresarProyecto();
            miProyecto4.ImprimirProyecto();

            //miProyecto.area = "sistemas";
            //miProyecto.codigo = 12000;
            //miProyecto.duracion = 13;
            //miProyecto.nombre = "desarrollo internet de las cosas IOT";
            //miProyecto2.area = "redes";
            //miProyecto2.codigo = 13000;
            //miProyecto2.duracion = 14;
            //miProyecto2.nombre = "desarrollo arduino";
            //Console.WriteLine($"area:{miProyecto.area}");
            //Console.WriteLine($"area:{miProyecto2.area}");
            //Console.WriteLine($"codigo:{miProyecto.codigo}");
            //Console.WriteLine($"codigo:{miProyecto2.area}");
            //Console.WriteLine($"duracion:{miProyecto.duracion}");
            //Console.WriteLine($"duracion:{miProyecto2.area}");
            //Console.WriteLine($"nombre:{miProyecto.nombre}");
            //Console.WriteLine($"nombre:{miProyecto2.area}");
            Console.ReadLine();
        }
    }
}
