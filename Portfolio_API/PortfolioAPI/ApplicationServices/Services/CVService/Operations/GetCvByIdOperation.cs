using ApplicationServices.Mappers;
using ApplicationServices.Services.CVService.Request;
using ApplicationServices.Services.CVService.Response;
using Data.EF.Repositories;
using Entities = Domain.Entities;
using DTOs = Contracts.DTOs;

namespace ApplicationServices.Services.CVService.Operations
{
    public interface IGetCvByIdOperation
    {
        GetCvByIdResponse Execute(GetCvByIdRequest Request);
    }

    public class GetCvByIdOperation : IGetCvByIdOperation
    {
        private readonly ICVRepository _cvRepository;
        private readonly IMapper<Entities.CV, DTOs.CV> _cvMapper;

        public GetCvByIdOperation(ICVRepository cvRepository,
            IMapper<Entities.CV, DTOs.CV> cvMapper)
        {
            _cvRepository = cvRepository;
            _cvMapper = cvMapper;
        }

        public GetCvByIdResponse Execute(GetCvByIdRequest request)
        {
            var cvEntity = _cvRepository.GetById(request.Id);
            var result = _cvMapper.EntityToDto(cvEntity);
            return new GetCvByIdResponse()
            {
                Cv = result,
            };
        }
    }
}
