// Infrastructure/Services/AboutMeService.cs
using Domain.Entities;
using Application.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Infrastructures.Services;
using Infrastructures.Context;

public class AboutMeService : IAboutMeService
{
    private readonly TodoDbContext _context;

    public AboutMeService(TodoDbContext context)
    {
        _context = context;
    }

    public async Task<AboutMe?> GetAboutMeAsync()
    {
        // Burada tek bir kayıt çekiliyor, istediğin şekilde filtreleme yapabilirsin
        return await _context.AboutMes.FirstOrDefaultAsync();
    }
}
