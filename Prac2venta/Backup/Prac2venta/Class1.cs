using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac2venta
{
    public class venta
    {
        //Variables publicas
        public int Mes { set; get; }
        public int Año { set; get; }
        public float Ventav { set; get; }
        public string Supervisor { set; get; }

        //agragar referencia System.Drawing para imagen
        private System.Drawing.Image fotosupervisor;

        //constructor vacio
        public venta()
        { 
        }

        //constructor de inicializacion
        public venta(int _m, int _a, float _v, string _s)
        {
            Mes = _m;
            Año = _a;
            Ventav = _v;
            Supervisor = _s;            
        }        
        
        public string MuestraDatos()
        {
            string vent = "";
            vent = "\n" + "\nDatos venta:" + "\n" + "\nMes: " + Mes +
                "\nAño: " + Año + "\nVenta: " + Ventav + "\nSupervisor: " + Supervisor;
            return vent;
        }

        public void Obtenerfoto(string rfoto)
        {
            fotosupervisor = System.Drawing.Image.FromFile(rfoto);
        }

        public System.Drawing.Image MuestraFotoS()
        {
            return fotosupervisor;
        }
    }
}
