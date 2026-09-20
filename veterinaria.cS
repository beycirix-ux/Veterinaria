using System;
using System.Collections.Generic;

class Mascota
{
    public int Id;
    public string Nombre;
    public string Especie;
    public string Raza;
    public int Edad;
    public string Propietario;
}

class Veterinario
{
    public int Id;
    public string Nombre;
    public string Especialidad;
}

class Cita
{
    public int Id;
    public string Mascota;
    public string Veterinario;
    public string Fecha;
    public string Motivo;
}

class Program
{
    static List<Mascota> mascotas = new List<Mascota>();
    static List<Veterinario> veterinarios = new List<Veterinario>();
    static List<Cita> citas = new List<Cita>();

    static int idMascota = 1;
    static int idVeterinario = 1;
    static int idCita = 1;

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("   SISTEMA DE VETERINARIA");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Mostrar mascotas");
            Console.WriteLine("3. Registrar veterinario");
            Console.WriteLine("4. Mostrar veterinarios");
            Console.WriteLine("5. Registrar cita");
            Console.WriteLine("6. Mostrar citas");
            Console.WriteLine("7. Registrar consulta");
            Console.WriteLine("0. Salir");
            Console.WriteLine("==================================");

            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarMascota();
                    break;

                case 2:
                    MostrarMascotas();
                    break;

                case 3:
                    RegistrarVeterinario();
                    break;

                case 4:
                    MostrarVeterinarios();
                    break;

                case 5:
                    RegistrarCita();
                    break;

                case 6:
                    MostrarCitas();
                    break;

                case 7:
                    RegistrarConsulta();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }

        } while (opcion != 0);
    }

    // ==========================
    // MASCOTAS
    // ==========================

    static void RegistrarMascota()
    {
        Console.Clear();

        Mascota mascota = new Mascota();

        mascota.Id = idMascota++;

        Console.Write("Nombre de la mascota: ");
        mascota.Nombre = Console.ReadLine();

        Console.Write("Especie: ");
        mascota.Especie = Console.ReadLine();

        Console.Write("Raza: ");
        mascota.Raza = Console.ReadLine();

        Console.Write("Edad: ");
        mascota.Edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nombre del propietario: ");
        mascota.Propietario = Console.ReadLine();

        mascotas.Add(mascota);

        Console.WriteLine("\nMascota registrada correctamente.");
    }

    static void MostrarMascotas()
    {
        Console.Clear();

        Console.WriteLine("===== PACIENTES =====");

        if (mascotas.Count == 0)
        {
            Console.WriteLine("No hay mascotas registradas.");
            return;
        }

        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ID: " + mascota.Id);
            Console.WriteLine("Nombre: " + mascota.Nombre);
            Console.WriteLine("Especie: " + mascota.Especie);
            Console.WriteLine("Raza: " + mascota.Raza);
            Console.WriteLine("Edad: " + mascota.Edad);
            Console.WriteLine("Propietario: " + mascota.Propietario);
        }
    }

    // ==========================
    // VETERINARIOS
    // ==========================

    static void RegistrarVeterinario()
    {
        Console.Clear();

        Veterinario veterinario = new Veterinario();

        veterinario.Id = idVeterinario++;

        Console.Write("Nombre del veterinario: ");
        veterinario.Nombre = Console.ReadLine();

        Console.Write("Especialidad: ");
        veterinario.Especialidad = Console.ReadLine();

        veterinarios.Add(veterinario);

        Console.WriteLine("\nVeterinario registrado correctamente.");
    }

    static void MostrarVeterinarios()
    {
        Console.Clear();

        Console.WriteLine("===== VETERINARIOS =====");

        foreach (Veterinario veterinario in veterinarios)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ID: " + veterinario.Id);
            Console.WriteLine("Nombre: " + veterinario.Nombre);
            Console.WriteLine("Especialidad: " + veterinario.Especialidad);
        }
    }

    // ==========================
    // CITAS
    // ==========================

    static void RegistrarCita()
    {
        Console.Clear();

        Cita cita = new Cita();

        cita.Id = idCita++;

        Console.Write("Nombre de la mascota: ");
        cita.Mascota = Console.ReadLine();

        Console.Write("Nombre del veterinario: ");
        cita.Veterinario = Console.ReadLine();

        Console.Write("Fecha de la cita: ");
        cita.Fecha = Console.ReadLine();

        Console.Write("Motivo de la cita: ");
        cita.Motivo = Console.ReadLine();

        citas.Add(cita);

        Console.WriteLine("\nCita registrada correctamente.");
    }

    static void MostrarCitas()
    {
        Console.Clear();

        Console.WriteLine("===== CITAS =====");

        foreach (Cita cita in citas)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ID: " + cita.Id);
            Console.WriteLine("Mascota: " + cita.Mascota);
            Console.WriteLine("Veterinario: " + cita.Veterinario);
            Console.WriteLine("Fecha: " + cita.Fecha);
            Console.WriteLine("Motivo: " + cita.Motivo);
        }
    }

    // ==========================
    // CONSULTA
    // ==========================

    static void RegistrarConsulta()
    {
        Console.Clear();

        Console.WriteLine("===== CONSULTA VETERINARIA =====");

        Console.Write("Nombre de la mascota: ");
        string mascota = Console.ReadLine();

        Console.Write("Síntomas: ");
        string sintomas = Console.ReadLine();

        Console.Write("Diagnóstico: ");
        string diagnostico = Console.ReadLine();

        Console.Write("Tratamiento: ");
        string tratamiento = Console.ReadLine();

        Console.WriteLine("\n===== CONSULTA REGISTRADA =====");
        Console.WriteLine("Mascota: " + mascota);
        Console.WriteLine("Síntomas: " + sintomas);
        Console.WriteLine("Diagnóstico: " + diagnostico);
        Console.WriteLine("Tratamiento: " + tratamiento);
    }
}