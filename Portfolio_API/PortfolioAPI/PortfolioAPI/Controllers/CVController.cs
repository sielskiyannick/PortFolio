using System;
using System.Collections.Generic;
using ApplicationServices.Services.CVService;
using ApplicationServices.Services.CVService.Request;
using Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioAPI.Controllers
{
    //[Route("api/CV")]
    public class CVController : Controller
    {
        private readonly ICVService _cvService;

        public CVController(ICVService cvService)
        {
            _cvService = cvService;
        }

        [HttpGet]
        [Route("api/CV/GetAll")]
        public IEnumerable<CV> GetAll()
        {
            var result = _cvService.GetAllCVs(new GetAllCVsRequest()).Cvs;
            return result;
        }

        [HttpGet]
        [Route("api/CV/GetById/{id}")]
        public CV GetById(Guid id)
        {
            var result = _cvService.GetCvById(new GetCvByIdRequest() {Id = id}).Cv;
            return result;
        }
    }
}