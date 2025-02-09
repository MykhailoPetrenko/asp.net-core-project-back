﻿using Party.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Party.Core
{
    public class PartyServices: IPartyService
    {
        private readonly AppDbContext _context;
        public PartyServices(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Wydarzenie> GetWydarzenia()
        {
            return _context.Wydarzenies.Include(t => t.Tworca).ToList();
        }

        public Wydarzenie GetUczestnikiWydarzenia(int wydarzenie)
        {

            var first = _context.Wydarzenies.Where(w => w.IdWydarzenie == wydarzenie)
                .Include(uw => uw.UczestnikWydarzenie) 
                .ThenInclude(u => u.Uczestnik)
                .FirstOrDefault();
            
            /*var second =_context.UczestnikWydarzenie
                .Where(uw => uw.IdWydarzenie == wydarzenie)
                .Select(s => s.Uczestnik)
                .ToList();*/
            return first;
        }
        public IEnumerable<Wydarzenie> GetWydarzeniaByDate(DateTime data)
        {
            return _context.Wydarzenies.Where(w => w.DataPrzeprowadzenia == data).ToList();
        }
        public async Task<Wydarzenie> CreateWydarzenie(Wydarzenie wydarzenie, string userId)
        {
            var tworca = _context.Tworca.FirstOrDefault(t => t.IdOsoba == userId);
            wydarzenie.Tworca = tworca;
            _context.Wydarzenies.Add(wydarzenie);
            await _context.SaveChangesAsync();
            return wydarzenie;
        }
    }
}
