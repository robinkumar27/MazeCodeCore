using AccountOwnerServer.CustomExceptionMiddleware;
using AccountOwnerServer.Models;
using Contracts;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    for (int i = 0; i < 100000; i++)
        //    {
        //        _logger.LogInfo("Here is info message from the controller.");
        //        _logger.LogDebug("Here is debug message from the controller.");
        //        _logger.LogWarn("Here is warn message from the controller.");
        //        _logger.LogError("Here is error message from the controller.");
        //    }

        //    return new string[] { "value1", "value2" };
        //}
        public IActionResult Get()
        {
            //try
            //{

                _logger.LogInfo("Fetching all the Students from the storage");

                //var students = DataManager.GetAllStudents();
                throw new Exception("Exception while fetching all the students from the storage.");

               // _logger.LogInfo($"Returning {students.Count} students.");


               // return Ok(students);
           // }
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Something went wrong: {ex}");
            //    return StatusCode(500, "Internal server error");
            //}
        }
    }
}