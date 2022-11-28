using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SistemaVenta.DAL.Interfaces
{
    public interface IGenericRepository <TEntity> where TEntity : class
    {
        Task<TEntity> ObtenerAsync (Expression<Func<TEntity, bool>> filtro);

        Task<TEntity> CrearAsync(TEntity entidad);

        Task<bool> EditarAsync(TEntity entidad);

        Task<bool> EliminarAsync(TEntity entidad);

        Task<IQueryable<TEntity>> Consultar(Expression<Func<TEntity, bool>> filtro= null);

    }
}
