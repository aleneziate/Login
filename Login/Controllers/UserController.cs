using Login.Data;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class UserDbContext : Controller
    {
        private LoginDbContext db;
        public UserDbContext(LoginDbContext Db)
        {
            db = Db;
        }
    }
}
