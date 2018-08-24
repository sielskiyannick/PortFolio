using ApplicationServices.Services.CVService.Operations;
using ApplicationServices.Services.CVService.Request;
using ApplicationServices.Services.CVService.Response;

namespace ApplicationServices.Services.CVService
{
    public interface ICVService
    {
        GetAllCVsResponse GetAllCVs(GetAllCVsRequest request);
        GetCvByIdResponse GetCvById(GetCvByIdRequest request);
    }

    public class CVService : ICVService
    {
        private readonly IGetAllCVsOperation _getAllCVsOperation;
        private readonly IGetCvByIdOperation _getCvByIdOperation;

        public CVService(IGetAllCVsOperation getAllCVsOperation,
            IGetCvByIdOperation getCvByIdOperation)
        {
            _getAllCVsOperation = getAllCVsOperation;
            _getCvByIdOperation = getCvByIdOperation;
        }

        public GetAllCVsResponse GetAllCVs(GetAllCVsRequest request)
        {
            return _getAllCVsOperation.Execute(request);
        }

        public GetCvByIdResponse GetCvById(GetCvByIdRequest request)
        {
            return _getCvByIdOperation.Execute(request);
        }
    }
}
