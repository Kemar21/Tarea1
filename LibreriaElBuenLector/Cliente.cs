using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaElBuenLector
{
    class Cliente
    {
        private String nombre;
        private int numero;

        public Cliente()
        {
            this.nombre = " " ;
            this.numero = 0;
        }
        public Cliente(String nombre, int numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return numero;
        }


    }
}
