﻿using Data;
using Microsoft.EntityFrameworkCore;

namespace API.ApplicationDbContext
{
    public class BlazorDbContext : DbContext
    {
        public BlazorDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "Peter",
                    LastName = "Parker",
                    NickName = "Spider-Man",
                    Place = "New York City",
                    DateOfBirth = new DateTime(2001, 8, 1)
                },
                new Contact
                {
                    Id = 2,
                    FirstName = "Tony",
                    LastName = "Stark",
                    NickName = "Iron Man",
                    Place = "Malibu",
                    DateOfBirth = new DateTime(1970, 5, 29)
                },
                new Contact
                {
                    Id = 3,
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    NickName = "Batman",
                    Place = "Gotham City",
                    DateOfBirth = new DateTime(1915, 4, 7)
                }
                );

            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, ContactId = 1, Text = "With great power comes great responsibility." },
                new Note { Id = 2, ContactId = 2, Text = "I am Iron Man" },
                new Note { Id = 3, ContactId = 3, Text = "I'm Batman!" }
                );
        }

        public DbSet<Contact> contacts { get; set; }    
        public DbSet<Note> notes { get; set; }    

    }
}
