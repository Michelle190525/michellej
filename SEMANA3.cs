using System;

namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    class Estudiante
    {
        // Atributos de la clase
        public int Id;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public string[] Telefonos; // Array para teléfonos

        // Método para mostrar los datos del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);

            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine("Teléfono " + (i + 1) + ": " + Telefonos[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Telefonos = new string[3];

            Console.Write("Ingrese ID: ");
            estudiante.Id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Nombres: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese Apellidos: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese Dirección: ");
            estudiante.Direccion = Console.ReadLine();

            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                Console.Write("Ingrese Teléfono " + (i + 1) + ": ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            estudiante.MostrarDatos();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

