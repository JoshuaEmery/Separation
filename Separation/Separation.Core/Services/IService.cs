using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Separation.Core.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        /// <summary>
        /// Returns the entity object with the primary key id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(int id);
        /// <summary>
        /// Return all entities as an IEnumberable
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Takes a func delegate parameter and returns all matching entities
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
