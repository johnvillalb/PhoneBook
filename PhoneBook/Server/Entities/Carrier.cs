using System;
namespace PhoneBook.Server.Entities
{
	public class Carrier
	{
        public int Id { get; set; }
        public string? CarrierName { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}

