
using System;

// Clase principal del programa
class Program
{
    static Turno[] turnos = new Turno[5];
    static int contador = 0;

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- AGENDA DE TURNOS DE PACIENTES ---");
            Console.WriteLine("1. Registrar turno");
            Console.WriteLine("2. Listar turnos");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: RegistrarTurno(); break;
                case 2: ListarTurnos(); break;
                case 3: Console.WriteLine("Saliendo del sistema..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (opcion != 3);
    }

    static void RegistrarTurno()
    {
        if (contador < turnos.Length)
        {
            Paciente paciente = new Paciente();

            Console.Write("ID del paciente: ");
            paciente.Id = int.Parse(Console.ReadLine());

            Console.Write("Nombre del paciente: ");
            paciente.Nombre = Console.ReadLine();

            Console.Write("Cédula del paciente: ");
            paciente.Cedula = Console.ReadLine();

            Turno turno = new Turno();
            turno.Paciente = paciente;

            Console.Write("Fecha del turno: ");
            turno.Fecha = Console.ReadLine();

            Console.Write("Hora del turno: ");
            turno.Hora = Console.ReadLine();

            turnos[contador] = turno;
            contador++;

            Console.WriteLine("Turno registrado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pueden registrar más turnos.");
        }
    }

    static void ListarTurnos()
    {
        if (contador == 0)
        {
            Console.WriteLine("No existen turnos registrados.");
        }
        else
        {
            Console.WriteLine("\n--- LISTA DE TURNOS ---");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(
                    "Paciente: " + turnos[i].Paciente.Nombre +
                    " | Fecha: " + turnos[i].Fecha +
                    " | Hora: " + turnos[i].Hora
                );
            }
        }
    }
}
