using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.DAL;
using TestAPI.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace TestAPI.Controllers
{
    public class UnitsController : ApiController
    {
        TestDBEntities db = new TestDBEntities();
        
        [AcceptVerbs("GET")]
        public List<DAL.Unit> Get()
        {            
            var units = db.Units.ToList();
            return units;
        }

        [AcceptVerbs("GET")]
        public DAL.Unit Get(int id)
        {
            var unit = db.Units.Where(m => m.Id == id).FirstOrDefault();
            return unit;
        }
        
        
        [AcceptVerbs("POST")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] Requests.UnitRequest request)
        {
            if (ModelState.IsValid)
            {
                var requestBody = JsonConvert.SerializeObject(new JavaScriptSerializer().Serialize(request), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                if (!UserFunctions.CheckUnitDuplicate(request.Name))
                {
                    return Ok(new { Status = StaticVariables.FAILEDTATUS, Message = StaticVariables.FAILEDMESSAGE });
                }

                if (UserFunctions.InsertUnit(request.Name))
                {
                    return Ok(new { Status = StaticVariables.SUCCESSSTATUS, Message = StaticVariables.SUCCESSMESSAGE });
                }
                else
                {
                    return Ok(new { Status = StaticVariables.FAILEDTATUS, Message = StaticVariables.FAILEDMESSAGE });
                }
                
            }
            else
            {
                return Ok(new { Status = StaticVariables.FAILEDTATUS, Message = StaticVariables.FAILEDMESSAGE });
            }
        }
        
        [AcceptVerbs("PUT")]
        public IHttpActionResult Put([FromBody] Requests.UnitRequest request, int id)
        {
            if (ModelState.IsValid)
            {
                //var requestBody = JsonConvert.SerializeObject(new JavaScriptSerializer().Serialize(request), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
               
                if (UserFunctions.UpdateUnit(id ,request.Name))
                {
                    return Ok(new { Status = StaticVariables.SUCCESSSTATUS, Message = StaticVariables.SUCCESSMESSAGE });
                }
                else
                {
                    return Ok(new { Status = StaticVariables.FAILEDTATUS, Message = StaticVariables.FAILEDMESSAGE });
                }

            }
            else
            {
                return Ok(new { Status = StaticVariables.FAILEDTATUS, Message = StaticVariables.FAILEDMESSAGE });
            }
        }

        [AcceptVerbs("DELETE")]
        public IHttpActionResult Delete(int id)
        {
            var unit = db.Units.Where(m => m.Id == id).FirstOrDefault();
            if (unit != null)
            {
                db.Units.Remove(unit);
                db.SaveChanges();
                return Ok(new { Status = StaticVariables.SUCCESSSTATUS, Message = StaticVariables.SUCCESSMESSAGE });
            }
            else
            {
                return Ok(new { Status = StaticVariables.FAILEDTATUS, Message = StaticVariables.FAILEDMESSAGE });
            }
        }
    }
}
