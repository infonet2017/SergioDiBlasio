using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesEnTienda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la Tienda 2.0" + Environment.NewLine);
            
            Console.WriteLine("¿QUE OPERACION QUIERE REALIZAR? " + Environment.NewLine + "1. Ingresar Productos al Stock" +
                Environment.NewLine + "2. Ingresar Proveedores" + Environment.NewLine + "3. Realizar Factura" +
                Environment.NewLine + "4. Ingresar Transaccion relacionada a un Proveedor" + Environment.NewLine + "5. Salir" + 
                Environment.NewLine);

            Console.Write("SELECCIONE UNA OPCION:");
            int eleccion = Convert.ToInt32(Console.ReadLine());            

            switch (eleccion)
            {
                case 1:

                    Console.Write("INGRESE EL CODIGO DEL PRODUCTO: ");
                    int codigoProducto = Convert.ToInt32(Console.ReadLine());

                    Producto MiProducto = new Producto(0,"",0.00);
                    MiProducto.Codigo = codigoProducto;
                    //si ya existe, sumo la cantidad que ingresan al codigo capturado
                    if 
                    //sino , debo crear el producto y guardar todos sus datos

                    Console.Write("INGRESE EL NOMBRE DEL PRODUCTO: ");

                    Console.Write("INGRESE EL PRECIO DEL PRODUCTO (por ej:54.25: ");

                    Console.Write("INGRESE LA CANTIDAD DE UNIDADES A INCREMENTAR DEL PRODUCTO: ");

                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:                    
                    Console.WriteLine("****GRACIAS POR HABER UTILIZADO LA TIENDA 2.0****" + Environment.NewLine);
                    break;
                default:
                    Console.WriteLine("La opcion seleccionada no es correcta, seleccione nueamente" + Environment.NewLine);
                    break;
            }
            Console.ReadKey();
        }
    }
}
