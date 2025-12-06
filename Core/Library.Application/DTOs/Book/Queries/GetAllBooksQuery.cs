using Library.Application.DTOs.Book.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Book.Queries
{
    public class GetAllBooksQuery : IRequest<List<BookQueryResult>>
    {
    }
}

