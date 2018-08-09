using ApplicationServices.Mappers;
using ApplicationServices.Services.CVService.Operations;
using ApplicationServices.Services.CVService.Request;
using ApplicationServices.Services.CVService.Response;
using Domain.Interfaces.Repositories;

namespace ApplicationServices.Services.CVService
{
    public class CVService
    {
        private readonly IGetAllCVsOperation _getAllCVsOperation;

        public CVService(IGetAllCVsOperation getAllCVsOperation)
        {
            _getAllCVsOperation = getAllCVsOperation;
        }

        public GetAllCVsResponse GetAllCVs(GetAllCVsRequest request)
        {
            return _getAllCVsOperation.Execute(request);
        }
    }
}
