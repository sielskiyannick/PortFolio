using System.Collections.Generic;
using System.Linq;
using Entity = Domain.Entities;
using Dto = Contracts.DTOs;

namespace ApplicationServices.Mappers
{
    public class CVMapper : IMapper<Entity.CV, Dto.CV>
    {
        private readonly IMapper<Entity.CVEntry, Dto.CVEntry> _cvEntryMapper;

        public CVMapper(IMapper<Entity.CVEntry, Dto.CVEntry> cvEntryMapper)
        {
            _cvEntryMapper = cvEntryMapper;
        }

        public Dto.CV EntityToDto(Entity.CV entity)
        {

            return new Dto.CV()
            {
                CVEntryIds = (from entry in entity.CVEntries
                             select entry.Id).ToList(),
            };
        }

        public IEnumerable<Dto.CV> EntitiesToDtos(IEnumerable<Entity.CV> entities)
        {
            var result = new List<Dto.CV>();
            foreach (var entity in entities)
            {
                result.Add(EntityToDto(entity));
            }
            return result;
        }
    }
}
