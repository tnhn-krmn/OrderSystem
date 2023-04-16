using Microsoft.EntityFrameworkCore;
using OrderSystemChallange.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Repositories
{
    public interface IRepository<T, TKey> where T : BaseEntity<TKey>
    {
        DbSet<T> Table { get; }
    }
}
