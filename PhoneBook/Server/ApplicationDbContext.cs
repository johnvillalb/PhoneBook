using System;
using PhoneBook.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Server
{
	public class ApplicationDbContext : DbContext

	{
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Carrier> Carriers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
		{

		}
        // Add this method to override program.cs setup
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;database=phone_book;user=root;password=Atenea-880329",
                    new MySqlServerVersion(new Version(8, 0, 30)));
            }
        }
    }
}

