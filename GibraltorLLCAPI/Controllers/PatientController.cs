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
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patient;
        public PatientController(IPatientRepository patient)
        {
            _patient = patient ??
                    throw new ArgumentNullException(nameof(patient));
        }
        [HttpGet]
        [Route("GetPatients")]
        public async Task<IActionResult> Get()
        {
            var patients = await _patient.GetPatientInfo();
            if (patients == null)
                return NotFound();

            return Ok(patients);
        }
        [HttpGet]
        [Route("GetPatientByID/{Id}")]
        public async Task<IActionResult> GetVacById(int Id)
        {
            return Ok(await _patient.GetPatientInfoByID(Id));
        }
        [HttpPost]
        [Route("CreatePatient")]
        public async Task<IActionResult> Post(DTOPatientInfo pat)
        {
            var result = await _patient.InsertPatientInfo(pat);
            if (result.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Added Successfully");
        }
        [HttpPut]
        [Route("UpdatePatient")]
        public async Task<IActionResult> Put(DTOPatientInfo pat)
        {
            await _patient.UpdatePatientInfo(pat);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeletePatient")]
        public JsonResult Delete(int id)
        {
            _patient.DeletePatientInfo(id);
            return new JsonResult("Deleted Successfully");
        }


    }
}
