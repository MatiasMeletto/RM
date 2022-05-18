using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.cerraduras
{
    internal class Cerradura
    {
        public string _codigo;
        public string Codigo { get => _codigo; set => _codigo = value.ToUpper(); }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public Cerradura(string codigo, int cantidad, string descripcion)
        {
            Codigo = codigo;
            Cantidad = cantidad;
            Descripcion = descripcion;
        }
    }
}
