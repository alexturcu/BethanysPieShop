using System.Collections.Generic;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Linq;

namespace DataAccess.Infrastructure
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopContext _context;

        public PieRepository(BethanysPieShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> Pies => _context.Pies.AsEnumerable();

        public IEnumerable<Pie> PiesOfWeek => _context.Pies.Where(p => p.IsPieOfTheWeek);

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
