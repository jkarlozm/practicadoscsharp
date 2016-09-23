using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac2Vendedor
{
    public class vendedor
    {
        //  Atributos del vendedor.
        public int registro { set; get; }
        public string nombre { set; get; }
        public int edad { set; get; }
        public string correo { set; get; }

        //  Agragamos referencia "System.Drawing.Image" para trabajar con imagenes.
        private System.Drawing.Image fotovendedor;

        //  Invocación de la clase venta.
        private Prac2venta.venta v1 = new Prac2venta.venta();
        private Prac2venta.venta v2 = new Prac2venta.venta();
        private Prac2venta.venta v3 = new Prac2venta.venta();
        private Prac2venta.venta v4 = new Prac2venta.venta();
        private Prac2venta.venta v5 = new Prac2venta.venta();

       //   Métodos de la clase venta que almacenan los datos de los supervisores del vendedor.
        public void obtenerv1(int _m, int _a, float _v, string _s, string _f)
        {
            v1.Mes = _m;
            v1.Año = _a;
            v1.Ventav = _v;
            v1.Supervisor = _s;
            v1.Obtenerfoto(_f);
        }

        public System.Drawing.Image Fs1()
        {
            return v1.MuestraFotoS();
        }

        public void obtenerv2(int _m, int _a, float _v, string _s, string _f)
        {
            v2.Mes = _m;
            v2.Año = _a;
            v2.Ventav = _v;
            v2.Supervisor = _s;
            v2.Obtenerfoto(_f);
        }

        public System.Drawing.Image Fs2()
        {
            return v2.MuestraFotoS();
        }

        public void obtenerv3(int _m, int _a, float _v, string _s, string _f)
        {
            v3.Mes = _m;
            v3.Año = _a;
            v3.Ventav = _v;
            v3.Supervisor = _s;
            v3.Obtenerfoto(_f);
        }

        public System.Drawing.Image Fs3()
        {
            return v3.MuestraFotoS();
        }

        public void obtenerv4(int _m, int _a, float _v, string _s, string _f)
        {
            v4.Mes = _m;
            v4.Año = _a;
            v4.Ventav = _v;
            v4.Supervisor = _s;
            v4.Obtenerfoto(_f);
        }

        public System.Drawing.Image Fs4()
        {
            return v4.MuestraFotoS();
        }

        public void obtenerv5(int _m, int _a, float _v, string _s, string _f)
        {
            v5.Mes = _m;
            v5.Año = _a;
            v5.Ventav = _v;
            v5.Supervisor = _s;
            v5.Obtenerfoto(_f);
        }

        public System.Drawing.Image Fs5()
        {
            return v5.MuestraFotoS();
        }

        // Método constructor vacio.
        public vendedor()
        { 
        }

        // Método constructor de inicialización.
        public vendedor(int _reg, string _nom, int _ed, string _corr, string _rutaf)
        {
            registro = _reg;
            nombre = _nom;
            edad = _ed;
            correo = _corr;
            fotovendedor = System.Drawing.Image.FromFile(_rutaf);
        }

        //  Método que muetra los datos del vendedor como los de la venta.
        public string MuestraDatos()
        {
            float total = v1.Ventav + v2.Ventav + v3.Ventav + v4.Ventav + v5.Ventav;            
            string vend = "";
            vend = "Datos Vendedor: " + "\n" + "\nRegistro: " + registro +
                "\nNombre: " + nombre + "\nEdad: " + edad + "\nCorreo: " + correo;
            vend = vend + v1.MuestraDatos() + "\n" + v2.MuestraDatos() + "\n" + v3.MuestraDatos() +
                "\n" + v4.MuestraDatos() + "\n" + v5.MuestraDatos() + "\nTotal: " + total;
            return vend;
        }

        //  Método que muestra la imagen.
        public System.Drawing.Image MuestraFotoV()
        {
            return fotovendedor;
        }        
    }
}
