using EverData.Models.Models;

namespace EverData.Models.Contracts
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
    }
}
