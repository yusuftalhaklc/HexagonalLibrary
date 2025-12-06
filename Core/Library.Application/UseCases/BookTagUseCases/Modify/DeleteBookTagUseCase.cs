using Library.Application.DTOs.BookTagDTOs.Commands;
using Library.Application.PrimaryPorts.BookTagPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookTagUseCases.Modify
{
    public class DeleteBookTagUseCase : IDeleteBookTagUseCase
    {
        private readonly IBookTagRepository _bookTagRepository;

        public DeleteBookTagUseCase(IBookTagRepository bookTagRepository)
        {
            _bookTagRepository = bookTagRepository;
        }

        public async Task<bool> Handle(DeleteBookTagCommand request, CancellationToken cancellationToken)
        {
            var bookTag = await _bookTagRepository.GetByIdAsync(request.Id);
            if (bookTag == null)
            {
                return false;
            }

            await _bookTagRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}

