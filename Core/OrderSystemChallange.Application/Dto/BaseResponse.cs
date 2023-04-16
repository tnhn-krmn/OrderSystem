using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto
{
    public class BaseResponse
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
