using Project_1279790.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IList<T> data;
        public GenericRepository()
        {
            this.data = new List<T>();
        }
        public List<T> FindAll()
        {
            return this.data.ToList();
        }
        public T Find(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }
        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                this.data.Add(entity);
            }
        }
        public void Update(T entity)
        {
            int i = this.data.IndexOf(entity);
            this.data.RemoveAt(i);
            this.data.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = this.data.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                this.data.Remove(entity);
            }
        }
    }
}
