using DTOs.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GibraltorLLCAPI.Controllers
{
    public class VaccinationHistoryController : ControllerBase
    {
        private readonly IVaccinationHistoryRepository _vh;
        public VaccinationHistoryController(IVaccinationHistoryRepository vh)
        {
            _vh = vh ??
                    throw new ArgumentNullException(nameof(vh));
        }
        [HttpGet]
        [Route("GetVaccinationHistory")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _vh.GetVacInfo());
        }
        [HttpGet]
        [Route("GetVaccinationByID/{Id}")]
        public async Task<IActionResult> GetVacById(int Id)
        {
            return Ok(await _vh.GetVacHistoryByID(Id));
        }
        [HttpPost]
        [Route("CreateVaccinationHistory")]
        public async Task<IActionResult> Post(TVaccinationHistory vh)
        {
            var result = await _vh.InsertVacInfo(vh);
            if (result.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Added Successfully");
        }
        [HttpPut]
        [Route("UpdateVaccinationHistory")]
        public async Task<IActionResult> Put(TVaccinationHistory vh)
        {
            await _vh.UpdateVacInfo(vh);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeleteVaccinationHistory")]
        public JsonResult Delete(int id)
        {
            _vh.DeleteVacInfo(id);
            return new JsonResult("Deleted Successfully");
        }
    }
} 
