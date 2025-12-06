using Library.Application.DTOs.BookDTOs.Queries;
using Library.Application.DTOs.BookDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.BookPorts
{
    public interface IGetAllBooksUseCase : IRequestHandler<GetAllBooksQuery, List<BookQueryResult>>
    {
    }
}

