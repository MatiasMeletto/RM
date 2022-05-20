﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.escuadras
{
    internal class Escuadra
    {
        public string _codigo;
        public string Codigo { get => _codigo; set => _codigo = value.ToUpper(); }
        public int CantidadSuelta { get; set; }
        public int CantidadBolsas { get; set; }
        public string Descripcion { get; set; }

        public Escuadra(string codigo, int cantidadSuelta, int cantidadBolsas, string descripcion)
        {
            Codigo = codigo;
            CantidadSuelta = cantidadSuelta;
            CantidadBolsas = cantidadBolsas;
            Descripcion = descripcion;
        }
    }
}