using Shopping_Online.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Online.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena =Encriptar.CodificarContrasena( "1318");


            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = " Reyna";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Carlos";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("456");


            var nuevoUsuario4 = new Usuario();
            nuevoUsuario4.Nombre = "Robert";
            nuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("789");

            context.Usuarios.Add(nuevoUsuario);
            context.Usuarios.Add(nuevoUsuario2);
            context.Usuarios.Add(nuevoUsuario3);
            context.Usuarios.Add(nuevoUsuario4);
            base.Seed(context);
        }
    }
}
