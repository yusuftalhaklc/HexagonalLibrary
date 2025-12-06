using Library.Application.DTOs.CategoryDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.CategoryDTOs.Queries
{
    public class GetCategoryByIdQuery : IRequest<CategoryQueryResult>
    {
        public int Id { get; set; }
    }
}

