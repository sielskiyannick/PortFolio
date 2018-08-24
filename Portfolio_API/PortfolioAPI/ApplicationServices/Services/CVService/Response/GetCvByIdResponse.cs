using System;
using System.Collections.Generic;
using System.Text;
using Contracts.DTOs;

namespace ApplicationServices.Services.CVService.Response
{
    public class GetCvByIdResponse
    {
        public CV Cv { get; set; }
    }
}
