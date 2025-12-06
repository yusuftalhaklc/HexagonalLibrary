using AutoMapper;
using Library.Application.DTOs.TagDTOs.Queries;
using Library.Application.DTOs.TagDTOs.Results;
using Library.Application.PrimaryPorts.TagPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.TagUseCases.Read
{
    public class GetTagByIdUseCase : IGetTagByIdUseCase
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public GetTagByIdUseCase(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<TagQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByIdAsync(request.Id);
            if (tag == null)
            {
                throw new Exception($"Tag with Id {request.Id} not found.");
            }

            return _mapper.Map<TagQueryResult>(tag);
        }
    }
}

