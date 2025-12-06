using AutoMapper;
using Library.Application.DTOs.CategoryDTOs.Queries;
using Library.Application.DTOs.CategoryDTOs.Results;
using Library.Application.PrimaryPorts.CategoryPorts;
using Library.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.UseCases.CategoryUseCases.Read
{
    public class GetAllCategoriesUseCase : IGetAllCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllCategoriesUseCase(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryQueryResult>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetAllAsync();
            return _mapper.Map<List<CategoryQueryResult>>(categories);
        }
    }
}

