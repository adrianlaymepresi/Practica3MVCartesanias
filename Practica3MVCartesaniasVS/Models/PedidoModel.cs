using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica3MVCartesaniasVS.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaPedido { get; set; } = DateTime.Today;

        [Required]
        public int IdCliente { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }

        // 13 dígitos totales, 2 decimales => 11 enteros máx (99,999,999,999.99)
        [Column(TypeName = "decimal(13,2)")]
        public decimal MontoTotal { get; set; }

        public ClienteModel? Cliente { get; set; }
        public ICollection<DetallePedidoModel>? DetallePedidos { get; set; }
    }
}
