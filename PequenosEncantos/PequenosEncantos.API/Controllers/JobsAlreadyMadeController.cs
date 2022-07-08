using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PequenosEncantos.API.Model;


namespace PequenosEncantos.API.Controllers
{
    [Route("api/jobs")]
    public class JobsAlreadyMadeController : ControllerBase
    {
        [HttpGet]
        public IActionResult SearchForJobsAlreadyMade(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult SearchForSpecificJobMade(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateANewJob([FromBody] CreateANewJobModel createANewJob)
        {
            return CreatedAtAction(nameof(SearchForSpecificJobMade), new { id = createANewJob.JobId }, createANewJob);
        }

        [HttpPut("{id}/start")]
        public IActionResult ProjectStarted(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult ProjectFinished(int id)
        {
            return NoContent();
        }

    }
}
