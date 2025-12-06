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
    public class UpdateTagUseCase : IUpdateTagUseCase
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public UpdateTagUseCase(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<TagQueryResult> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByIdAsync(request.Id);
            if (tag == null)
            {
                throw new Exception($"Tag with Id {request.Id} not found.");
            }

            tag.Name = request.Name;
            
            await _tagRepository.UpdateAsync(tag);
            return _mapper.Map<TagQueryResult>(tag);
        }
    }
}

