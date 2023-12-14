using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;

namespace Aplikacja.Views
{
    public class Database
    {
        readonly SQLiteAsyncConnection _db;

        public Database(string dbpath)
        {
            _db = new SQLiteAsyncConnection(dbpath);
            _db.CreateTableAsync<Wydatek>().Wait();
        }
        public Task<List<Wydatek>> GetAll()
        {
            return _db.Table<Wydatek>().ToListAsync();
        }
        public Task<int> Add(Wydatek wydatek)
        {
           return  _db.InsertAsync(wydatek);
        }
    }
}
