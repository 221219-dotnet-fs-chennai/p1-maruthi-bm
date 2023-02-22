using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using business_logic;
using entity_layer.Entities;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        ILogic _logic;
        public SkillController(ILogic logic)
        {
            _logic = logic;
        }
        [HttpGet("FetchSkill")]
        public IActionResult Get()
        {
            try
            {
                var Skills = _logic.GetSkill_Models();
                return Ok(Skills);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("FetchUser/{id}")]
        public IActionResult GetSkill([FromRoute] int id)
        {
            try
            {
                var Skills = _logic.GetSkill(id);
                if(Skills != null)
                {
                    return Ok(Skills);
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
        [HttpPost("AddUser")]
        public IActionResult Add([FromBody] model.Skill_model skill)
        {
            try
            {
                var newuser = _logic.AddSkill(skill);
                return Ok(newuser); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] model.Skill_model skill)
        {
            try
            {
                var newuser = _logic.Updateuser(id, skill);
                if(newuser != null)
                {
                    _logic.Updateuser(id, skill);
                    return Ok(newuser);
                }
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] int id)
        {
            try
            {
                var userdele = _logic.Removes(id);
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
