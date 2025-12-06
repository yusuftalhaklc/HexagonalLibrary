using Library.Application.DTOs.AuthorDTOs.Commands;
using Library.Application.PrimaryPorts.AuthorPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.AuthorUseCases.Modify
{
    public class DeleteAuthorUseCase : IDeleteAuthorUseCase
    {
        private readonly IAuthorRepository _authorRepository;

        public DeleteAuthorUseCase(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<bool> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.Id);
            if (author == null)
            {
                return false;
            }

            await _authorRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}

