using business_logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ILogicCompany _logicCompany;
        public CompanyController(ILogicCompany logicCompany)
        {
            _logicCompany = logicCompany;
        }
        [HttpGet("FetchCompany")]
        public IActionResult Get()
        {
            try
            {
                var companies = _logicCompany.GetCompany_Models();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("FetchUser/{id}")]
        public IActionResult GetCompany([FromRoute]int id)
        {
            try
            {
                var companies = _logicCompany.GetCompany(id);
                if(companies != null)
                {
                    return Ok(companies);
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
        public IActionResult Add([FromBody] model.Company_model company)
        {
            try
            {
                var newuser = _logicCompany.AddCompany(company);
                return Ok(newuser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] model.Company_model company)
        {
            try
            {
                var newuser = _logicCompany.Update(id, company);
                if(newuser != null)
                {
                    _logicCompany.Update(id, company);
                    return Ok(newuser);
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
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] int id)
        {
            try
            {
                var userdele = _logicCompany.Remove(id);
                if (userdele!= null)
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
