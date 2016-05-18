using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaElBuenLector
{
    class Libro
    {
        private String tipo;
        private String libro;
        private int precio;
        private int cantidad;
        private int numero;
     

        public Libro()
        {
            this.tipo = "";
            this.libro = "";
            this.precio = 0;
            this.cantidad = 0;
            this.numero = 0;

        }

        public Libro(String tipo, String libro, int precio, int cantidad, int numero)
        {
            this.tipo = tipo;
            this.libro = libro;
            this.precio = precio;
            this.cantidad = cantidad;
            this.numero = numero;
        }

        public  void setTipo(String tipo)
        {
            this.tipo = tipo;
        }
        public String getTipo()
        {
            return tipo;
        }

        public void setLibro(String libro)
        {
            this.libro = libro;
        }

        public String getLibro()
        {
            return libro;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        public int getPrecio()
        {
            return precio;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        

    }
}

    

