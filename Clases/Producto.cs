using System;
using System.Collections.Generic;
using System.Text;

namespace Seller_2._0.Clases
{
    public class Producto
    {

        String Nombre;
        String Categoria;
        double Precio;

        public Producto(string nombre, string categoria, double precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }

        public Producto() {}

        public string nombre()
        {
            return Nombre;
        }

        public string categoria()
        {
            return Categoria;
        }


        public double precio()
        {
            return Precio;
        }

        
        public void mod_precio(double nuevo_precio)
        {
            Precio = nuevo_precio;
        }
        public void mod_porcentual(int porcentual)
        {
            double porcentaje = (100 * porcentual) / Precio;
            Precio += porcentaje; 
        }


    }
}
