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
    public class UpdateCategoryUseCase : IUpdateCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryUseCase(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryQueryResult> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            if (category == null)
            {
                throw new Exception($"Category with Id {request.Id} not found.");
            }

            category.Name = request.Name;
            
            await _categoryRepository.UpdateAsync(category);
            return _mapper.Map<CategoryQueryResult>(category);
        }
    }
}

