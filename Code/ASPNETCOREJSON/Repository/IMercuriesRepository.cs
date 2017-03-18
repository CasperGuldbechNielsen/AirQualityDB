﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCOREJSON.Models;

namespace ASPNETCOREJSON.Repository
{
    public interface IMercuriesRepository
    {
        void Add(Mercury mercuryEntry);
        IEnumerable<Mercury> GetAll();
        Mercury Find(string id);
        void Remove(string id);
        void Update(Mercury mercuryEntry);
    }
}
