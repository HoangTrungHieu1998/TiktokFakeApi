using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tiktok.Data.DbContext.Models;

namespace Tiktok.Data.DbContext
{
    public class AppTiktokContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppTiktokContext() 
        {
        }

        public AppTiktokContext(DbContextOptions<AppTiktokContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AVRJ59K\SQLEXPRESS;Database=Tiktok;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CommentChild> CommentChild { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Follow> Follow { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Video> Video { get; set; }
    }
}
