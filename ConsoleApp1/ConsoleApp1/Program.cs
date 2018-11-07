using System;
using System.IO;

namespace Archivo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definición de variables
            System.String Dijo = "Si";
            System.String Apellido;
            System.String Nombre;
            System.String Celular;

            string fileName = "Agenda.txt";
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            while (Dijo == "Si")
            {
                //Carga los datos por teclado
                Console.Write("Ingrese el Apellido: ");
                Apellido = Console.ReadLine();
                Console.Write("Ingrese el Nombre: ");
                Nombre = Console.ReadLine();
                Console.Write("Ingrese el Celular: ");
                Celular = Console.ReadLine();

                //Graba o escribe
                writer.WriteLine("{0} {1} {2}", Apellido, Nombre, Celular);
                Console.Write("Desea Ingresar otro (Si/No): ");
                Dijo = Console.ReadLine();
            }
            writer.Close();
        }
    }
}
