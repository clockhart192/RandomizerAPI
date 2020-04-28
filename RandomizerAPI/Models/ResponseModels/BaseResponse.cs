using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.ResponseModels
{
    public class BaseResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; }
    }
}
