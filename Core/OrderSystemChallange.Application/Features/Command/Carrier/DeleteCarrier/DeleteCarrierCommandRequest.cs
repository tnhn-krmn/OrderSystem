using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Carrier.DeleteCarrier
{
    public class DeleteCarrierCommandRequest : IRequest<DeleteCarrierCommandResponse>
    {
        public int Id { get; set; }
    }
}
