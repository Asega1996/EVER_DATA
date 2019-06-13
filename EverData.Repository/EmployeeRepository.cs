using EverData.Models.Contracts;
using EverData.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EverData.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee GetEmployee(int id)
        {
            var employees = GetEmployees();
            //return employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee> {
                new Employee{
                    EmployeeId = 1,
                    NombreEmpleado = "Alejandro",
                    ApellidoEmpleado = "Segovia",
                    CategoriaId = 1,
                    ProyectoId = 1,
                    LineaId = 1,
                    CeldaId = 1,
                    CentroId = 1,
                    TecnologiaId = 1,
                    TitulacionId = 1,
                    Supervisor = "SergioSup",
                    Tutor = "SergioTut"
                },
                new Employee{
                    EmployeeId = 2,
                    NombreEmpleado = "Diego",
                    ApellidoEmpleado = "Garcia",
                    CategoriaId = 2,
                    ProyectoId = 2,
                    LineaId = 2,
                    CeldaId = 2,
                    CentroId = 2,
                    TecnologiaId = 2,
                    TitulacionId = 2,
                    Supervisor = "X1",
                    Tutor = "X2"
                },
                new Employee{
                    EmployeeId = 3,
                    NombreEmpleado = "Sergio",
                    ApellidoEmpleado = "Pacheco",
                    CategoriaId = 3,
                    ProyectoId = 3,
                    LineaId = 3,
                    CeldaId = 3,
                    CentroId = 3,
                    TecnologiaId = 3,
                    TitulacionId = 3,
                    Supervisor = "Y1",
                    Tutor = "Y2"
                },
        };
        }
    }
}
