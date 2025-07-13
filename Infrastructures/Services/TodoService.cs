using Application.Interface;
using Domain.Entities;
using Infrastructures.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoDbContext _context;

        public TodoService(TodoDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> GetAllAsync()
            => await _context.TodoItems.OrderByDescending(t => t.CreatedAt).ToListAsync();

        public async Task<TodoItem?> GetByIdAsync(int id)
            => await _context.TodoItems.FindAsync(id);

        public async Task AddAsync(TodoItem item)
        {
            _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TodoItem item)
        {
            _context.TodoItems.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item is not null)
            {
                _context.TodoItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<TodoItem>> GetAllTodosAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }
    }
}
