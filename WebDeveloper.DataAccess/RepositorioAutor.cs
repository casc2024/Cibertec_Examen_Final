using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.DataAccess
{
    public class RepositorioAutor : AccesoBaseDatos<Autor>
    {
        public IEnumerable<AutorDTO> ListaAutorDTO(){
            using (var dbContext = new WebContextDb()) {
                return Automapper.GetGeneric<Autor, AutorDTO>(dbContext.Autor.ToList().OrderByDescending(x => x.Apellidos));
            }
        }
        public Autor ObtenerAutorId(int id) {
            using (var dbContext = new WebContextDb()) {
                return dbContext.Autor.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
