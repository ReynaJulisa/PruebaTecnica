using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DA_Usuario
    {
       
        public List<Usuario> ListaUsuario() {

            return new List<Usuario>
            {
                new Usuario{ Nombre ="Reyna Julisa Valiente", Correo = "jvaliente@gmail.com", Clave= "123" , Roles = new string[]{"Administrador", "Empleado" } },
                new Usuario{ Nombre ="Juan Luis Guerra", Correo = "guerraluis@gmail.com", Clave= "123" , Roles = new string[]{"Empleado"} },
                new Usuario{ Nombre ="Marco Antonio Solis", Correo = "solisantony@gmail.com", Clave= "123" , Roles = new string[]{"Empleado"} },
                new Usuario{ Nombre ="Oscar Humberto", Correo = "oshumbert@gmail.com", Clave= "123" , Roles = new string[]{ "Empleado" } }

            };

        }

        public Usuario ValidarUsuario(string _correo, string _clave) {

            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();

        }

    }
}
