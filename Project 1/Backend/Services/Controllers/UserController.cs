using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using business_logic;
using entity_layer.Entities;
using Microsoft.AspNetCore.Cors;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ILogic _logic;
        public UserController(ILogic logic)
        {
            _logic = logic;
        }
        [HttpGet("FetchUser")]
        public IActionResult Get()
        {
            try
            {
                var UserDetails = _logic.GetUserDetails_Models();
                return Ok(UserDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FetchUser/{id}")]
        public IActionResult GetAll([FromRoute] int id)
        {
            try
            {
                var UserDetails = _logic.Get(id);
                if(UserDetails!=null)
                {
                    return Ok(UserDetails);
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
        public IActionResult Add([FromBody] model.UserDetails_model user)
        {
            try
            {
                var newuser = _logic.AdduserDetail(user);
                return Ok(newuser); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update")]
        public IActionResult Update([FromQuery] int id, [FromBody] model.UserDetails_model userDetails)
        {
            try
            {
                var UserDetails = _logic.Get(id);
                if (UserDetails != null)
                {
                    _logic.UpdateUser(id, userDetails);
                    return Ok(userDetails);
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
        public IActionResult Delete([FromQuery] int id)
        {
            try
            {
                var userDel = _logic.Remove(id);
                if (userDel != null)
                {
                    return Ok(userDel);
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
        [HttpGet("Validate")]
        public IActionResult Validate(int id,string password)
        {
            if(!_logic.CheckUser(id,password))
            {
                return Unauthorized("No Details Found");
            }
            else
            {
                return Ok("Details Found");
            }
        }
    }
}
