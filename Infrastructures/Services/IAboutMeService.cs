using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Services
{
    public interface IAboutMeService
    {
        Task<AboutMe?> GetAboutMeAsync();
    }
}
