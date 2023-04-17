using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.CarrierReport
{
    public class AddCarrierReportDto
    {
        public int CarrierId { get; set; }
        public decimal Cost { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
