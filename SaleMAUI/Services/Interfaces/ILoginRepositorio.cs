
using SaleMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleMAUI.Services
{
    public interface ILoginRepositorio
    {
        Task<UsuarioDatos> Login(string email, string password);
    }
}
