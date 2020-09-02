using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SearchMovieServer.Models
{
    public class Categorys
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //[BsonIgnoreIfDefault]
        public List<Movies> Terror { get; set; }
        public List<Movies> Series { get; set; }
        public List<Movies> For_Childern_And_The_Whole_Family { get; set; }
        public List<Movies> Crime { get; set; }
        public List<Movies> Science_Fintion_And_Fantasy { get; set; }
        public List<Movies> Comedies { get; set; }
        public List<Movies> Romanticism { get; set; }
        public List<Movies> Sport { get; set; }
        public List<Movies> Action { get; set; }
        public List<Movies> Stand_Up_Show { get; set; }
        public List<Movies> Thriller { get; set; }
        public List<Movies> Fantasy { get; set; }
        public List<Movies> Sci_Fi { get; set; }
        public List<Movies> Drama { get; set; }
        public List<Movies> Mystery { get; set; }
        public List<Movies> Music { get; set; }
        public List<Movies> Adventure { get; set; }
        public List<Movies> Animation { get; set; }
        //public List<object> Mystery { get; set; }
        //public List<object> Mystery { get; set; }


        public Categorys()
        {

        }
    }
}
