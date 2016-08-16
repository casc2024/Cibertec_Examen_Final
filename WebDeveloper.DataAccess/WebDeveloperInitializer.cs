using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var autores = new List<Autor> {
                new Autor { Nombres = "Juan", Apellidos = "Perez", Telefonos = "962255915", Ciudad = "Lima", Estado = "Lima",Codigo_Cuidad  = "001", Sexo = 1, Salario = 100, Tema = "Ninguno"},
                new Autor { Nombres = "Jose", Apellidos = "Perez", Telefonos = "962255915", Ciudad = "Lima", Estado = "Lima",Codigo_Cuidad  = "001", Sexo = 1, Salario = 100, Tema = "Ninguno"},
                new Autor { Nombres = "Luis", Apellidos = "Perez", Telefonos = "962255915", Ciudad = "Lima", Estado = "Lima",Codigo_Cuidad  = "001", Sexo = 1, Salario = 100, Tema = "Ninguno"},
                new Autor { Nombres = "Jorge", Apellidos = "Perez", Telefonos = "962255915", Ciudad = "Lima", Estado = "Lima",Codigo_Cuidad  = "001", Sexo = 1, Salario = 100, Tema = "Ninguno"},
                new Autor { Nombres = "Miguel", Apellidos = "Perez", Telefonos = "962255915", Ciudad = "Lima", Estado = "Lima",Codigo_Cuidad  = "001", Sexo = 1, Salario = 100, Tema = "Ninguno"}
            };
            autores.ForEach(c => context.Autor.Add(c));
            context.SaveChanges();
        }
    }
}
