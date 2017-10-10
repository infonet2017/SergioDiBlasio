using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesEnTienda
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long DNI { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion_Calle { get; set; }
        public string Direccion_Numero { get; set; }

        public List <Factura> ListaFacturas;
    }
}
