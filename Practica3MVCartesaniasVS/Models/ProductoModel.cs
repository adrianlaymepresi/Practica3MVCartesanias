using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica3MVCartesaniasVS.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(400)]
        public string Descripcion { get; set; }

        // 11 dígitos totales, 2 decimales => 9 enteros máx (999,999,999.99)
        [Range(0, 999999999.99)]
        [Column(TypeName = "decimal(11,2)")]
        public decimal Precio { get; set; }

        [Range(0, 100000)]
        public int Stock { get; set; }

        public ICollection<DetallePedidoModel>? DetallePedidos { get; set; }
    }
}
