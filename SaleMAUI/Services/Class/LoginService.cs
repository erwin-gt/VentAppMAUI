using Newtonsoft.Json;
using SaleMAUI.Models;
using SaleMAUI.Pages.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SaleMAUI.Services.Class
{
    public class LoginService : ILoginRepositorio
    {
        public async Task<UsuarioDatos> Login(string email, string password)
        {
            
            var usuarioDatos = new UsuarioDatos();
            var cliente = new HttpClient();
          
            //cadena de conexion a la API donde estan los parametros de uso para usuario
            string url = "http://192.168.0.12:88/api/Usuario/" + email + "/" + password;
            cliente.BaseAddress = new Uri(url);
            HttpResponseMessage response = await cliente.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                //El API regresa un listado de lo que se encuentre dentro de una lista
                usuarioDatos=JsonConvert.DeserializeObject<UsuarioDatos>(content);
                return await Task.FromResult(usuarioDatos);
            }
            else
            {
                //Si los datos ingresados no coinciden
                return null;
            }

        }
    }
}
