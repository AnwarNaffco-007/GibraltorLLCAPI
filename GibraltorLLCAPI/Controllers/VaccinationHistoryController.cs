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
        [Route("GetVaccinationsHistory")]
        public async Task<IActionResult> GetVaccinationsHistory()
        {
            return Ok(await _vh.GetVacInfo());
        }
        [HttpGet]
        [Route("GetVaccinationHistoryByID/{Id}")]
        public async Task<IActionResult> GetVaccinationHistoryByID(int Id)
        {
            return Ok(await _vh.GetVacHistoryByID(Id));
        }

        [HttpPost]
        [Route("CreateVaccinationHistory")]
        public async Task<IActionResult> CreateVaccinationHistory(DTOVaccinationHistory vh)
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
        public async Task<IActionResult> UpdateVaccinationHistory(DTOVaccinationHistory vh)
        {
            await _vh.UpdateVacInfo(vh);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeleteVaccinationHistory")]
        public JsonResult DeleteVaccinationHistory(int id)
        {
            _vh.DeleteVacInfo(id);
            return new JsonResult("Deleted Successfully");
        }
    }
} 
