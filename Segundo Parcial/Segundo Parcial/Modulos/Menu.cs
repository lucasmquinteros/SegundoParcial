using Segundo_Parcial.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Modulos
{
    public static class Menu
    {
        static List<Action> Acciones = new List<Action>
        {
            AgregarProducto,
            MostrarProductos,
            ModificarProducto,
            EliminarProducto,
            MostrarValorTotalMercancia
        };

        static Categoria PedirCategoria()
        {
            Categoria categoria = new Categoria();
            Console.WriteLine("Ingrese la categoria del producto:");
            foreach(Categoria cat in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine((int)cat + "." + cat.ToString());
            }
            int valor = int.Parse(Console.ReadLine());
            categoria = (Categoria)valor;
            return categoria;
        }
        static string PedirNombre(bool esObligatorio)
        {
            string nombre = null;
            bool flag = false;
            while (!flag)
            {
                nombre = Console.ReadLine();
                if (String.IsNullOrEmpty(nombre) && esObligatorio)
                {
                    Console.WriteLine("Ingrese un nombre valido");
                }
                else
                {
                    flag = true;
                }
            }
            return nombre;
        }
        static void AgregarProducto()
        {
            Console.WriteLine("Ingrese el nombre del nuevo producto:");
            string nombre = PedirNombre(true);
            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Categoria categoria = PedirCategoria();

            Producto p = new Producto(nombre, precio, categoria);
            Inventario.AgregarProducto(p);
        }
        static void MostrarProductos()
        {
            Inventario.MostrarInventario();
        }
        static void MostrarValorTotalMercancia()
        {
            Inventario.MostrarValorTotalMercancia();
        }
        static void ModificarProducto()
        {
            Console.Write("Ingrese el nombre del producto a modificar: ");
            string nombre = PedirNombre(true);
            Console.WriteLine("Ingrese el nuevo nombre del producto");
            Console.WriteLine("(Si no quiere cambiar este campo presione enter)");
            string nuevoNombre = PedirNombre(false);
            Console.WriteLine("Ingrese el precio del producto: ");
            Console.WriteLine("(Si no quiere cambiar este campo presione enter)");
            string precio = Console.ReadLine();
            Console.WriteLine("Ingrese la categoria del producto:");
            foreach (Categoria cat in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine((int)cat + "." + cat.ToString());
            }
            string valor = Console.ReadLine();

            Inventario.ModificarProducto(nombre, nuevoNombre, precio, valor);
        }
        static void EliminarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Inventario.EliminarProducto(nombre);
        }
        public static void MostrarMenu()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar todos los productos");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Mostrar valor total de la mercancia");
                Console.WriteLine("6. Salir.");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();
                Console.WriteLine("\n");
                if (int.TryParse(opcion, out int indice) && indice >= 1 && indice <= Acciones.Count + 1)
                {
                    if (indice == 6)
                    {
                        salir = true;
                    }
                    else
                    {
                        Acciones[indice - 1].Invoke();
                    }
                }
            }
        }
    }
}
