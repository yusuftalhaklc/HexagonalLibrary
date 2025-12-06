using Library.Application.DTOs.AuthorDTOs.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.AuthorPorts
{
    public interface IDeleteAuthorUseCase : IRequestHandler<DeleteAuthorCommand, bool>
    {
    }
}

