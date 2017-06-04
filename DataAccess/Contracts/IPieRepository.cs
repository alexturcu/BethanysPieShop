using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PiesOfWeek { get; }
        Pie GetPieById(int pieId);
    }
}
