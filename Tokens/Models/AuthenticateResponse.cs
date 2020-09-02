using System;
using WebApi.Entities;

namespace WebApi.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        //public string Address { get; set; } //GPS
        //public string State { get; set; }
        public DateTime Registration_Date { get; }
        public DateTime Last_Entry_Date { get; set; }
        public Boolean Is_Login { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            this.Registration_Date = DateTime.Now;
            Token = token;
        }
    }
}