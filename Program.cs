using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examen1PracDAE_Clave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;
            int opciones1;

            while (bandera)
            {
                Console.WriteLine("------------MENU PRINCIPAL-----------");
                Console.WriteLine("1. LLAMADAS");
                Console.WriteLine("2. BIBLIOTECA");
                Console.WriteLine("3. Salir del sistema");
                Console.WriteLine("------------------------------------");

                Console.Write("Seleccione una opción: ");
                opciones1 = int.Parse(Console.ReadLine());

                switch (opciones1)
                {
                    case 1:
                        Main1();
                        break;
                    case 2:
                        Main2();
                        break;
                    case 3:
                        Console.WriteLine("Salir del sistema");
                        bandera = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no encontrada");
                        break;
                }
                Console.ReadKey();

            }
        }
        //APLICACION 1
        static void Main1()
        {
            //inicializacion de variables
            double CostoLlamada, MinLlamada;
            int ClaveZona;
            Console.WriteLine("-----------Calcular el costo de la llamada------------");
            Console.WriteLine("Ingrese clave segun zona:");
            ClaveZona = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos de la llamada:");
            MinLlamada = double.Parse(Console.ReadLine());

            switch (ClaveZona)
            {
                case 12:
                    CostoLlamada = 2 * MinLlamada;
                    Console.WriteLine($"El costo de su llamada segun zona (America del Norte) es ${CostoLlamada}");
                    break;
                case 15:
                    CostoLlamada = 2.2 * MinLlamada;
                    Console.WriteLine($"El costo de su llamada segun zona (America Central) es ${CostoLlamada}");
                    break;
                case 18:

                    CostoLlamada = 4.5 * MinLlamada;
                    Console.WriteLine($"El costo de su llamada segun zona (America del Sur) es ${CostoLlamada}");
                    break;

                case 19:
                    CostoLlamada = 3.5 * MinLlamada;
                    Console.WriteLine($"El costo de su llamada segun zona (Europa) es ${CostoLlamada}");
                    break;
                case 23:

                    CostoLlamada = 6 * MinLlamada;
                    Console.WriteLine($"El costo de su llamada segun zona (Asia) es ${CostoLlamada}");
                    break;

                default:

                    Console.WriteLine("Clave fuera de rango ");
                    break;
            }
        }
        //APLICACION 2
        class Libro
        {
            public int Codigo { get; set; }
            public string Titulo { get; set; }
            public string ISBN { get; set; }
            public string Edicion { get; set; }
            public string Autor { get; set; }
        }
        static void Main2()
        {
            Libro[] sistema = new Libro[5];

            int Libros = 0; // Contador para llevar el registro de los libros agregados
            bool bandera2 = true;

            while (bandera2)
            {
                Console.WriteLine("------------BIBLIOTECA-----------");
                Console.WriteLine("--------Gestion de libros---------");
                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Mostrar los libros agregados");
                Console.WriteLine("3. Buscar un libro por código");
                Console.WriteLine("4. Editar un libro por código");
                Console.WriteLine("5. Salir del sistema");
                Console.WriteLine("------------------------------------");

                Console.Write("Seleccione una opción: ");
                int opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        // Agregar un libro
                        if (Libros < sistema.Length)
                        {
                            Libro IngresoLibro = new Libro();
                            Console.WriteLine("----AGREGAR LIBRO--------");
                            Console.Write("Código del libro: ");
                            IngresoLibro.Codigo = int.Parse(Console.ReadLine());
                            Console.Write("Título: ");
                            IngresoLibro.Titulo = Console.ReadLine();
                            Console.Write("ISBN: ");
                            IngresoLibro.ISBN = Console.ReadLine();
                            Console.Write("Edición: ");
                            IngresoLibro.Edicion = Console.ReadLine();
                            Console.Write("Autor: ");
                            IngresoLibro.Autor = Console.ReadLine();

                            sistema[Libros] = IngresoLibro;
                            Libros++;

                            Console.WriteLine("El Libro se ha agregado.");
                        }
                        else
                        {
                            Console.WriteLine("No se pueden agregar más libros.");
                        }
                        break;

                    case 2:
                        // Mostrar los libros que existen
                        Console.WriteLine("--------------------------LIBROS EXISTENTES------------------------------");
                        Console.WriteLine("|Código      | Título            | ISBN          | Edición    | Autor         |");
                        for (int i = 0; i < Libros; i++)
                        {
                            Console.WriteLine($"|{sistema[i].Codigo}       | {sistema[i].Titulo}       | {sistema[i].ISBN}    | {sistema[i].Edicion}        | {sistema[i].Autor}|");
                            Console.WriteLine("----------------------------------------------------------------------------");
                        }
                        break;

                    case 3:
                        // Buscar libro por código
                        Console.Write("Ingresar el código del libro a buscar: ");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------LIBRO ENCONTRADO--------------------------------");
                        Console.WriteLine("|Código      | Título            | ISBN           | Edición      | Autor          |");
                        for (int i = 0; i < Libros; i++)
                        {
                            if (sistema[i].Codigo == codigo)
                            {
                                Console.WriteLine($"|{sistema[i].Codigo}       | {sistema[i].Titulo}       | {sistema[i].ISBN}     | {sistema[i].Edicion}       | {sistema[i].Autor}|");
                                Console.WriteLine("-------------------------------------------------------------------------------");
                            }
                        }
                        break;

                    case 4:
                        // Editar libro por código
                        Console.Write("Ingresar el código del libro a editar: ");
                        int Editar = int.Parse(Console.ReadLine());
                        for (int i = 0; i < Libros; i++)
                        {
                            if (sistema[i].Codigo == Editar)
                            {
                                Console.WriteLine("---------EDITANDO LIBRO------------");
                                Console.Write("Nuevo título: ");
                                sistema[i].Titulo = Console.ReadLine();
                                Console.Write("Nuevo ISBN: ");
                                sistema[i].ISBN = Console.ReadLine();
                                Console.Write("Nueva edición: ");
                                sistema[i].Edicion = Console.ReadLine();
                                Console.Write("Nuevo autor: ");
                                sistema[i].Autor = Console.ReadLine();
                                Console.WriteLine("Libro editado con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("El codigo ingresado no esta establecido a un libro existente.");
                            }
                        }

                        break;

                    case 5:
                        // Salir del programa
                        Console.WriteLine("Salir del programa.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        bandera2 = false;
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

