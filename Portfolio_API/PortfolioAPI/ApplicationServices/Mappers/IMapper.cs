using System.Collections.Generic;

namespace ApplicationServices.Mappers
{
    public interface IMapper<TEntity, TDto>
    {
        TDto EntityToDto(TEntity entity);
        IEnumerable<TDto> EntitiesToDtos(IEnumerable<TEntity> entities);
    }
}
