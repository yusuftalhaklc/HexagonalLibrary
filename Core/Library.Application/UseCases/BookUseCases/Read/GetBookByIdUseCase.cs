using AutoMapper;
using Library.Application.DTOs.BookDTOs.Queries;
using Library.Application.DTOs.BookDTOs.Results;
using Library.Application.PrimaryPorts.BookPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookUseCases.Read
{
    public class GetBookByIdUseCase : IGetBookByIdUseCase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookByIdUseCase(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookQueryResult> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsync(request.Id);
            if (book == null)
            {
                throw new Exception($"Book with Id {request.Id} not found.");
            }

            return _mapper.Map<BookQueryResult>(book);
        }
    }
}

