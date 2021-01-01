using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common
{
    public interface IRequestWrapper<T> : IRequest<Response<T>> {}

    public interface IRequestHandlerWrapper<Tin, TOut> : IRequestHandler<Tin, Response<TOut>>
     where Tin : IRequestWrapper<TOut>  { }
}
