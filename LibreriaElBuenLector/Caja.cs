using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaElBuenLector
{
    class Caja
    {


        public int calcularTotalPago(int cantidad, int precio)
        {

            return precio * cantidad;
        }

        public int calcularDesc(int precio, String tipo)
        {
            int resultado = 0;
            if (tipo == "Fantasia")
            {
                resultado = (int)(precio * 0.15);

            } else
            {
                if (tipo == "Miesterio")
                {
                    resultado = (int)( precio * 0.10);
                }else
                {
                    if(tipo == "Infantil")
                    {
                        resultado = (int)(precio * 0.05);
                    }else
                    {
                        if(tipo == "Educativo")
                        {
                            resultado = (int)(precio * 0.20);
                        }else
                        {
                            if (tipo == "Superacion")
                            {
                                resultado = (int)(precio * 0.25);
                            }else
                            {
                                if(tipo == "Ciencia Ficion")
                                {
                                    resultado = (int)(precio * 0.25);
                                }
                            }
                        }
                    }
                }
            }

            return resultado;
        }

   

        public int calcularImpTotal(int precio)
        {
            return (int)(precio * 0.13);
        }

        public int calcularPrecioNeto(int precioTotal, int imp, int desc)
        {
            return precioTotal + imp - desc;
        }
    }
}
