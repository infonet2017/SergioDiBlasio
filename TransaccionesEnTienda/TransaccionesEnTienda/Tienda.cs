using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesEnTienda
{
    class Tienda
    {
        public string Nombre { get; set; }
        public string Domicilio_Calle { get; set; }
        public string Domicilio_Numero { get; set; }
        public string CUIT { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public List <Factura> ListaFacturas;
        public List <Producto> ListaProductosEnStock;
        public List <Transaccion> ListaTransaccion;

    }
}
