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
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
              
            private readonly IVaccinationRepository _vaccination;
            public VaccinationController(IVaccinationRepository vaccination)
            {
            _vaccination = vaccination ??
                    throw new ArgumentNullException(nameof(vaccination));
            }
            [HttpGet]
            [Route("GetVaccination")]
            public async Task<IActionResult> Get()
            {
                return Ok(await _vaccination.GetVaccinationInfo());
            }
            [HttpGet]
            [Route("GetVaccinationByID/{Id}")]
            public async Task<IActionResult> GetVacById(int Id)
            {
                return Ok(await _vaccination.GetVaccinationInfoByID(Id));
            }
            [HttpPost]
            [Route("CreateVaccination")]
            public async Task<IActionResult> Post(TVaccination vac)
            {
                var result = await _vaccination.InsertVaccinationInfo(vac);
                if (result.Id == 0)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
                }
                return Ok("Added Successfully");
            }
            [HttpPut]
            [Route("UpdateVaccination")]
            public async Task<IActionResult> Put(TVaccination vac)
            {
                await _vaccination.UpdateVaccinationInfo(vac);
                return Ok("Updated Successfully");
            }
            [HttpDelete]
            //[HttpDelete("{id}")]
            [Route("DeleteVaccination")]
            public JsonResult Delete(int id)
            {
            _vaccination.DeleteVaccinationInfo(id);
                return new JsonResult("Deleted Successfully");
            }
        
    }
}
