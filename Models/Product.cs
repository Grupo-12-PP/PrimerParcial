namespace PrimerParcial.Models
{
    public class Product
    {
        public int Id { get; set; }                     // Clave primaria
        public string Name { get; set; }                // Nombre del producto
        public string? Description { get; set; }        // Descripción opcional
        public decimal Price { get; set; }              // Precio del producto
        public int Stock { get; set; }                  // Cantidad en inventario
        public bool IsActive { get; set; }              // Estado del producto (activo o no)
        public DateTime CreatedAt { get; set; }         // Fecha de creación
        public DateTime? UpdatedAt { get; set; }        // Fecha de última modificación (opcional)
    }
}