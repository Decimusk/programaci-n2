﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListas
{
    class Producto
    {
        string nombre;
        string descripcion;
        string marca;
        float precio;
        int stock;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
