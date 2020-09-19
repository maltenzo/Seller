using System;
using System.Collections.Generic;
using System.Text;

namespace Seller_2._0.Clases
{
    public class Producto
    {

        String Nombre;
        float Precio;

        public Producto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Producto() {}

        public string nombre()
        {
            return Nombre;
        }

        public float precio()
        {
            return Precio;
        }

        public void mod_precio(float nuevo_precio)
        {
            Precio = nuevo_precio;
        }
        public void mod_porcentual(int porcentual)
        {
            float porcentaje = (100 * porcentual) / Precio;
            Precio += porcentaje; 
        }


    }
}
