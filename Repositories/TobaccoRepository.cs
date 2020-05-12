using System;
using System.Collections.Generic;
using Tobacco_Shop.Models;
using Tobacco_Shop.Context;
using Tobacco_Shop.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Tobacco_Shop.Repositories
{
    public class TobaccoRepository : ITobaccoRepository
    {
        private readonly AppDbContext _context;
        public TobaccoRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Tobacco> Tobaccos => _context.Tobaccos.Include(c => c.Category);

        public IEnumerable<Tobacco> BestTobacco => _context.Tobaccos.Where(p => 
        p.IsTobaccoBest).Include(c => c.Category);

        public Tobacco GetTobaccoById(int tobaccoId)
        {
            return _context.Tobaccos.FirstOrDefault(l => l.TobaccoId == tobaccoId);
        }
    }
}