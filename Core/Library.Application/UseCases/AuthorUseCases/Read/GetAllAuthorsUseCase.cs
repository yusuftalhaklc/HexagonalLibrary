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
    public class GetAllAuthorsUseCase : IGetAllAuthorsUseCase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public GetAllAuthorsUseCase(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<List<AuthorQueryResult>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var authors = await _authorRepository.GetAllAsync();
            return _mapper.Map<List<AuthorQueryResult>>(authors);
        }
    }
}

