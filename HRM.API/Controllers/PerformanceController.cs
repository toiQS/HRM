using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.performance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceController : ControllerBase
    {
        private readonly IPerformanceServices _performanceServices;

        public PerformanceController(IPerformanceServices performanceServices)
        {
            _performanceServices = performanceServices ?? throw new ArgumentNullException(nameof(performanceServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetPerformances()
        {
            var result = await _performanceServices.GetPerformances();
            return Ok(result);
        }

        [HttpGet]
        [Route("{text}:string")]
        public async Task<IActionResult> GetPerformancesByText(string text)
        {
            var result = await _performanceServices.GetPerformancesByText(text);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}:int")]
        public async Task<IActionResult> GetPerformanceById(int Id)
        {
            var result = await _performanceServices.GetById(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("{evaluationDate}:datetime")]
        public async Task<IActionResult> GetPerformanceByEvaluationDate(DateTime evaluationDate)
        {
            var result = await _performanceServices.GetByEvaluationDate(evaluationDate);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddPerformance(PerformanceRequest performance)
        {
            if (ModelState.IsValid)
            {
                var data = new Performance()
                {
                    EvaluationDate = performance.EvaluationDate,
                    Score = performance.Score,
                    Comment = performance.Comment,
                    EmployeeId = performance.EmployeeId,
                    TrainingId = performance.TrainingId,
                    SalaryId = performance.SalaryId
                };
                var result = await _performanceServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePerformance(int id, PerformanceRequest performance)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Performance()
                {
                    EvaluationDate = performance.EvaluationDate,
                    Score = performance.Score,
                    Comment = performance.Comment,
                    EmployeeId = performance.EmployeeId,
                    TrainingId = performance.TrainingId,
                    SalaryId = performance.SalaryId
                };
                var result = await _performanceServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePerformance(int id)
        {
            if (id > 0)
            {
                var result = await _performanceServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
