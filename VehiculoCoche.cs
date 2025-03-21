using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_de_herencia
{
    internal class VehiculoCoche : BaseVehiculo
    {
        public VehiculoCoche() { }

        public VehiculoCoche(int iD, string marca, string modelo, int año, int puertas, string ventanaTecho)
        :base(iD,marca,modelo,año)
        {
            Puertas = puertas;
            VentanaTecho = ventanaTecho;
        }

        public int Puertas {  get; set; }
        public string VentanaTecho {  get; set; }
    }
}
