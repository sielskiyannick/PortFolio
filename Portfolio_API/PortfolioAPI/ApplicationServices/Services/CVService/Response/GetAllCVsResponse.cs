using System.Collections.Generic;
using Contracts.DTOs;

namespace ApplicationServices.Services.CVService.Response
{
    public class GetAllCVsResponse
    {
        public IEnumerable<CV> Cvs { get; set; }
    }
}
