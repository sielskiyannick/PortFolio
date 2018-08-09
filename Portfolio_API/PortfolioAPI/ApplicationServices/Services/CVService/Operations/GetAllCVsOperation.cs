using ApplicationServices.Mappers;
using ApplicationServices.Services.CVService.Request;
using ApplicationServices.Services.CVService.Response;
using Domain.Interfaces.Repositories;

namespace ApplicationServices.Services.CVService.Operations
{
    public interface IGetAllCVsOperation
    {
        GetAllCVsResponse Execute(GetAllCVsRequest Request);
    }

    public class GetAllCVsOperation: IGetAllCVsOperation
    {
        private readonly ICVRepository _cvRepository;
        private readonly IMapper<Domain.Entities.CV, Contracts.DTOs.CV> _cvMapper;

        public GetAllCVsOperation(ICVRepository cvRepository,
            IMapper<Domain.Entities.CV, Contracts.DTOs.CV> cvMapper)
        {
            _cvRepository = cvRepository;
            _cvMapper = cvMapper;
        }

        public GetAllCVsResponse Execute(GetAllCVsRequest Request)
        {
            var cvEntities = _cvRepository.GetAllCVs();
            var result = _cvMapper.EntitiesToDtos(cvEntities);
            return new GetAllCVsResponse()
            {
                Cvs = result
            };
        }
    }
}
