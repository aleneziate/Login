using Login.Data;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class RoleDbContext : Controller
    {
        private LoginDbContext db;
        public RoleDbContext(LoginDbContext Db)
        {
            db = Db;
        }
    }
}
