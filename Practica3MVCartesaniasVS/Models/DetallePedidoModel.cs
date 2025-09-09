using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica3MVCartesaniasVS.Models
{
    public class DetallePedidoModel
    {
        public int Id { get; set; }

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Range(1, 100000)]
        public int Cantidad { get; set; } = 1;

        // 11 dígitos totales, 2 decimales => 9 enteros máx (999,999,999.99)
        [Column(TypeName = "decimal(11,2)")]
        [Range(0, 999999999.99)]
        public decimal PrecioUnitario { get; set; }

        public PedidoModel? Pedido { get; set; }
        public ProductoModel? Producto { get; set; }
    }
}
