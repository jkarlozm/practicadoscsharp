using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Prac2Vendedor.vendedor prac2;

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar datos
            prac2 = new Prac2Vendedor.vendedor(System.Convert.ToInt32(Reg.Text), 
                Nom.Text, System.Convert.ToInt32(Age.Text), Mail.Text, RutFotv.Text);
            prac2.obtenerv1(System.Convert.ToInt32(m.Text), System.Convert.ToInt32(a.Text),
                System.Convert.ToSingle(V.Text), s.Text, RutFotS1.Text);
            prac2.obtenerv2(System.Convert.ToInt32(m2.Text), System.Convert.ToInt32(a2.Text),
                System.Convert.ToSingle(v2.Text), s2.Text, RutFotS2.Text);
            prac2.obtenerv3(System.Convert.ToInt32(m3.Text), System.Convert.ToInt32(a3.Text),
                System.Convert.ToSingle(v3.Text), s3.Text, RutFotS3.Text);
            prac2.obtenerv4(System.Convert.ToInt32(m4.Text), System.Convert.ToInt32(a4.Text),
                System.Convert.ToSingle(v4.Text), s4.Text, RutFotS4.Text);
            prac2.obtenerv5(System.Convert.ToInt32(m5.Text), System.Convert.ToInt32(a5.Text),
                System.Convert.ToSingle(v5.Text), s5.Text, RutFotS5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mostrar datos
            MessageBox.Show(prac2.MuestraDatos());                   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mostrar imagen
            Fotov.Image = prac2.MuestraFotoV();

            //mostrar imagen supervisor            
            FotoS1.Image = prac2.Fs1();
            FotoS2.Image = prac2.Fs2();
            FotoS3.Image = prac2.Fs3();
            FotoS4.Image = prac2.Fs4();
            FotoS5.Image = prac2.Fs5();
        }
        
    }
}
