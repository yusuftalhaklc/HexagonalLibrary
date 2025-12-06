using AutoMapper;
using Library.Application.DTOs.BookDTOs.Commands;
using Library.Application.DTOs.BookDTOs.Results;
using Library.Application.PrimaryPorts.BookPorts;
using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookUseCases.Modify
{
    public class CreateBookUseCase : ICreateBookUseCase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public CreateBookUseCase(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookQueryResult> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);
            await _bookRepository.CreateAsync(book);
            return _mapper.Map<BookQueryResult>(book);
        }
    }
}

