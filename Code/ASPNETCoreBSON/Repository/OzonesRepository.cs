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
    public class OzonesRepository: IOzonesRepository
    {
        private readonly OzonesContext _context = null;

        public OzonesRepository(IOptions<Settings> settings)
        {
            _context = new OzonesContext(settings);
        }

        public async Task Add(Ozone ozoneEntry)
        {
            try
            {
                await _context.Ozones.InsertOneAsync(ozoneEntry);
            }
            catch (Exception e)
            {
                
                throw new Exception("Error during adding Ozone using MongoDB\n" + e.Message);
            }
            
        }

        public async Task<IEnumerable<Ozone>> GetAll()
        {
            try
            {
                return await _context.Ozones.Find(_ => true).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error during getting Ozone using MongoDB\n" + e.Message);
            }
           
        }

        public async Task<Ozone> Find(string id)
        {
            var filter = Builders<Ozone>.Filter.Eq("_id", id);
            try
            {
                return await _context.Ozones.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error during finding Ozone using MongoDB\n" +e.Message);
            }
            
        }

        public async Task<DeleteResult> Remove(string id)
        {
            try
            {
                return await _context.Ozones.DeleteOneAsync(Builders<Ozone>.Filter.Eq("_id", id));
            }
            catch (Exception e)
            {
                throw new Exception("Error during removing Ozone using MongoDB\n" + e.Message);
            }
            
        }

        public async Task<UpdateResult> Update(Ozone ozoneEntry)
        {
            //in reality this is the closest case study I would imagine:
            //filter by the time it was taken
            var filter = Builders<Ozone>.Filter.Eq(x => x.DateTimeStart, ozoneEntry.DateTimeStart);
            //update or correct measurements
            var update = Builders<Ozone>.Update.Set(x => x.Ozone1, ozoneEntry.Ozone1);

            try
            {
                return await _context.Ozones.UpdateOneAsync(filter, update);
            }
            catch (Exception e)
            {
                throw new Exception("Error during updating Ozone using MongoDB\n" + e.Message);
            }

            
        }
    }
}
