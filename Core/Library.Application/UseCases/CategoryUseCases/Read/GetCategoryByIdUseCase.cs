using AutoMapper;
using Library.Application.DTOs.CategoryDTOs.Queries;
using Library.Application.DTOs.CategoryDTOs.Results;
using Library.Application.PrimaryPorts.CategoryPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.CategoryUseCases.Read
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            if (category == null)
            {
                throw new Exception($"Category with Id {request.Id} not found.");
            }

            return _mapper.Map<CategoryQueryResult>(category);
        }
    }
}

