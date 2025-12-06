using AutoMapper;
using Library.Application.DTOs.BookTagDTOs.Commands;
using Library.Application.DTOs.BookTagDTOs.Results;
using Library.Application.PrimaryPorts.BookTagPorts;
using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookTagUseCases.Modify
{
    public class UpdateBookTagUseCase : IUpdateBookTagUseCase
    {
        private readonly IBookTagRepository _bookTagRepository;
        private readonly IMapper _mapper;

        public UpdateBookTagUseCase(IBookTagRepository bookTagRepository, IMapper mapper)
        {
            _bookTagRepository = bookTagRepository;
            _mapper = mapper;
        }

        public async Task<BookTagQueryResult> Handle(UpdateBookTagCommand request, CancellationToken cancellationToken)
        {
            var bookTag = await _bookTagRepository.GetByIdAsync(request.Id);
            if (bookTag == null)
            {
                throw new Exception($"BookTag with Id {request.Id} not found.");
            }

            bookTag.BookId = request.BookId;
            bookTag.TagId = request.TagId;
            
            await _bookTagRepository.UpdateAsync(bookTag);
            return _mapper.Map<BookTagQueryResult>(bookTag);
        }
    }
}

