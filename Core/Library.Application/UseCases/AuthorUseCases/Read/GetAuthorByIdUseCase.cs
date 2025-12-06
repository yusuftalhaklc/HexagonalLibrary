using AutoMapper;
using Library.Application.DTOs.AuthorDTOs.Queries;
using Library.Application.DTOs.AuthorDTOs.Results;
using Library.Application.PrimaryPorts.AuthorPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.AuthorUseCases.Read
{
    public class GetAuthorByIdUseCase : IGetAuthorByIdUseCase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public GetAuthorByIdUseCase(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<AuthorQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.Id);
            if (author == null)
            {
                throw new Exception($"Author with Id {request.Id} not found.");
            }

            return _mapper.Map<AuthorQueryResult>(author);
        }
    }
}

