using Library.Application.DTOs.CategoryDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.CategoryDTOs.Commands
{
    public class CreateCategoryCommand : IRequest<CategoryQueryResult>
    {
        public string Name { get; set; }
    }
}

