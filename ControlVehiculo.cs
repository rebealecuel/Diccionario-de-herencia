using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_de_herencia
{
    internal class ControlVehiculo
    {
        Dictionary<int, VehiculoCoche> diccionariocoche = new Dictionary<int, VehiculoCoche>();
        Dictionary<int, VehiculoCamion> diccionariocamion = new Dictionary<int, VehiculoCamion>();
        VehiculoCoche vco = new VehiculoCoche();
        VehiculoCamion vca = new VehiculoCamion();

        public void AddCochee()
        {
            Console.WriteLine("Dame matricula");
            int id = Convert.ToInt32(Console.ReadLine());
            vco.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de la marca");
            vco.Marca = Console.ReadLine();
            Console.WriteLine("Nombre del modelo");
            vco.Modelo = Console.ReadLine();
            Console.WriteLine("Año de lanzamiento");
            int añio = Convert.ToInt32(Console.ReadLine());
            vco.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de puertas");
            int noPuertas = Convert.ToInt32(Console.ReadLine());
            vco.Puertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Tiene ventana superior?");
            vco.VentanaTecho = Console.ReadLine();

            diccionariocoche.Add(id,new VehiculoCoche(vco.ID, vco.Marca, vco.Modelo,vco.Año,vco.Puertas,vco.VentanaTecho));
        }
    }
}
