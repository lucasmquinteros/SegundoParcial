using Segundo_Parcial.Enums;

namespace Segundo_Parcial.Modulos
{
    public static class Inventario
    {
        static List<Producto> Productos = new List<Producto>();
        static readonly string ArchivoPanaderia = "archivo.txt";

        public static void AgregarProducto(Producto nuevoProducto)
        {
            Productos.Add(nuevoProducto);
            Console.WriteLine("Producto agregado!");
            GuardarProducto(nuevoProducto);
        }
        public static void MostrarInventario()
        {
            Console.WriteLine("Productos: ");
            foreach(Producto producto in Productos)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine("\n");
        }
        public static void MostrarValorTotalMercancia()
        {
            decimal total = 0;
            foreach(Producto producto in Productos)
            {
                total += producto.Precio;
            }
            Console.WriteLine($"Total del inventario: {total}");
        }
        public static void ModificarProducto(string nombre, string precio, string categoria)
        {
            Producto p = Productos.Find(p => p.Nombre == nombre);
            if (p != null)
            {
                if (!string.IsNullOrWhiteSpace(precio))
                {
                    p.CambiarPrecio(decimal.Parse(precio));
                }
                if (!string.IsNullOrWhiteSpace(categoria))
                {
                    p.CambiarCategoria((Categoria)Enum.Parse(typeof(Categoria), categoria));
                }
                Console.WriteLine("Producto Modificado!");
                GuardarDatos();
            }
        }
        public static void EliminarProducto(string nombre)
        {
            Producto p = Productos.Find(p => p.Nombre == nombre);
            if(p != null && Productos.Remove(p))
            {
                Console.WriteLine("Producto Eliminado.");
                GuardarDatos();
            }
            else { Console.WriteLine("Producto no encontrado."); }
        }
        static void GuardarProducto(Producto producto)
        {
            using StreamWriter writer = new StreamWriter(ArchivoPanaderia, true);
            writer.WriteLine(producto);
        }
        static void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(ArchivoPanaderia);
            foreach(Producto p in Productos)
            {
                writer.WriteLine(p);
            }
        }
        public static void CargarDatos()
        {
            if (File.Exists(ArchivoPanaderia))
            {
                foreach(var linea in File.ReadAllLines(ArchivoPanaderia))
                {
                    string[] p = linea.Split(", ");
                    string nombre = p[0];
                    decimal precio = decimal.Parse(p[1]);   
                    Categoria categoria = (Categoria)Enum.Parse(typeof(Categoria), p[2]);
                    Producto prod = new Producto(nombre, precio, categoria);
                    Productos.Add(prod);
                }
            }
        }
    }
}
