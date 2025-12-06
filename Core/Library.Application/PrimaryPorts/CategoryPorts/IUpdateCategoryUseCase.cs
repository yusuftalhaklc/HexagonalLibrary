using Library.Application.DTOs.CategoryDTOs.Commands;
using Library.Application.DTOs.CategoryDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.CategoryPorts
{
    public interface IUpdateCategoryUseCase : IRequestHandler<UpdateCategoryCommand, CategoryQueryResult>
    {
    }
}

