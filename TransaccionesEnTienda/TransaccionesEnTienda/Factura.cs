using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesEnTienda
{
    class Factura
    {
        public int codigo { get; set; }
        public char Tipo { get; set; }
        public int NumeroComprobante { get; set; }
        public DateTime FechayHora { get; set; }
        public double Monto { get; set; }
        public string NombreCliente { get; set; }

        public List<Producto> ListaProductos;// { get; set; }
       // public Cliente ElComprador;

        public void InicializarListaProductos(List<Producto>LaLista)
        {
            LaLista = new List<Producto>();
        }

        public void AgregarProductoEnListaProductos(Producto productoNuevo)
        {
            ListaProductos.Add(productoNuevo);
        }

        public void RegistrarFactura(string nombreCliente, List <Producto> ListaProductos)
        {//se crea una nueva factura
            if (this.ListaProductos.Count == 0)
            {
                this.Monto = 0;
            }

            
            
            this.NumeroComprobante++; //incremento el nro de combrobante
            this.Tipo = 'B'; //todas las facturas seran  de tipo B
            this.NombreCliente = nombreCliente;

            

            //double montoProducto = 
            //this.Monto += 
        }

    }
}
