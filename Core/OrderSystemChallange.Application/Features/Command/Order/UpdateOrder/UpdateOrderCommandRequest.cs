using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Order.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public int Id { get; set; }
        public int Desi { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal CarrierCost { get; set; }
        public int CarrieId { get; set; }
    }
}
