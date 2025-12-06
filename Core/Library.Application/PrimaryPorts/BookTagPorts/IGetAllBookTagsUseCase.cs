using Library.Application.DTOs.BookTagDTOs.Queries;
using Library.Application.DTOs.BookTagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.BookTagPorts
{
    public interface IGetAllBookTagsUseCase : IRequestHandler<GetAllBookTagsQuery, List<BookTagQueryResult>>
    {
    }
}

