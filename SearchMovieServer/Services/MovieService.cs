using MongoDB.Bson;
using MongoDB.Driver;
using SearchMovieServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Dynamic;

namespace SearchMovieServer.Service
{
    public class MovieService
    {
        private readonly IMongoCollection<Movies> _movies;
        private readonly IMongoCollection<Categorys> _categorys;

        public MovieService(ISearchMoivesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _movies = database.GetCollection<Movies>(settings.MoviesCollectionName);
            _categorys = database.GetCollection<Categorys>(settings.CategorysCollectionName);
        }

        public async Task<List<Movies>> GetAllAsync()
        {
            var movies = await _movies.Find(m => true).ToListAsync();
            if (movies.Count != 0)
                return movies;
            else return movies;
        }

        public async Task<List<Categorys>> GetAllCategorysAsync()
        {
            List<Categorys> categorys = new List<Categorys>();
                
            var terrors = new List<Movies>();
            var seriess = new List<Movies>();
            var for_childern_and_the_whole_family = new List<Movies>();
            var crimes = new List<Movies>();
            var science_fintion_and_fantasys = new List<Movies>();
            var comedies = new List<Movies>();
            var romanticisms = new List<Movies>();
            var sports = new List<Movies>();
            var actions = new List<Movies>();
            var stand_up_shows = new List<Movies>();
            var thrillers = new List<Movies>();
            var fantasys = new List<Movies>();
            var sci_Fis = new List<Movies>();
            var drama = new List<Movies>();
            var mystery = new List<Movies>();
            var music = new List<Movies>();
            var adventure = new List<Movies>();
            var animation = new List<Movies>();
            var movies = _movies.Find(m => true).ToList();

            void ArrangementByCategorys()
            {
                if (movies.Count != 0)
                {
                    foreach (var movie in movies)
                    {
                        foreach (var movie_Type in movie.Types)
                        {
                            if (movie_Type == "Terror")
                                terrors.Add(movie);

                            if (movie_Type == "Series")
                                seriess.Add(movie);

                            if (movie_Type == "For Childern And The Whole Family" || movie_Type == "Family")
                                for_childern_and_the_whole_family.Add(movie);

                            if (movie_Type == "Crime")
                                crimes.Add(movie);

                            if (movie_Type == "Science Fintion And Fantasy")
                                science_fintion_and_fantasys.Add(movie);

                            if (movie_Type == "Comedies" || movie_Type == "Comedy")
                                comedies.Add(movie);

                            if (movie_Type == "Romanticism")
                                romanticisms.Add(movie);

                            if (movie_Type == "Sport")
                                sports.Add(movie);

                            if (movie_Type == "Action")
                                actions.Add(movie);

                            if (movie_Type == "Stand_Up_Show")
                                stand_up_shows.Add(movie);
                            
                            if (movie_Type == "Thriller")
                                thrillers.Add(movie);
                            
                            if (movie_Type == "Fantasy")
                                fantasys.Add(movie);
                            
                            if (movie_Type == "Sci_Fi")
                                sci_Fis.Add(movie);
                            
                            if (movie_Type == "Drama")
                                drama.Add(movie);
                            
                            if (movie_Type == "Music")
                                music.Add(movie);
                            
                            if (movie_Type == "Adventure")
                                adventure.Add(movie);
                            
                            if (movie_Type == "Animation")
                                animation.Add(movie);
                            
                        }
                    }
                }
            }
            ArrangementByCategorys();
       
            categorys.Add(new Categorys
            {
                Terror = terrors,
                Series = seriess,
                For_Childern_And_The_Whole_Family = for_childern_and_the_whole_family,
                Crime = crimes,
                Science_Fintion_And_Fantasy = science_fintion_and_fantasys,
                Comedies = comedies,
                Romanticism = romanticisms,
                Sport = sports,
                Action = actions,
                Stand_Up_Show = stand_up_shows,
                Thriller = thrillers,
                Fantasy = fantasys,
                Sci_Fi = sci_Fis,
                Drama = drama,
                Mystery = mystery,
                Music = music,
                Adventure = adventure,
                Animation = animation,
            });
            await _categorys.InsertManyAsync(categorys);
            
            return categorys;
        }


        public async Task<Movies> GetByIdAsync(string id)
        {
            return await _movies.Find<Movies>(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Movies> CreateAsync(Movies movies)
        {
            await _movies.InsertOneAsync(movies);
            return movies;
        }

        public async Task<Movies> UpdateAsync(string id, Movies movies)
        {
            var get_movie = await GetByIdAsync(id);
            if (get_movie == null)
                return null;

            //var replace = await _movies.ReplaceOneAsync(w => w.Id == getMovie.Id, movies, new UpdateOptions { IsUpsert = true });
            var filter = Builders<Movies>.Filter.Eq(f => f.Id, get_movie.Id);

                var update = Builders<Movies>.Update
                .Set(s => s.Name, movies.Name)
                .Set(s => s.Text, movies.Text)
                .Set(s => s.Publishing_Year, movies.Publishing_Year)
                .Set(s => s.Minutes, movies.Minutes)
                .Set(s => s.Types, movies.Types)
                .Set(s => s.Language, movies.Language)
                .Set(s => s.Trailers, movies.Trailers)
                .Set(s => s.Photos, movies.Photos);

                var result = await _movies.UpdateOneAsync(filter, update);
            

           
            return movies;
        }

        public async Task DeleteAsync(string name)
        {
            await _movies.DeleteOneAsync(m => m.Name == name);
        }
    }
}
