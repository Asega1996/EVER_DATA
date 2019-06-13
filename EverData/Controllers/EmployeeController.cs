using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverData.Models.Contracts;
using EverData.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id) {

            var employee = _employeeService.GetEmployee(id);
            if (employee != default(Employee))
                return Ok(employee);

            return BadRequest();
        }

    }
}