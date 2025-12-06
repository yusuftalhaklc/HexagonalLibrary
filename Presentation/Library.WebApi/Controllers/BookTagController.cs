using Library.Application.DTOs.BookTagDTOs.Commands;
using Library.Application.DTOs.BookTagDTOs.Queries;
using Library.Application.DTOs.BookTagDTOs.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookTagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookTagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookTagQueryResult>>> GetAll()
        {
            var query = new GetAllBookTagsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookTagQueryResult>> GetById(int id)
        {
            var query = new GetBookTagByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<BookTagQueryResult>> Create([FromBody] CreateBookTagCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BookTagQueryResult>> Update(int id, [FromBody] UpdateBookTagCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteBookTagCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

