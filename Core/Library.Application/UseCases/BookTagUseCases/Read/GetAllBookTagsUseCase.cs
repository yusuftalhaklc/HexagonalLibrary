using AutoMapper;
using Library.Application.DTOs.BookTagDTOs.Queries;
using Library.Application.DTOs.BookTagDTOs.Results;
using Library.Application.PrimaryPorts.BookTagPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookTagUseCases.Read
{
    public class GetAllBookTagsUseCase : IGetAllBookTagsUseCase
    {
        private readonly IBookTagRepository _bookTagRepository;
        private readonly IMapper _mapper;

        public GetAllBookTagsUseCase(IBookTagRepository bookTagRepository, IMapper mapper)
        {
            _bookTagRepository = bookTagRepository;
            _mapper = mapper;
        }

        public async Task<List<BookTagQueryResult>> Handle(GetAllBookTagsQuery request, CancellationToken cancellationToken)
        {
            var bookTags = await _bookTagRepository.GetAllAsync();
            return _mapper.Map<List<BookTagQueryResult>>(bookTags);
        }
    }
}

