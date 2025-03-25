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
            Console.WriteLine("Dame ID");
            vco.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de la marca");
            vco.Marca = Console.ReadLine();
            Console.WriteLine("Nombre del modelo");
            vco.Modelo = Console.ReadLine();
            Console.WriteLine("Año de lanzamiento");
            vco.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de puertas");
            vco.Puertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Tiene ventana superior?");
            vco.VentanaTecho = Console.ReadLine();

            diccionariocoche.Add(id, new VehiculoCoche(vco.ID, vco.Marca, vco.Modelo, vco.Año, vco.Puertas, vco.VentanaTecho));
        }
        public void AddCamion()
        {
            Console.WriteLine("Dame matricula");
            int idd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame ID");
            vca.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de la marca");
            vca.Marca = Console.ReadLine();
            Console.WriteLine("Nombre del modelo");
            vca.Modelo = Console.ReadLine();
            Console.WriteLine("Año de lanzamiento");
            vca.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuanta carga soporta");
            vca.CapacidadCarga = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Add(idd, new VehiculoCamion(vca.ID, vca.Marca, vca.Modelo, vca.Año, vca.CapacidadCarga));
        }

        public void MostraCoche()
        {
            foreach (var co in diccionariocoche)
            {
                Console.WriteLine($"ID: {co.Value.ID}");
            }
        }
        
        public void EliminarCoche()
        {
            Console.WriteLine("Dame ID a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Remove(id);
        }

        public void ActualizarCoche()
        {
            Console.WriteLine("Dame ID a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());

            var coche = diccionariocoche.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo ID");
            coche.Value.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca");
            coche.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo");
            coche.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame año");
            coche.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame numero de puertas");
            coche.Value.Puertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Ventana superior?");
            coche.Value.VentanaTecho = Console.ReadLine();
        }
        public void ActualizarCamion()
        {
            Console.WriteLine("Dame ID a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());

            var camion = diccionariocamion.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo ID");
            camion.Value.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca");
            camion.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo");
            camion.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame año");
            camion.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuanta carga soporta");
            camion.Value.CapacidadCarga = Convert.ToDouble(Console.ReadLine());
        }
    }
}
