using Project_1279790.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> FindAll();
        T Find(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}
