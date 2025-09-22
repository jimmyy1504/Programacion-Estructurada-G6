using ModuloLibrery.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLibrary.DAO
{
    public class CarreraDAO
    {
        public Carrera[] Listado = new Carrera[5];
        public int posicion = 0;
        public void Agregar(Carrera carrera)
        {
            Listado[posicion] = carrera;
            posicion++;
        }
    }
}