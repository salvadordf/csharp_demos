using System.ComponentModel.DataAnnotations.Schema;

namespace EFWinFormsTest.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Column(TypeName="Decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
