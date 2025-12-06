using AutoMapper;
using Library.Application.DTOs.AuthorDTOs.Commands;
using Library.Application.DTOs.AuthorDTOs.Results;
using Library.Application.PrimaryPorts.AuthorPorts;
using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.AuthorUseCases.Modify
{
    public class CreateAuthorUseCase : ICreateAuthorUseCase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public CreateAuthorUseCase(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<AuthorQueryResult> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            await _authorRepository.CreateAsync(author);
            return _mapper.Map<AuthorQueryResult>(author);
        }
    }
}

