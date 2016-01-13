using System.Linq;
using System.Web.Http;
using Sale.EF;
using Sale.Models.Model;

namespace Sale.Controllers
{
    public class AuthenticateAdminController : ApiController
    {
        private readonly Context _context = new Context();

        // POST api/values
        public bool Post([FromBody]Admin admin)
        {
            var tempAdmin = _context.Admin.FirstOrDefault(x => x.Login.Equals(admin.Login) && x.Pass.Equals(admin.Pass));

            return tempAdmin != null;
        }
    }
}
