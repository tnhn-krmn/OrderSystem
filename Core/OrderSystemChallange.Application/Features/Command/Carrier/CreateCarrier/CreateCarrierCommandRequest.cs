using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Carrier.CreateCarrier
{
    public class CreateCarrierCommandRequest : IRequest<CreateCarrierCommandResponse>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int PlusDesiCost { get; set; }
    }
}
