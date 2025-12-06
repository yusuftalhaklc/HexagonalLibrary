using Library.Application.DTOs.BookTagDTOs.Commands;
using Library.Application.DTOs.BookTagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.PrimaryPorts.BookTagPorts
{
    public interface IUpdateBookTagUseCase : IRequestHandler<UpdateBookTagCommand, BookTagQueryResult>
    {
    }
}

