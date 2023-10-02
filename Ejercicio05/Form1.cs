using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSemana02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaSimple lista1 = new ListaSimple();
        ListaSimple lista2 = new ListaSimple();
        ListaSimple lista3 = new ListaSimple();

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            lista1.insertaAlFinal(valor);
            lista1.mostrar(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            lista2.insertaAlFinal(valor);
            lista2.mostrar(listBox2);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            lista1.insertaListaDespues(lista2);
            lista1.insertaListaDespues(lista3);
            lista1.mostrar(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            
            ListaSimple interseccion = lista1.Interseccion(lista2);

           
            interseccion.mostrar(listBox4);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
