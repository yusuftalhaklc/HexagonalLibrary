using AutoMapper;
using Library.Application.DTOs.BookDTOs.Queries;
using Library.Application.DTOs.BookDTOs.Results;
using Library.Application.PrimaryPorts.BookPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookUseCases.Read
{
    public class GetAllBooksUseCase : IGetAllBooksUseCase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetAllBooksUseCase(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookQueryResult>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllAsync();
            return _mapper.Map<List<BookQueryResult>>(books);
        }
    }
}

