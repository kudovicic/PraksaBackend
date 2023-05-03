using System;
namespace api_praksa.Controllers.Models
{
	public class Post
	{
		public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;

        public Post()
		{
		}
	}
}

