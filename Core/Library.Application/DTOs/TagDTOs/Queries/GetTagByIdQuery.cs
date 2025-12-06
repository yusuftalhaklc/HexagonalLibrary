using Library.Application.DTOs.TagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.TagDTOs.Queries
{
    public class GetTagByIdQuery : IRequest<TagQueryResult>
    {
        public int Id { get; set; }
    }
}

