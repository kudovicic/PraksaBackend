using System;
namespace api_praksa.Controllers.Models
{
	public class Register
	{
        public int Id { get; set; }
        public int IdRole { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

