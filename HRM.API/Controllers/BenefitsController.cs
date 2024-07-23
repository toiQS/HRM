using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API;
using HRM.Services.API.benefits;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitsController : ControllerBase
    {
        private readonly IBenefitsServices _benefits;
        public BenefitsController(IBenefitsServices benefits)
        {
            _benefits = benefits ?? throw new ArgumentNullException(nameof(benefits));
        }

        [HttpGet]
        public async Task<IActionResult> GetBenefits()
        {
            var result = await _benefits.GetBenefits();
            return Ok(result);
        }

        [HttpGet]
        [Route("{text}")]
        public async Task<IActionResult> GetBenefitsByText(string text)
        {
            var result = await _benefits.GetBenefitsByText(text);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}:int")]
        public async Task<IActionResult> GetBenefitsById(int Id)
        {
            var result = await _benefits.GetById(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("{name}:string")]
        public async Task<IActionResult> GetBenefitsByName(string name)
        {
            var result = await _benefits.GetByText(name);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddBenefits(BenefitsRequest benefits)
        {
            if (ModelState.IsValid)
            {
                var data = new Benefits()
                {
                    BenefitsName = benefits.BenefitsName,
                    BenefitsDescription = benefits.BenefitsDescription,
                    EndAt = benefits.EndAt,
                    PositionId = benefits.PositionId,
                    StartAt = benefits.StartAt,
                    TypeBenefits = benefits.TypeBenefits,
                };
                var result = await _benefits.Add(data);
                return Ok(result);
            }
            return BadRequest();    
        }
    }
}
