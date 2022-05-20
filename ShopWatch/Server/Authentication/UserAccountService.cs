using ShopWatch.Server.Data;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWatch.Server.Authentication
{
    public class UserAccountService
    {
        private readonly DataContext _context;

        public UserAccountService(DataContext context)
        {
            _context = context;
        }

        
        public UserAccount? GetUserAccountByUserName(string username)
        {
            return _context.UserAccounts.FirstOrDefault(x => x.UserName == username);
        }


    }
}
