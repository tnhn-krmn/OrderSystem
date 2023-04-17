using Microsoft.EntityFrameworkCore;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Context
{
    public class OrderSystemContext : DbContext
    {
        public OrderSystemContext(DbContextOptions<OrderSystemContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<CarrierConfiguration> CarrierConfigurations { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<CarrierReport> CarrierReports { get; set; }

    }
}
