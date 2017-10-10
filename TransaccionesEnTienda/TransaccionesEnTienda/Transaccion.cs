using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesEnTienda
{
    class Transaccion
    {
        public int Id_Transaccion { get; set; }
        public char Tipo { get; set; } //letra i para ingreso, letra e para egreso
        public char Estado { get; set; } //letra p para pendiente, letra r para realizado
        public double Monto { get; set; }
        public DateTime FechayHora { get; set; }

        public Proveedor ElProveedor;
        public Tienda LaTienda;
    }
}
