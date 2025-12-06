using Library.Application.DTOs.TagDTOs.Queries;
using Library.Application.DTOs.TagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.TagPorts
{
    public interface IGetTagByIdUseCase : IRequestHandler<GetTagByIdQuery, TagQueryResult>
    {
    }
}

