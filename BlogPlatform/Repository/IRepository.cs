using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repository
{
    public interface IRepository<T> : ISelectList
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);

        void Create(T obj);

        void Update(T obj);

        void Delete(T obj);
        Post GetPostById(int id);
    }
}
