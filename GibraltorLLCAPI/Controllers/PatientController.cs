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
            return Ok(await _patient.GetPatientInfo());
        }
        [HttpGet]
        [Route("GetPatientByID/{Id}")]
        public async Task<IActionResult> GetVacById(int Id)
        {
            return Ok(await _patient.GetPatientInfoByID(Id));
        }
        [HttpPost]
        [Route("CreatePatient")]
        public async Task<IActionResult> Post(TPatientInfo pat)
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
        public async Task<IActionResult> Put(TPatientInfo pat)
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

        //private readonly IPatientRepository _patient;
        //List<DTOPatientInfo> oTempList = new List<DTOPatientInfo>();
        //public PatientController(IPatientRepository patientRepository)
        //{
        //    _patient = patientRepository;
        //}
        //[HttpGet]
        //[Route("GetPatientInfo")]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok( _patient.GetPatientInfo());
        //}

        //[HttpGet]
        //[Route("GetPatientInfoByID")]
        //public async Task<IActionResult> GetById(Guid ID)
        //{
        //    //return Ok(_patient.GetPatientInfoByID(ID));
        //    return Ok(oTempList.Where(s=>s.Id == ID).FirstOrDefault());
        //}

        //[HttpPost]
        //[Route("InsertPatientInfo")]
        //public async Task<DTOPatientInfo> InsertPatient(DTOPatientInfo oPat)
        //{
        //   oTempList.Add(_patient.InsertPatientInfo(oPat));
        //    return _patient.InsertPatientInfo(oPat);
        //}

        //[HttpPut]
        //[Route("UpdatePatientInfo")]
        //public async Task<DTOPatientInfo> UpdatePatient(DTOPatientInfo objPat)
        //{
        //    //_patient.UpdatePatientInfo(objPat);
        //    return _patient.UpdatePatientInfo(objPat);
        //}

        //[HttpDelete]
        //[Route("DeletePatientInfo")]
        //public JsonResult DeletePatient(Guid ID)
        //{
        //    var result = _patient.DeletePatientInfo(ID);
        //    return new JsonResult("Deleted Successfully");

        //}

    }
}
