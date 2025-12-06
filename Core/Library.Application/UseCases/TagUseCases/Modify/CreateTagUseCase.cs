using AutoMapper;
using Library.Application.DTOs.TagDTOs.Commands;
using Library.Application.DTOs.TagDTOs.Results;
using Library.Application.PrimaryPorts.TagPorts;
using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.TagUseCases.Modify
{
    public class CreateTagUseCase : ICreateTagUseCase
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public CreateTagUseCase(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<TagQueryResult> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = _mapper.Map<Tag>(request);
            await _tagRepository.CreateAsync(tag);
            return _mapper.Map<TagQueryResult>(tag);
        }
    }
}

