using AutoMapper;
using Library.Application.DTOs.TagDTOs.Queries;
using Library.Application.DTOs.TagDTOs.Results;
using Library.Application.PrimaryPorts.TagPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.TagUseCases.Read
{
    public class GetAllTagsUseCase : IGetAllTagsUseCase
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public GetAllTagsUseCase(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<List<TagQueryResult>> Handle(GetAllTagsQuery request, CancellationToken cancellationToken)
        {
            var tags = await _tagRepository.GetAllAsync();
            return _mapper.Map<List<TagQueryResult>>(tags);
        }
    }
}

