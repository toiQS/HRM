using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.department;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentServices _departmentServices;

        public DepartmentController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices ?? throw new ArgumentNullException(nameof(departmentServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var result = await _departmentServices.GetDepartments();
            return Ok(result);
        }

        [HttpGet]
        [Route("{text}:string")]
        public async Task<IActionResult> GetDepartmentsByText(string text)
        {
            var result = await _departmentServices.GetDepartmentsByText(text);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}:int")]
        public async Task<IActionResult> GetDepartmentById(int Id)
        {
            var result = await _departmentServices.GetById(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("{name}:string")]
        public async Task<IActionResult> GetDepartmentByName(string name)
        {
            var result = await _departmentServices.GetByText(name);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentRequest department)
        {
            if (ModelState.IsValid)
            {
                var data = new Department()
                {
                    DepartmentName = department.DepartmentName,
                    Description = department.Description
                };
                var result = await _departmentServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment(int id, DepartmentRequest department)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Department()
                {
                    DepartmentName = department.DepartmentName,
                    Description = department.Description
                };
                var result = await _departmentServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveDepartment(int id)
        {
            if (id > 0)
            {
                var result = await _departmentServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
