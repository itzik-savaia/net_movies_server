//using MongoDB.Driver;
//using SearchMovieServer.Models;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace SearchMovieServer.Service
//{
//    public class AccountService
//    {
//        private readonly IMongoCollection<Accounts> _accounts;

//        public AccountService(ISearchMoivesDatabaseSettings settings)
//        {
//            var client = new MongoClient(settings.ConnectionString);
//            var database = client.GetDatabase(settings.DatabaseName);
//            _accounts = database.GetCollection<Accounts>(settings.AccountsCollectionName);
//        }

//        public async Task<List<Accounts>> GetAllAsync()
//        {
//            var accounts = await _accounts.Find(s => true).ToListAsync();
//            if (accounts == null) return accounts;
//            return accounts;
//        }

        //public async Task<Student> GetByIdAsync(string id)
        //{
        //    return await _students.Find<Student>(s => s.Id == id).FirstOrDefaultAsync();
        //}

        //public async Task<Student> CreateAsync(Student student)
        //{
        //    await _students.InsertOneAsync(student);
        //    return student;
        //}

        //public async Task UpdateAsync(string id, Student student)
        //{
        //    await _students.ReplaceOneAsync(s => s.Id == id, student);
        //}

        //public async Task DeleteAsync(string id)
        //{
        //    await _students.DeleteOneAsync(s => s.Id == id);
        //}
//    }
//}

