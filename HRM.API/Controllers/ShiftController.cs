using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.shift;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private readonly IShiftServices _shiftServices;

        public ShiftController(IShiftServices shiftServices)
        {
            _shiftServices = shiftServices ?? throw new ArgumentNullException(nameof(shiftServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetShifts()
        {
            var result = await _shiftServices.GetShifts();
            return Ok(result);
        }

        [HttpGet]
        [Route("{startDate:datetime}/{endDate:datetime}")]
        public async Task<IActionResult> GetShiftsByDateRange(DateTime startDate, DateTime endDate)
        {
            var result = await _shiftServices.GetShiftsByDateRange(startDate, endDate);
            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetShiftById(int id)
        {
            var result = await _shiftServices.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddShift(ShiftRequest shift)
        {
            if (ModelState.IsValid)
            {
                var data = new Shift()
                {
                    StartAt = shift.StartAt,
                    EndAt = shift.EndAt,
                    DayOfApplication = shift.DayOfApplication,
                    TotalHours = shift.TotalHours
                };
                var result = await _shiftServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateShift(int id, ShiftRequest shift)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Shift()
                {
                    StartAt = shift.StartAt,
                    EndAt = shift.EndAt,
                    DayOfApplication = shift.DayOfApplication,
                    TotalHours = shift.TotalHours
                };
                var result = await _shiftServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveShift(int id)
        {
            if (id > 0)
            {
                var result = await _shiftServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
