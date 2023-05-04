using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleMAUI.Models
{
    public class UsuarioDatos
    {
        public int IdUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public string Permisos { get; set; }
        public string Rol { get; set; }
        public string Status { get; set; }
        public int MyProperty { get; set; }
    }
}
