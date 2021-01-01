using MediatR;
using Service.Tickets.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Service.Infastructure.Pipes
{
    public class UserIdPipe<Tin, TOut> : IPipelineBehavior<Tin, TOut>
    {
        public System.Threading.Tasks.Task<TOut> Handle(Tin request, CancellationToken cancellationToken, RequestHandlerDelegate<TOut> next)
        {

            if(request is BaseRequest br)
            {
                br.UserId = "id from http context";
            }

            return next();
        }
    }
}
