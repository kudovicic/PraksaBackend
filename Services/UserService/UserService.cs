using Dapper;
using PraksaProjekt.Context;

namespace api_praksa.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DapperContext _context;
        public UserService(DapperContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<User>> GetUsers()
        {
            var query = "select * from dbo.[User]";
            using (var connection = _context.CreateConnection())
            {
                var users = await connection.QueryAsync<User>(query);
                return users.ToList();
            }

        }

    }
}