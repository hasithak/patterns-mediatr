using MediatR;
using Service.Common;
using Service.Models;
using Service.Tickets.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Tickets.Commands
{
    public class AddTicketCommand : BaseRequest, IRequestWrapper<Ticket>   {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Seat { get; set; }
    }

    public class AddTicketCommandHandler : IRequestHandlerWrapper<AddTicketCommand, Ticket>
    {
        private readonly AppDbContext dbContext;

        public AddTicketCommandHandler(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Response<Ticket>> Handle(AddTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = new Ticket()
            {
                Amount = request.Amount,
                Seat = request.Seat,
                UserId = request.UserId
            };

            dbContext.Tickets.Add(ticket);
            dbContext.SaveChanges();

            return Task.FromResult(Response.Ok<Ticket>(ticket, "creatd"));
        }
    }
}
