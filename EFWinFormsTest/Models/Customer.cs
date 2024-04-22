namespace EFWinFormsTest.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Address { get; set; }

        public ICollection<Phone> Phones { get; set; } = null!;
    }
}
