using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlitos_App.Conexion
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CarlosAtributos>().Wait();
        }
        public Task<List<CarlosAtributos>> GetOrder()
        {
            return _database.Table<CarlosAtributos>().ToListAsync();
        }
        public Task<int> SaveProduct(CarlosAtributos product)
        {
            return _database.InsertAsync(product);
        }
        public Task<int> DeleteProduct(CarlosAtributos product)
        {
            return _database.DeleteAsync(product);
        }
        public Task<int> DeleteAll()
        {
            return _database.DeleteAllAsync<CarlosAtributos>();
        }
        public Task<CarlosAtributos> GetComboID(int id)
        {
            return _database.Table<CarlosAtributos>().Where(a => a.ID == id).FirstOrDefaultAsync();
        }
    }
}
