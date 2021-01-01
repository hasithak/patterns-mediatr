using MediatR;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Tickets.Quries
{
    public class GetAllTicketsQuery : IRequest<IEnumerable<Ticket>>
    {
    }

    public class GetAllTicketsQueryHandler : IRequestHandler<GetAllTicketsQuery, IEnumerable<Ticket>>
    {
        private readonly AppDbContext appDbContext;

        public GetAllTicketsQueryHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Ticket>> Handle(GetAllTicketsQuery request, CancellationToken cancellationToken)
        {
            return appDbContext.Tickets.ToList();
        }
    }
}
