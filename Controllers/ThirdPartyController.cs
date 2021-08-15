using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiGresol.Service;
using WebApiGresol.DTO;
using Serilog;
using Microsoft.Extensions.Logging;
using System.Text;

namespace WebApiGresol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyController: ControllerBase
    {
        private readonly IThirdPartyService thirdPartyService;
        private readonly ILogger<ThirdPartyController> logger;
        public ThirdPartyController(IThirdPartyService thirdPartySer, ILogger<ThirdPartyController> log)
        {
            this.thirdPartyService = thirdPartySer;
            this.logger = log;

        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DtoThirdParty>> Get()
        {

            List<DtoThirdParty> dtoThirdParties = null;
            try
            {
                
                dtoThirdParties = new List<DtoThirdParty>(thirdPartyService.GetDtoThirdParties());
               
            }
            catch (Exception ex)
            {
                
                var sb = new StringBuilder();
                sb.AppendLine($"Error message:{ex.Message}");
                sb.AppendLine($"Error stack trace:{ex.StackTrace}");
                logger.LogError(sb.ToString());
                
            }
            return dtoThirdParties;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}



        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<DtoThirdParty> GetThirdParty(int id)
        {
            DtoThirdParty dtoThirdParty = null;

            try
            {
                thirdPartyService.GetThirdPartyById(id);
            }
            catch (Exception ex)
            {

                var sb = new StringBuilder();
                sb.AppendLine($"Error message:{ex.Message}");
                sb.AppendLine($"Error stack trace:{ex.StackTrace}");
                logger.LogError(sb.ToString());
            }
            

            return dtoThirdParty;
                
        }

        // POST api/values/
        [HttpPost()]
        public async Task<ActionResult> Post([FromBody] DtoThirdParty dtoThirdParty)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    if (await thirdPartyService.SaveThirdParty(dtoThirdParty)!=0)
                    {
                        return StatusCode(200);
                    }
                    else
                    {
                        //return StatusCode(400);
                        return BadRequest(ModelState);
                    }

                }
                else
                {

                    return StatusCode(400);
                }

            }
            catch (Exception  ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Error message:{ex.Message}");
                sb.AppendLine($"Error stack trace:{ex.StackTrace}");
                logger.LogError(sb.ToString());
                return StatusCode(400);
            }


            

        }




        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DtoThirdParty dtoThirdParty)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    if (thirdPartyService.UpdateThirdParty(id, dtoThirdParty))
                    {
                        return StatusCode(200);
                    }
                    else
                    {
                        //return StatusCode(400);
                        return BadRequest(ModelState);
                    }

                }
                else
                {

                    return StatusCode(400);
                }

            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Error message:{ex.Message}");
                sb.AppendLine($"Error stack trace:{ex.StackTrace}");
                logger.LogError(sb.ToString());
                return StatusCode(400);
            }


        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                thirdPartyService.DeleteThirdParty(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Error message:{ex.Message}");
                sb.AppendLine($"Error stack trace:{ex.StackTrace}");
                logger.LogError(sb.ToString());
                return StatusCode(400);
                
            }
            
        }



    }
}
