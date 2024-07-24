using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.recruitment;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruitmentController : ControllerBase
    {
        private readonly IRecruitmentServices _recruitmentServices;

        public RecruitmentController(IRecruitmentServices recruitmentServices)
        {
            _recruitmentServices = recruitmentServices ?? throw new ArgumentNullException(nameof(recruitmentServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetRecruitments()
        {
            var result = await _recruitmentServices.GetRecruitments();
            return Ok(result);
        }

        [HttpGet]
        [Route("{text}")]
        public async Task<IActionResult> GetRecruitmentsByText(string text)
        {
            var result = await _recruitmentServices.GetRecruitmentsByText(text);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}:int")]
        public async Task<IActionResult> GetRecruitmentById(int Id)
        {
            var result = await _recruitmentServices.GetById(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("{name}:string")]
        public async Task<IActionResult> GetRecruitmentByName(string name)
        {
            var result = await _recruitmentServices.GetByText(name);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecruitment(RecruitmentRequest recruitment)
        {
            if (ModelState.IsValid)
            {
                var data = new Recruitment()
                {
                    RecruitmentPosition = recruitment.RecruitmentPosition,
                    PostingDate = recruitment.PostingDate,
                    Deadline = recruitment.Deadline,
                    Status = recruitment.Status,
                    Requestment = recruitment.Requestment,
                    RecruitmentDescription = recruitment.RecruitmentDescription,
                    DepartmentId = recruitment.DepartmentId
                };
                var result = await _recruitmentServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRecruitment(int id, RecruitmentRequest recruitment)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Recruitment()
                {
                    RecruitmentPosition = recruitment.RecruitmentPosition,
                    PostingDate = recruitment.PostingDate,
                    Deadline = recruitment.Deadline,
                    Status = recruitment.Status,
                    Requestment = recruitment.Requestment,
                    RecruitmentDescription = recruitment.RecruitmentDescription,
                    DepartmentId = recruitment.DepartmentId
                };
                var result = await _recruitmentServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveRecruitment(int id)
        {
            if (id > 0)
            {
                var result = await _recruitmentServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
