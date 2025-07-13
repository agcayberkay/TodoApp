using Infrastructures.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Factories
{
    public class TodoDbContextFactory : IDesignTimeDbContextFactory<TodoDbContext>
    {
        public TodoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoDbContext>();

            // Buraya kendi connection string'ini yaz veya config'ten oku
            optionsBuilder.UseSqlServer("Server=DESKTOP-PJJV610\\SQLEXPRESS;;Database=BlazorTodoDb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new TodoDbContext(optionsBuilder.Options);
        }
    }
}
