using System;
namespace PhoneBook.Server.Entities
{
	public class Contact
	{
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }
        //public string? CarrierId { get; set; }
        public Carrier? Carrier { get; set; }
    
    }
}

