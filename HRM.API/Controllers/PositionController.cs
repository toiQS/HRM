using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.position;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionServices _positionServices;

        public PositionController(IPositionServices positionServices)
        {
            _positionServices = positionServices ?? throw new ArgumentNullException(nameof(positionServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetPositions()
        {
            var result = await _positionServices.GetPositions();
            return Ok(result);
        }

        [HttpGet]
        [Route("{text}")]
        public async Task<IActionResult> GetPositionsByText(string text)
        {
            var result = await _positionServices.GetPositionsByText(text);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}:int")]
        public async Task<IActionResult> GetPositionById(int Id)
        {
            var result = await _positionServices.GetById(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("{name}:string")]
        public async Task<IActionResult> GetPositionByName(string name)
        {
            var result = await _positionServices.GetByText(name);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddPosition(PositionRequest position)
        {
            if (ModelState.IsValid)
            {
                var data = new Position()
                {
                    PositionName = position.PositionName,
                    PositionDescription = position.PositionDescription
                };
                var result = await _positionServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePosition(int id, PositionRequest position)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Position()
                {
                    PositionName = position.PositionName,
                    PositionDescription = position.PositionDescription
                };
                var result = await _positionServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePosition(int id)
        {
            if (id > 0)
            {
                var result = await _positionServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
