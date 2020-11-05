using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseCola
{
    public partial class Form1 : Form
    {
        Queue<string> miCola = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            if(txtDato.Text == "")
            {
                return;
            }
            miCola.Enqueue(txtDato.Text);
            string cola = "";
            foreach (string s in miCola)
            {
                cola += s + " ";
            }
            lblCola.Text = cola;
            txtDato.Clear();

        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (miCola.Count > 0)
            {
                string datoeliminado = miCola.Dequeue();
                MessageBox.Show("Dato desencolado : " + datoeliminado);
                string cola = "";
                foreach (string s in miCola)
                {
                    cola += s + " ";
                }
                lblCola.Text = cola;
                txtDato.Clear();
                return;
            }
            MessageBox.Show("La cola esta vacia");
          
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (miCola.Count > 0)
            {
                string datoeliminado = miCola.Peek();
                MessageBox.Show("Dato en el frente : " + datoeliminado);
                return;
            }
            MessageBox.Show("La cola esta vacia");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            miCola.Clear();
            lblCola.Text = "";
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                string dato = txtDato.Text;
                bool encontrado = miCola.Contains(dato);
                if(encontrado == true)
                {
                    MessageBox.Show("El dato " + dato + " fue encontrado");
                }
                else
                {
                    MessageBox.Show("El dato " + dato + " no fue encontrado");
                }
                return;
            }

            
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de elementos en la cola : " + miCola.Count);
        }
    }
}
