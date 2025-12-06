using Library.Application.DTOs.BookTagDTOs.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.BookTagPorts
{
    public interface IDeleteBookTagUseCase : IRequestHandler<DeleteBookTagCommand, bool>
    {
    }
}

