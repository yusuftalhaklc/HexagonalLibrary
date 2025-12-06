using Library.Application.DTOs.BookDTOs.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.BookPorts
{
    public interface IDeleteBookUseCase : IRequestHandler<DeleteBookCommand, bool>
    {
    }
}

