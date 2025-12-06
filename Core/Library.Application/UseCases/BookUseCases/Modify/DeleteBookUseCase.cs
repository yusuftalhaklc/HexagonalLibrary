using Library.Application.DTOs.BookDTOs.Commands;
using Library.Application.PrimaryPorts.BookPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookUseCases.Modify
{
    public class DeleteBookUseCase : IDeleteBookUseCase
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookUseCase(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsync(request.Id);
            if (book == null)
            {
                return false;
            }

            await _bookRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}

