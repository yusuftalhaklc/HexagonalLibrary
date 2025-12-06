using Library.Application.DTOs.Category.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Category.Commands
{
    public class UpdateCategoryCommand : IRequest<CategoryQueryResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

