using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.CrossCutting.Commons.AppServices.Contracts.RequestResponse
{
    public class ResponseMessage
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object[] Errors { get; set; }
        public int TotalRows { get; set; }
        public int StatusCode { get; set; }
    }

    public class ResponseMessage<TResponse> : ResponseMessage
        where TResponse : class
    {
        public ResponseMessage()
        {

        }

        public ResponseMessage(TResponse data)
        {
            Data = data;
        }

        public TResponse Data { get; set; }

    }
}
