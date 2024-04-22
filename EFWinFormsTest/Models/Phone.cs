namespace EFWinFormsTest.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
