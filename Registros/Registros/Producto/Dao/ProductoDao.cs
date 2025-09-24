using Producto.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto.Dao
{
    public class ProductoDao

    {
        private static int TAM = 5;
        public const int TAMAÑO = 10;
        private Productos[] carrito = new Productos[10];
        private int pos = 0;
        public void Agregar(Productos prod)
        {
          try 
            {
                carrito[pos++] = prod;
            }
           catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No se pueden agregar mas elemento", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public Productos[] verCarrito()
        {
            return carrito;
        }

    }
}
