using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SearchMovieServer.Models
{
    public class Movies
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Publishing_Year { get; set; }
        public DateTime Upload_Time { get; }
        public int Minutes { get; set; }
        public List<string> Types { get; set; }
        public string Language { get; set; }
        //public Views Views { get; set; }
        public string Trailers { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public Movies()
        {
            if (Upload_Time == null)
                this.Upload_Time = DateTime.Now;
        }

    }
    public class Photo
    {
        public string Small_Picture { get; set; }
        public string Background { get; set; }
    }
}
