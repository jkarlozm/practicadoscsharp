using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac2venta
{
    public class venta
    {
        //  Atributos de la venta.
        public int Mes { set; get; }
        public int Año { set; get; }
        public float Ventav { set; get; }
        public string Supervisor { set; get; }

        //  Agragamos referencia System.Drawing para poder trabajar con imagenes.
        private System.Drawing.Image fotosupervisor;

        //  Constructor vacio.
        public venta()
        { 
        }

        //  Constructor de inicialización.
        public venta(int _m, int _a, float _v, string _s)
        {
            Mes = _m;
            Año = _a;
            Ventav = _v;
            Supervisor = _s;            
        }        
        
        //  Método para mostrar datos de la venta.
        public string MuestraDatos()
        {
            string vent = "";
            vent = "\n" + "\nDatos venta:" + "\n" + "\nMes: " + Mes +
                "\nAño: " + Año + "\nVenta: " + Ventav + "\nSupervisor: " + Supervisor;
            return vent;
        }

        //  Método el cuál almacena (guardar) una imagen (Foto del Supervisor).
        public void Obtenerfoto(string rfoto)
        {
            fotosupervisor = System.Drawing.Image.FromFile(rfoto);
        }

        //  Método con el cuál mostramos la imagen almacenada.
        public System.Drawing.Image MuestraFotoS()
        {
            return fotosupervisor;
        }
    }
}
