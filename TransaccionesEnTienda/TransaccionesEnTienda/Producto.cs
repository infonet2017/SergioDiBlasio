using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesEnTienda
{
    class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int CantUnidades { get; set; }

        public List<Factura> ListaFacturas;
        public Proveedor ElProveedor;
        public Tienda LaTienda;
                
        public Producto(int codProd, string nombreProd, double precioProd)
        {
            this.Codigo = codProd;
            this.Nombre = nombreProd;
            this.Precio = precioProd;
        }

        public void InicializarStock(int cantidad)
        {
            this.CantUnidades = cantidad;
        }

        public void DescontarStock(int cantidad)
        {
            try
            {
                if (this.CantUnidades < cantidad)
                {
                    Console.WriteLine("No hay suficientes unidades");
                }
                else
                {
                    this.CantUnidades -= cantidad;
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Error al intentar restar unidades del stock");
            }
            finally
            {
                //si tuviese una apertura de archivo, lo cerraria en este paso
            }
        }

        public void IngresarStock(int cantidad)
        {
            this.CantUnidades += cantidad;
        }

        public Producto ObtenerProducto(int codigoABuscar, List <Producto> MiLista)
        {
            return MiLista.Find(p => p.Codigo == codigoABuscar);
        }
    }
}
