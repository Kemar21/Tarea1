using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaElBuenLector
{
    class Factura
    {
        private int desc;
        private int impTotal;
        private int totalOrden;
        private int precioNeto;
        private int montoRecibido;
        private int montoCambio;

        public Factura()
        {
            this.desc = 0;
            this.impTotal = 0;
            this.totalOrden = 0;
            this.precioNeto = 0;
            this.montoRecibido = 0;
            this.montoCambio = 0;

        }

        public Factura(int desc, int impTotal, int totalOrden, int precioNeto, int montonRecibido, int montoCambio, int montoRecibido)
        {

            this.desc = desc;
            this.impTotal = impTotal;
            this.totalOrden = totalOrden;
            this.precioNeto = precioNeto;
            this.montoCambio = montoCambio;
            this.montoRecibido = montoRecibido;

        }

        public void setDesc(int desc)
        {
            this.desc = desc;
        }

        public int getDesc()
        {
            return desc;
        }

        public void setImpTotal(int impTotal)
        {
            this.impTotal = impTotal;
        }

        public int getImpTotal()
        {
            return impTotal;
        }

        public void setPrecioNeto(int precioNeto)
        {
            this.precioNeto = precioNeto;
        }

        public int getPrecioNeto()
        {
            return precioNeto;
        }

        public void setMontoCambio(int montoCambio)
        {

            this.montoCambio = montoCambio;
        }

        public int getMontoCambio()
        {
            return montoCambio;
        }

        public void setMontoRecibido(int montoRecibido)
        {
            this.montoRecibido = montoRecibido;
        }

        public int getMontoRecibido()
        {
            return montoRecibido;
        }

        public void setTotalOrden(int totalOrden)
        {
            this.totalOrden = totalOrden;

        }

        public int getTotalOrden()
        {
            return totalOrden;
        }

    }
}

