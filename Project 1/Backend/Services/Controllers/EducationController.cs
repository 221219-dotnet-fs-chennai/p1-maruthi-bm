using business_logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        ILogicEducation _logicEducation;
        public EducationController(ILogicEducation logicEducation)
        {
            _logicEducation = logicEducation;

        }
        [HttpGet("FetchCompany")]
        public IActionResult Get()
        {
            try
            {
                var education = _logicEducation.GetEducation_Models();
                return Ok(education);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("FetchUser/{id}")]
        public IActionResult GetEducation([FromRoute]int id)
        {
            try
            {
                var education = _logicEducation.GetEducation(id);
                if(education != null)
                {
                    return Ok(education);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Adduser")]
        public IActionResult Add([FromBody] model.Education_model education)
        {
            try
            {
                var newuser = _logicEducation.AddEducation(education);
                return Ok(newuser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] model.Education_model education)
        {
            try
            {
                var newuser = _logicEducation.Update(id, education);
                if(newuser != null)
                {
                    _logicEducation.Update(id, education);
                    return Ok(newuser);
                }
                else
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                    return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] int id)
        {
            try
            {
                var userdele = _logicEducation.Remove(id);
                if(userdele != null)
                {
                    return Ok(userdele);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
