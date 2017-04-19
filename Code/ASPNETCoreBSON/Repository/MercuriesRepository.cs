using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using ASPNETCoreBSON.Contexts;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    public class MercuriesRepository : IMercuriesRepository
    {
        private readonly MercuriesContext _context = null;

        public MercuriesRepository(IOptions<Settings> settings)
        {
            _context = new MercuriesContext(settings);
        }

        public async Task Add(Mercury mercuryEntry)
        {
            await _context.Mercuries.InsertOneAsync(mercuryEntry);
        }

        public async Task<IEnumerable<Mercury>> GetAll()
        {
            return await _context.Mercuries.Find(_ => true).ToListAsync();
        }

        public async Task<Mercury> Find(string id)
        {
            var filter = Builders<Mercury>.Filter.Eq("_id", id);
            return await _context.Mercuries.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Mercuries.DeleteOneAsync(Builders<Mercury>.Filter.Eq("_id", id));
        }

        public async Task<UpdateResult> Update(Mercury mercuryEntry)
        {
            //in reality this is the closest case study I would imagine:
            //filter by the time it was taken
            var filter = Builders<Mercury>.Filter.Eq(x => x.DateTimeStart, mercuryEntry.DateTimeStart);
            //update or correct the measurements
            var update = Builders<Mercury>.Update.Set(x => x.Hg, mercuryEntry.Hg);

            return await _context.Mercuries.UpdateOneAsync(filter, update);
        }
    }
}
