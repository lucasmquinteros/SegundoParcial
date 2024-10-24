using Segundo_Parcial.Enums;
namespace Segundo_Parcial.Modulos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; private set; }
        public Categoria Categoria { get; private set; }
        public Producto(string nombre, decimal precio, Categoria categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
        public override string ToString()
        {
            return $"{Nombre}, {Precio}, {Categoria}";
        }

        public void CambiarPrecio(decimal precio)
        {
            Precio = precio;
        }
        public void CambiarCategoria(Categoria categoria)
        {
            Categoria = categoria;
        }
    }
}
