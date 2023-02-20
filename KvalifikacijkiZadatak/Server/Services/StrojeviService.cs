using KvalifikacijkiZadatak.Server.Data;
using KvalifikacijkiZadatak.Shared;
using Microsoft.EntityFrameworkCore;

namespace KvalifikacijkiZadatak.Server.Services
{
    public class StrojeviService : IStrojeviService
    {
        private readonly DataContext _context;

        public StrojeviService(DataContext context)
        {
            _context = context;
        }

        public async Task<Strojevi> CreateStroj(Strojevi strojevi)
        {
            _context.Add(strojevi);
            await _context.SaveChangesAsync();
            return strojevi;
        }

        public async Task<bool> DeleteStroj(int Id)
        {
            var dbStrojevi = await _context.Strojevis.FindAsync(Id);
            if (dbStrojevi == null)
            {
                return false;
            }

            _context.Remove(dbStrojevi);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Strojevi?> GetStrojById(int Id)
        {
            var dbStrojevi = await _context.Strojevis.FindAsync(Id);
            return dbStrojevi;
        }

        public async Task<List<Strojevi>> GetStrojeve()
        {
            return await _context.Strojevis.ToListAsync();
        }

        public async Task<Strojevi?> UpdateStroj(int Id, Strojevi strojevi)
        {
            var dbStrojevi = await _context.Strojevis.FindAsync(Id);
            if (dbStrojevi != null)
            {
                dbStrojevi.Ime = strojevi.Ime;
               
                await _context.SaveChangesAsync();
            }

            return dbStrojevi;
        }
    }
}
