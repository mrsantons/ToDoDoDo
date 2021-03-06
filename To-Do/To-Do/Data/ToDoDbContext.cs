﻿using Microsoft.EntityFrameworkCore;
using System;
using To_Do.Models;

namespace To_Do.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDos>().HasData(
                new ToDos
                {
                    Id = 1,
                    Title = "Dry Storage Inventory",
                    ExpectedCompletion = new DateTime(2020, 6, 10, 6, 05, 12, 000, DateTimeKind.Utc),
                    Assignee = "Marie",
                    Difficulty = 3,
                },
                 new ToDos
                 {
                     Id = 2,
                     Title = "Freezer",
                     ExpectedCompletion = new DateTime(2020, 6, 11, 6, 05, 11, 000, DateTimeKind.Utc),
                     Assignee = "Brice",
                     Difficulty = 4,
                 },
                 new ToDos
                 {
                        Id = 3,
                        Title = "Cold Storage Inventory",
                        ExpectedCompletion = new DateTime(2020, 6, 11, 6, 05, 11, 000, DateTimeKind.Utc),
                        Assignee = "Betsy",
                        Difficulty = 3,
                 });

        }
        public DbSet<ToDos> ToDos { get; set; }
    }
}
