using EverData.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EverData.Models.Contracts
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
    }
}
