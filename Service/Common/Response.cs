using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common
{
    public static class Response
    {
        public static Response<T> Fail<T>(string message, T data = default) => 
            new Response<T>(data, message, true);

        public static Response<T> Ok<T>(T data, string message) =>
            new Response<T>(data, message, false);

    }

    public class Response<T> 
    {
        public Response(T data, string msg, bool isError)
        {
            this.Data = data;
            this.Message = msg;
            this.IsError = isError;
        }

        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsError { get; set; }
    }
}
