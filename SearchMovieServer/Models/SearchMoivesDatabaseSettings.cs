using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchMovieServer.Models
{
    public class SearchMoivesDatabaseSettings : ISearchMoivesDatabaseSettings
    {
        public string AccountsCollectionName { get; set; }
        public string MoviesCollectionName { get; set; }
        public string CategorysCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISearchMoivesDatabaseSettings
    {
        public string AccountsCollectionName { get; set; }
        public string MoviesCollectionName { get; set; }
        public string CategorysCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

}
