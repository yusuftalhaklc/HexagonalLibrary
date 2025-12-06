using AutoMapper;
using Library.Application.DTOs.BookTagDTOs.Queries;
using Library.Application.DTOs.BookTagDTOs.Results;
using Library.Application.PrimaryPorts.BookTagPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.BookTagUseCases.Read
{
    public class GetBookTagByIdUseCase : IGetBookTagByIdUseCase
    {
        private readonly IBookTagRepository _bookTagRepository;
        private readonly IMapper _mapper;

        public GetBookTagByIdUseCase(IBookTagRepository bookTagRepository, IMapper mapper)
        {
            _bookTagRepository = bookTagRepository;
            _mapper = mapper;
        }

        public async Task<BookTagQueryResult> Handle(GetBookTagByIdQuery request, CancellationToken cancellationToken)
        {
            var bookTag = await _bookTagRepository.GetByIdAsync(request.Id);
            if (bookTag == null)
            {
                throw new Exception($"BookTag with Id {request.Id} not found.");
            }

            return _mapper.Map<BookTagQueryResult>(bookTag);
        }
    }
}

