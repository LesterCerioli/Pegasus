using System;
using System.Collections.Generic;
using System.Text;

namespace MgntEng.Commons.Response
{
    public class ResponseMessage : ICloneable
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

        public virtual object Clone()
        {
            return new ResponseMessage()
            {
                Message = Message,
                StatusCode = StatusCode,
                Success = Success
            };
        }
    }

    public class ResponseMessage<TResponse> : ResponseMessage
    {
        public TResponse Data { get; set; }
        public override object Clone()
        {
            return new ResponseMessage<TResponse>()
            {
                Message = Message,
                StatusCode = StatusCode,

                Success = Success,
                Data = Data is ICloneable ? (TResponse)((ICloneable)Data)?.Clone() : Data

            };
        }
    }
}
