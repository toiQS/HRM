using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.salary;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryServices _salaryServices;

        public SalaryController(ISalaryServices salaryServices)
        {
            _salaryServices = salaryServices ?? throw new ArgumentNullException(nameof(salaryServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetSalaries()
        {
            var result = await _salaryServices.GetSalaries();
            return Ok(result);
        }

        [HttpGet]
        [Route("{startDate:datetime}/{endDate:datetime}")]
        public async Task<IActionResult> GetSalariesByDateRange(DateTime startDate, DateTime endDate)
        {
            var result = await _salaryServices.GetSalariesByDateRange(startDate, endDate);
            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetSalaryById(int id)
        {
            var result = await _salaryServices.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddSalary(SalaryRequest salary)
        {
            if (ModelState.IsValid)
            {
                var data = new Salary()
                {
                    BasicSalary = salary.BasicSalary,
                    Bonus = salary.Bonus,
                    Deductions = salary.Deductions,
                    NetSalary = salary.NetSalary,
                    PaymentDate = salary.PaymentDate
                };
                var result = await _salaryServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSalary(int id, SalaryRequest salary)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Salary()
                {
                    BasicSalary = salary.BasicSalary,
                    Bonus = salary.Bonus,
                    Deductions = salary.Deductions,
                    NetSalary = salary.NetSalary,
                    PaymentDate = salary.PaymentDate
                };
                var result = await _salaryServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSalary(int id)
        {
            if (id > 0)
            {
                var result = await _salaryServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
