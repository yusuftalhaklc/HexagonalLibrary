using Library.Application.DTOs.Tag.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Tag.Queries
{
    public class GetAllTagsQuery : IRequest<List<TagQueryResult>>
    {
    }
}

