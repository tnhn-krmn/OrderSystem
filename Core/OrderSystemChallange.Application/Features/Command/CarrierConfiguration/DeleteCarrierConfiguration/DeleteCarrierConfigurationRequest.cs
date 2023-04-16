using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.CarrierConfiguration.DeleteCarrierConfiguration
{
    public class DeleteCarrierConfigurationRequest : IRequest<DeleteCarrierConfigurationResponse>
    {
        public int Id { get; set; }
    }
}
