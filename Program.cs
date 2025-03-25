using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_de_herencia
{
    internal class Program
    {
        public enum Menu
        {
            Agregar = 1, Mostrar, Contar, Actualizar, Elimninar, Salir
        }
        static void Main(string[] args)
        {
            //Rebeca Alejandra Cuellar Angel
            ControlVehiculo bas = new ControlVehiculo();
            while (true)
            {
                switch (Menun())
                {
                    case Menu.Agregar:
                        bas.AddCochee();
                        break;
                    case Menu.Mostrar:
                        bas.MostraCoche();
                        break;
                    case Menu.Actualizar:
                        bas.ActualizarCoche();
                        break;
                    case Menu.Elimninar: 
                        bas.EliminarCoche();
                        break;
                    case Menu.Salir:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        static Menu Menun()
        {
            Console.WriteLine("1) Agregar");
            Console.WriteLine("2) Mostrar");
            Console.WriteLine("3) Contar");
            Console.WriteLine("4) Actualizar");
            Console.WriteLine("5) Eliminar");
            Console.WriteLine("6) Salir");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
