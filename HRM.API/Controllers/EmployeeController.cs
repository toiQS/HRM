using Azure.Core;
using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employee;
        public EmployeeController(IEmployeeServices employee)
        {
            _employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var data = await _employee.GetEmployees();
            return Ok(data);
        }
        [HttpGet]
        [Route("{text}:string")]
        public async Task<IActionResult> GetEmployeesByText(string text)
        {
            if (string.IsNullOrEmpty(text)) return BadRequest();
            var data = await _employee.GetEmployeesByText(text);
            return Ok(data);
        }
        [HttpGet]
        [Route("{id}:int")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            if(id <= 0) return BadRequest();
            var data = await _employee.GetById(id);
            return Ok(data);
        }
        [HttpGet]
        [Route("{name}:string")]
        public async Task<IActionResult> GetEmployeeByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var data = await _employee.GetByText(name);
                return Ok(data);
            }
            return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeRequest request)
        {
            if (ModelState.IsValid)
            {
                var data = new Employee()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    FullName = $"{request.FirstName} + {request.MiddleName} + {request.LastName}",
                    Address = request.Address,
                    DepartmentId = request.DepartmentId,
                    Email = request.Email,
                    HireDate = request.HireDate,
                    ShiftId = request.ShiftId,
                    PositionId = request.PositionId
                };
                var resut = await _employee.Add(data);
                return Ok(resut);
            }
            return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeRequest request)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Employee()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    FullName = $"{request.FirstName} + {request.MiddleName} + {request.LastName}",
                    Address = request.Address,
                    DepartmentId = request.DepartmentId,
                    Email = request.Email,
                    HireDate = request.HireDate,
                    ShiftId = request.ShiftId,
                    PositionId = request.PositionId
                };
                var resut = await _employee.Update(id,data);
                return Ok(resut);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveEmployee(int id)
        {
            if (id > 0)
            {
                var result = await _employee.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
