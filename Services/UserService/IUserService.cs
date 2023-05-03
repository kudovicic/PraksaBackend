using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace api_praksa.Services.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
