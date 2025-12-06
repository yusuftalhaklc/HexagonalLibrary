using Library.Application.DTOs.Category.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Category.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryQueryResult>>
    {
    }
}

