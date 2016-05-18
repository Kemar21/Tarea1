using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaElBuenLector
{
    class Menu
    {

        private Cliente cliente;
        private int numeroLibro;
        private int cantidadLibro;
        private Caja caja;
        private List<Libro> libros;
        private Factura fac; 
        public Menu()
        {
            this.cliente = new Cliente();
            this.caja = new Caja();
            this.fac = new Factura();
        }

        public void iniciar()
        {
            libros = new List<Libro>();
            Libro lib1 =  new Libro("Fantasia", "El sennor de los anillos", 3874, 0, 1 );
            Libro lib2 = new Libro("Fantasia", "El Mago de Oz", 2650, 0,2);
            Libro lib3 = new Libro("Misterio", "La Zona Muerte", 4500,0, 3);
            Libro lib4 = new Libro("Misterio", "Cementerio", 3484,0, 4);
            Libro lib5 = new Libro("Infantil", "Alicia en el Pais de las Maravillas", 8200, 0, 5);
            Libro lib6 = new Libro("Infantil", "Las Aventuras de Tom Sawyer", 7600,0, 6);
            Libro lib7 = new Libro("Educativo", "Quiero apender", 3000,0, 7);
            Libro lib8 = new Libro("Educativo", "Mi Primer Libro de Matematicas", 9530,0, 8);
            Libro lib9 = new Libro("Superacion", "El Poder del Pensamiento", 7500,0, 9);
            Libro lib10 = new Libro("Ciencia Ficcion", "Viaje al Centro de la Tierra", 4500, 0, 10);


            libros.Add(lib1);
            libros.Add(lib2);
            libros.Add(lib3);
            libros.Add(lib4);
            libros.Add(lib5);
            libros.Add(lib6);
            libros.Add(lib7);
            libros.Add(lib8);
            libros.Add(lib9);
            libros.Add(lib10);

            this.menuPrincipal();

        }

        public void datosCliente()
        {
            Console.WriteLine("Ingrese su nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el numero");
            int numero = int.Parse(Console.ReadLine());

            cliente.setNombre(nombre);
            cliente.setNumero(numero);

            
        }

        public void datosLibro()
        {
            Console.WriteLine("Escoja entre los 10 libros");
            Console.WriteLine("1. El Sennor de los anillos");
            Console.WriteLine("2. El Mago de Ozz");
            Console.WriteLine("3. La Zona Muerte");
            Console.WriteLine("4. Cementerio");
            Console.WriteLine("5. Alicia en el Pais de las Maravillas");
            Console.WriteLine("6. Las Aventuras de Tom Saywer");
            Console.WriteLine("7. Quiero Aprender");
            Console.WriteLine("8. Mi Primer Libro de Matematica");
            Console.WriteLine("9. El Poder del Pensamiento");
            Console.WriteLine("10. Viaje al Centro de la Tierra");

            numeroLibro = int.Parse(Console.ReadLine());
            cantidadLibro = int.Parse(Console.ReadLine());

        }


        public void menuPrincipal()
        {
            Console.WriteLine("Bienvenido a la Libreria El Buen Lector");
            this.datosCliente();
            this.datosLibro();
            switch (numeroLibro)
            {
                case 1:
                   this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(0).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(0).getPrecio(), this.libros.ElementAt<Libro>(0).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(0).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(0).getPrecio(),this.fac.getImpTotal(),this.fac.getDesc()));
                    this.imprimirFactura(0);
                    break;

                case 2:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(1).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(1).getPrecio(), this.libros.ElementAt<Libro>(1).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(1).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(1).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(1);
                    break;

                case 3:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(2).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(2).getPrecio(), this.libros.ElementAt<Libro>(2).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(2).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(2).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(2);
                    break;

                case 4:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(3).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(3).getPrecio(), this.libros.ElementAt<Libro>(3).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(3).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(3).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(3);
                    break;

                case 5:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(4).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(4).getPrecio(), this.libros.ElementAt<Libro>(4).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(4).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(4).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(4);
                    break;

                case 6:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(5).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(5).getPrecio(),this.libros.ElementAt<Libro>(5).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(5).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(5).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(5);
                    break;

                case 7:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(6).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(6).getPrecio(), this.libros.ElementAt<Libro>(6).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(6).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(6).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(6);
                    break;

                case 8:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(7).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(7).getPrecio(), this.libros.ElementAt<Libro>(7).getTipo()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(7).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(7);
                    break;

                case 9:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(8).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(8).getPrecio(), this.libros.ElementAt<Libro>(8).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(8).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(8).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(8);
                    break;

                case 10:
                    this.fac.setTotalOrden(this.caja.calcularTotalPago(cantidadLibro, this.libros.ElementAt<Libro>(9).getPrecio()));
                    this.fac.setDesc(this.caja.calcularDesc(this.libros.ElementAt<Libro>(9).getPrecio(), this.libros.ElementAt<Libro>(9).getTipo()));
                    this.fac.setImpTotal(this.caja.calcularImpTotal(this.libros.ElementAt<Libro>(9).getPrecio()));
                    this.fac.setPrecioNeto(this.caja.calcularPrecioNeto(this.libros.ElementAt<Libro>(9).getPrecio(), this.fac.getImpTotal(), this.fac.getDesc()));
                    this.imprimirFactura(9);
                    break;
            }
          
        }

        public void imprimirFactura(int numeroLibro)
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("*-*"+"         "+"Libreria El Buen Lector"+"         "+"*-*");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Factura Plataforma" + "                           " + "N001");
            Console.WriteLine("Cliente:t/",this.cliente.getNombre());
            Console.WriteLine("Numero", this.cliente.getNumero());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Item" + "          " + "Cantidad" + "           " + "Precio");
            Console.WriteLine(this.libros.ElementAt<Libro>(numeroLibro)+"    "+this.cantidadLibro+"      "+this.libros.ElementAt<Libro>(numeroLibro).getPrecio());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Total Oden" + "                 ",  this.fac.getTotalOrden());
            Console.WriteLine("Impuesto de venta:" + "                            " + "13%");
            Console.WriteLine("Impuesto total"+"                   "+this.fac.getImpTotal());
            Console.WriteLine("Precio Neto" + "                 "+this.fac.getPrecioNeto());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Monto Recibido" + "           "+ this.fac.getMontoRecibido());
            Console.WriteLine("Monto Cambio" + "               "+ this.fac.getMontoCambio());
            Console.WriteLine("===========================================================");
            Console.WriteLine("Gracias por su compra");
            Console.ReadKey();        
        }
    }
}
