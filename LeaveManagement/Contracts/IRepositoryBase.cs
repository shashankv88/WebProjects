using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindByID(int ID);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();

        bool isExists(int id);
    }
}
