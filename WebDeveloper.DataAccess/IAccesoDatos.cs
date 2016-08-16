using System.Collections.Generic;

namespace WebDeveloper.DataAccess
{
    public interface IAccesoDatos<T>
    {
        List<T> ObtenerLista();
        int Agregar(T entity);
        int Borrar(T entity);
        int Actualizar(T entity);
    }
}
