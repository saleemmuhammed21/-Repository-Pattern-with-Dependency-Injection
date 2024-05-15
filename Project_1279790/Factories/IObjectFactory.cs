using Project_1279790.Models;
using Project_1279790.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790.Factories
{
    public interface IObjectFactory
    {
        IRepository<T> CreateRepository<T>() where T : BaseEntity;
    }
}
