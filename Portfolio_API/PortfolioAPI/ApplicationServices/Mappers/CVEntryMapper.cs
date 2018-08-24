using System.Collections.Generic;
using Entity = Domain.Entities;
using Dto = Contracts.DTOs;

namespace ApplicationServices.Mappers
{
    public class CVEntryMapper: IMapper<Entity.CVEntry,Dto.CVEntry>
    {
        public Dto.CVEntry EntityToDto(Entity.CVEntry entity)
        {
            return new Dto.CVEntry()
            {
                Title = entity.Title,
                CVId = entity.CVId,
            };
        }

        public IEnumerable<Dto.CVEntry> EntitiesToDtos(IEnumerable<Entity.CVEntry> entities)
        {
            var result = new List<Dto.CVEntry>();
            foreach (var entity in entities)
            {
                result.Add(EntityToDto(entity));
            }
            return result;
        }
    }
}
