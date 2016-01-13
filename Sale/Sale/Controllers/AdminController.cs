using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Sale.EF;
using Sale.Models.Model;

namespace Sale.Controllers
{
    public class AdminController : ApiController
    {
        private readonly Context _context = new Context();

        // GET api/values
        public IEnumerable<Admin> Get()
        {
            return _context.Admin;
        }

        // GET api/values/5
        public Admin Get(int id)
        {
            return _context.Admin.Find(id);
        }

        // POST api/values
        public void Post([FromBody]Admin admin)
        {
            _context.Admin.Add(admin);
            _context.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Admin admin)
        {
            if (id != admin.Id) return;
            _context.Entry(admin).State = EntityState.Modified;

            _context.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var admin = _context.Admin.Find(id);
            if (admin == null) return;
            _context.Admin.Remove(admin);
            _context.SaveChanges();
        }
    }
}
