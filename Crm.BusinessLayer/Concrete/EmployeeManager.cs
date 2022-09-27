using Crm.BusinessLayer.Abstact;
using Crm.DataAccessLayer.Abstract;
using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public Employee TGetByID(int id)
        {
            return _employeeDal.GetByID(id);
        }

        public List<Employee> TGetListAll()
        {
            return _employeeDal.GetListAll();
        }

        public void TInsert(Employee t)
        {
            _employeeDal.Insert(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }
    }
}
