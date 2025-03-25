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
            AgregarCO = 1, AgregarCa, Mostrar, Actualizar, Elimninar, Salir
        }
        static void Main(string[] args)
        {
            //Rebeca Alejandra Cuellar Angel
            ControlVehiculo bas = new ControlVehiculo();
            while (true)
            {
                switch (Menun())
                {
                    case Menu.AgregarCO:
                        bas.AddCochee();
                        break;
                    case Menu.AgregarCa:
                        bas.AddCamion();
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
            Console.WriteLine("1) Agregar Coche");
            Console.WriteLine("2) Agregar Camion");
            Console.WriteLine("3) Mostrar");
            Console.WriteLine("4) Actualizar");
            Console.WriteLine("5) Eliminar");
            Console.WriteLine("6) Salir");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
