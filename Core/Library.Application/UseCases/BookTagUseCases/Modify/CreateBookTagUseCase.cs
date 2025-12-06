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
    public class CreateBookTagUseCase : ICreateBookTagUseCase
    {
        private readonly IBookTagRepository _bookTagRepository;
        private readonly IMapper _mapper;

        public CreateBookTagUseCase(IBookTagRepository bookTagRepository, IMapper mapper)
        {
            _bookTagRepository = bookTagRepository;
            _mapper = mapper;
        }

        public async Task<BookTagQueryResult> Handle(CreateBookTagCommand request, CancellationToken cancellationToken)
        {
            var bookTag = _mapper.Map<BookTag>(request);
            await _bookTagRepository.CreateAsync(bookTag);
            return _mapper.Map<BookTagQueryResult>(bookTag);
        }
    }
}

