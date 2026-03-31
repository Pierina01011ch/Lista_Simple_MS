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
    }
}
