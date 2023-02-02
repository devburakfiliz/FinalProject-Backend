using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }  // sadece okumak ıcın
        string Message { get; }

    }
}
