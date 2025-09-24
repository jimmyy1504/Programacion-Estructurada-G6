using Producto.Modelos;
using Producto.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto
{
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();

        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.verCarrito();
            this.dgvRegistros.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Nombre = tbNombre.Text.ToUpper();
            prod.Codigo = tbCodigo.Text.ToUpper();
            prod.Precio = double.Parse(tbPrecio.Text);
            prod.IVA = chkIVA.Checked;
            dao.Agregar(prod);

        }
    }
}
