using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthLibrary.Areas.Identity.Data;
using AuthLibrary.Models.BookEntities;
using AuthLibrary.Models.IssueEntities;
using AuthLibrary.Models.MemberEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthLibrary.Data
{
    public class AuthLibraryDBContext : IdentityDbContext<AuthLibraryUser>
    {
        public AuthLibraryDBContext(DbContextOptions<AuthLibraryDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookSubject> BookSubjects { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Student> Students { get; set; }
      
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Issue> Issues { get; set; }
    }
}
