using Colac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nuevito
{
    public partial class Form1 : Form
    {
        public Cola c = new Cola();//inicializa al objeto

        public object ListBox1 { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);//recoge datos
            if (c.Llena())
                MessageBox.Show("Error: la cola de elemenots esta LLENA");
            else
            {
                c.Insertar(Convert.ToString(x));
                listBox1.Items.Add(x*x);  //para mostrar en el listbox
                label3.Text = Convert.ToString(c.primero);
                label4.Text = Convert.ToString(c.ultimo);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (c.Vacia())
            {

            }
                
            else
            {

                string s = c.Eliminar();
                if(c.ultimo == 0)
                {
                    listBox1.Items.RemoveAt(0);
                    label4.Text = Convert.ToString(c.ultimo);
                    MessageBox.Show("Error: la cola de elementos esta VACIA");
                        
                }
                    else
                    {
                        listBox1.Items.RemoveAt(c.ultimo); // eliminamos el primer elemento del listbox
                                                           //c.ultimo--;
                        label3.Text = Convert.ToString(c.primero);
                        label4.Text = Convert.ToString(c.ultimo);
                    }
               
            }
           // Mostrar();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text= Convert.ToString(c.ultimo);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(c.primero);
        }
        public void Mostrar()
        {
            listBox1.Items.Clear();
           
            if (c.Vacia())
            {
                MessageBox.Show("Error: la cola de elementos esta VACIA");
            }
            else
            {
                for (int i = 0; i < c.MaxCola; i++)
                {

                   
                    listBox1.Items.Add(Convert.ToString(c.coladatos[i]));
                }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
