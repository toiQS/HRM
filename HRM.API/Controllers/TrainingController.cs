using HRM.API.Modes;
using HRM.Models;
using HRM.Services.API.training;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingServices _trainingServices;

        public TrainingController(ITrainingServices trainingServices)
        {
            _trainingServices = trainingServices ?? throw new ArgumentNullException(nameof(trainingServices));
        }

        [HttpGet]
        public async Task<IActionResult> GetTrainings()
        {
            var result = await _trainingServices.GetTrainings();
            return Ok(result);
        }

        [HttpGet]
        [Route("{startDate:datetime}/{endDate:datetime}")]
        public async Task<IActionResult> GetTrainingsByDateRange(DateTime startDate, DateTime endDate)
        {
            var result = await _trainingServices.GetTrainingsByDateRange(startDate, endDate);
            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetTrainingById(int id)
        {
            var result = await _trainingServices.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddTraining(TrainingRequest training)
        {
            if (ModelState.IsValid)
            {
                var data = new Training()
                {
                    TrainName = training.TrainName,
                    TrainDescription = training.TrainDescription,
                    StartAt = training.StartAt,
                    EndAt = training.EndAt,
                    TypeTrain = training.TypeTrain,
                    Status = training.Status
                };
                var result = await _trainingServices.Add(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTraining(int id, TrainingRequest training)
        {
            if (ModelState.IsValid && id > 0)
            {
                var data = new Training()
                {
                    TrainName = training.TrainName,
                    TrainDescription = training.TrainDescription,
                    StartAt = training.StartAt,
                    EndAt = training.EndAt,
                    TypeTrain = training.TypeTrain,
                    Status = training.Status
                };
                var result = await _trainingServices.Update(id, data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTraining(int id)
        {
            if (id > 0)
            {
                var result = await _trainingServices.Delete(id);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
