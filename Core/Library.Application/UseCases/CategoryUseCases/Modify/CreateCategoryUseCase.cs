using AutoMapper;
using Library.Application.DTOs.CategoryDTOs.Commands;
using Library.Application.DTOs.CategoryDTOs.Results;
using Library.Application.PrimaryPorts.CategoryPorts;
using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.CategoryUseCases.Modify
{
    public class CreateCategoryUseCase : ICreateCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryUseCase(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryQueryResult> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            await _categoryRepository.CreateAsync(category);
            return _mapper.Map<CategoryQueryResult>(category);
        }
    }
}

