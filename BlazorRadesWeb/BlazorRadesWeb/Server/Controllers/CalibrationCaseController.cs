using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;
using BlazorRadesWeb.Model;
using Microsoft.Extensions.Logging;

namespace BlazorRadesWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalibrationCaseController : ControllerBase
    {
        private readonly ICalibrationCaseRepository calibrationCaseRepository;
        
        //private readonly ILogger<CalibrationCaseController> logger;

        //public CalibrationCaseController(ILogger<CalibrationCaseController> logger)
        //{
        //    this.logger = logger;
        //}


        public CalibrationCaseController(ICalibrationCaseRepository calibrationCaseRepository)
        {
            this.calibrationCaseRepository = calibrationCaseRepository;
        }

        //public CalibrationCaseController(CalibrationCaseRepository calibrationCaseRepository, ILogger<CalibrationCaseController> logger)
        //{
        //    this.logger = logger;
        //    this.calibrationCaseRepository = calibrationCaseRepository;
        //}

        //[HttpGet]
        //public async Task<CalibrationCase> Get(string id)
        //{
        //    return await this.calibrationCaseRepository.GetCalibrationCaseAsync(id);
        //}


        [HttpGet]
        public async Task<IEnumerable<CalibrationCase>> Get()
        {
            return await this.calibrationCaseRepository.GetCalibrationCaseAsync();
        }

        //[HttpGet]
        //public async Task<IEnumerable<CalibrationCase>> Get(DateTime startDate)
        //{
        //    return await this.calibrationCaseRepository.GetCalibrationCaseAsync(startDate);
        //}


        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

    }
}
