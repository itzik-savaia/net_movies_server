//using MongoDB.Bson;
//using MongoDB.Bson.Serialization.Attributes;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace SearchMovieServer.Models
//{
//    public class Accounts
//    {
//        [BsonId]
//        [BsonRepresentation(BsonType.ObjectId)]
//        public string Id { get; set; }
//        public string Address { get; set; }
//        public string State { get; set; }
//        public DateTime Registration_Date { get; }
//        public DateTime Last_Entry_Date { get; set; }
//        public Boolean Is_Login { get; set; }
//        public string Phone { get; set; }
//        public string Email { get; set; }
//        public string Role { get; set; }
//        public string Token { get; set; }

//        [JsonIgnore]
//        public string Password { get; set; }

//        public Accounts(Accounts accounts, string token)
//        {
//            this.Registration_Date = DateTime.Now;
//            this.Id = accounts.Id;
//            this.First_Name = accounts.First_Name;
//            this.Last_Name = accounts.Last_Name;
//            this.Username = accounts.Username;
//            this.Address = accounts.Address;
//            this.State = accounts.State;
//            this.Last_Entry_Date = accounts.Last_Entry_Date;
//            this.Phone = accounts.Phone;
//            this.Email = accounts.Email;
//            this.Role = accounts.Role;
//            this.Token = token;
//        }
//    }
//}
