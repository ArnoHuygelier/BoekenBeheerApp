using BoekenBeheerApp.Services.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenBeheerApp.Services
{
    public class DatabaseSingleton
    {
        protected BoekenDbContext _context;

        public DatabaseSingleton()
        {
            _context = new BoekenDbContext();
        }
    }
}
