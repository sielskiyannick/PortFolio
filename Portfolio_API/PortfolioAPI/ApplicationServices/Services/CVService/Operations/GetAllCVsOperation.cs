using ApplicationServices.Mappers;
using ApplicationServices.Services.CVService.Request;
using ApplicationServices.Services.CVService.Response;
using Data.EF.Repositories;
using Entities = Domain.Entities;
using DTOs = Contracts.DTOs;

namespace ApplicationServices.Services.CVService.Operations
{
    public interface IGetAllCVsOperation
    {
        GetAllCVsResponse Execute(GetAllCVsRequest Request);
    }

    public class GetAllCVsOperation: IGetAllCVsOperation
    {
        private readonly ICVRepository _cvRepository;
        private readonly IMapper<Entities.CV, DTOs.CV> _cvMapper;

        public GetAllCVsOperation(ICVRepository cvRepository,
            IMapper<Entities.CV, DTOs.CV> cvMapper)
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
