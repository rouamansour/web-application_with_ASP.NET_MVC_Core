using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atelier1.Models.Repositories
{
    public interface IRepository <T>
    {
        IList<T> GetAll();
        T FindByID(int id);
        double SalaryAverage();
        double MaxSalary();
        int HrEmployeesCount();
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        List<T> Search(string term);
    }
}
