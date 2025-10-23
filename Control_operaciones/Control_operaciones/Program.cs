using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> acciones = new Stack<string>();
            bool continuar = true;
            string opcion;

            Console.WriteLine("Bienvenido al sistema del codigo fuente. ");

            while (continuar)
            {
                
                Console.WriteLine("\n --- Menu del control de versiones --- ");
                Console.WriteLine("1. Realizar una accion");
                Console.WriteLine("2. Mostrar ultima modificacion");
                Console.WriteLine("3. Deshacer ultima accion");
                Console.WriteLine("4. Salir");

                Console.WriteLine("-----------------------");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("-----------------------");
                opcion = Console.ReadLine();
               


                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Ingrese la accion a realizar al codigo: ");
                        Console.WriteLine("-----------------------------------------");
                        string accion = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("-----------------------------");
                        AgregarAccion(acciones, accion);
                        break;

                    case "2":
                        MostrarAccion(acciones);
                        break;

                    case "3":
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("Estas seguro que quieres deshacer la ultima accion? S/N ");
                        Console.WriteLine("----------------------------------------------------------");
                        
                        string eleccion = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("------------------------------");
                        eleccion = eleccion.ToUpper();

                        DeshacerAccion(acciones, eleccion);
                        break;

                    case "4":
                        continuar = false;
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Saliendo del sistema... ");
                        Console.WriteLine("-----------------------");
                        break;

                    default:
                        Console.WriteLine("Elige una opcion valida. ");
                        break;


                }
            }

        }


        static void AgregarAccion(Stack<string> acciones, string accion)
        {
         
            acciones.Push(accion);
            Console.WriteLine($"Accion realizada - {accion}");
            Console.WriteLine("-----------------------------");

        }

        static void MostrarAccion(Stack<string> acciones)
        {

            if (acciones.Count == 0)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("No hay acciones realizadas. ");
                Console.WriteLine("------------------------------");

            }
            else
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Acciones realizadas empezando por la ultima hasta la primera: ");
                Console.WriteLine("----------------------------------------------------------------");
                foreach (var dato in acciones)
                {
                    Console.WriteLine("- " + dato);
                    Console.WriteLine("------------------------------");
                }
            }
        }

        static void DeshacerAccion(Stack<string> acciones, string eleccion)
        {
          

            if (eleccion == "S")
            {
                if (acciones.Count == 0)
                {
                    Console.WriteLine("No hay acciones que deshacer. ");
                    Console.WriteLine("------------------------------");
                }
                else
                {
                    Console.WriteLine($" Accion deshecha: {acciones.Pop()}");
                    Console.WriteLine("------------------------------");

                }
            }
            else if (eleccion == "N")
            {
                Console.WriteLine("Regresando al menu principal... ");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("Ingrese una opcion valida... ");
                Console.WriteLine("------------------------------");
            }




        }







    }
}
