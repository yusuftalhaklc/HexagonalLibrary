using Library.Application.DTOs.AuthorDTOs.Queries;
using Library.Application.DTOs.AuthorDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.AuthorPorts
{
    public interface IGetAllAuthorsUseCase : IRequestHandler<GetAllAuthorsQuery, List<AuthorQueryResult>>
    {
    }
}

