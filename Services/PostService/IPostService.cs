using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace api_praksa.Services.PostService
{
	public interface IPostService
	{


        List<Post>? GetAllPosts();

        Post GetSinglePost(int id);

        List<Post>? AddPost(Post postId);

        List<Post>? UpdatePost(int id, Post request);

        List<Post>? DeletePost(int id);
        Task<IEnumerable<User>> GetUsers();
    }
}

