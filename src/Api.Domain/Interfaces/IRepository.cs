using System;
using Api.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T: BaseEntity  // O repositorio ira receber 'qualquer' coisa onde T(esse T pode ser qualquer letra) seja u, tipo de Base Entity
    {
         Task<T> InsertAsync(T item);
         Task<T> UpdateAsync(T item);
         Task<bool> DeleteAsynd(Guid item);
         Task<T> SelectAsync(Guid id);
         Task<IEnumerable<T>> SelectAsync();
    }
}