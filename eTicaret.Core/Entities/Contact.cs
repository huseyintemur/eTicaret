namespace eTicaret.Core.Entities
{
    public class Contact :IEntity
    {

        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public required string Message   { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
