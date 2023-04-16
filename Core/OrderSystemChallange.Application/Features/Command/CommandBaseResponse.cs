using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command
{
    public class CommandBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
