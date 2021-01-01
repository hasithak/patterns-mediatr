using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common;
using Service.Models;
using Service.Tickets.Commands;
using Service.Tickets.Quries;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        public TicketsController(IMediator mediator)
        {
            Mediator = mediator;
        }

        public IMediator Mediator { get; }


        public async Task<IEnumerable<Ticket>> Get()
        {
            return await Mediator.Send(new GetAllTicketsQuery());
        }

        [HttpPost]
        public async Task<Response<Ticket>> Add(AddTicketCommand ticketCommand) 
        {
            return await Mediator.Send(ticketCommand);
        }

    }
}
