namespace razor_files_demo.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } // Added LastName property
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}