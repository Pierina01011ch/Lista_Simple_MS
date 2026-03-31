using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA_ENLAZADA_SIMPLE
{
    public partial class Form1 : Form
    {
        Lista l = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            l.Insertar(int.Parse(textNumero.Text));
            l.Mostrar(listBox1);
            textNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            l.Eliminar(int.Parse(textNumero.Text));
            listBox1.Items.Clear();
            l.Mostrar(listBox1);
            textNumero.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (l.Buscar(int.Parse(textNumero.Text)) == true)
                MessageBox.Show("El número existe en la lista");
            else MessageBox.Show("El número no existe en la lista");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            l.Ordenar();
            listBox1.Items.Clear();
            l.Mostrar(listBox1);
        }
    }
}
