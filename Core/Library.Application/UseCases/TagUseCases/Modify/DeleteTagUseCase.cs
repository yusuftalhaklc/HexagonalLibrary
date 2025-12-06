using Library.Application.DTOs.TagDTOs.Commands;
using Library.Application.PrimaryPorts.TagPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.TagUseCases.Modify
{
    public class DeleteTagUseCase : IDeleteTagUseCase
    {
        private readonly ITagRepository _tagRepository;

        public DeleteTagUseCase(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<bool> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByIdAsync(request.Id);
            if (tag == null)
            {
                return false;
            }

            await _tagRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}

