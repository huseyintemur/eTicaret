namespace eTicaret.Core.Entities
{
    public class AppUser :IEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Surname { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public required string Password { get; set; }
        public string? UserName { get; set; }

        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public Guid? UserGuid { get; set; } = Guid.NewGuid();

    }
}
