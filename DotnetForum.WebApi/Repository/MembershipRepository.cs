using DotnetForum.Data;
using DotnetForum.Data.Models;
using System.Linq;

namespace DotnetForum.WebApi.Services
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly AppDbContext _context;

        public MembershipRepository(
            AppDbContext context)
        {
            _context = context;
        }

        public Member GetUserByName(string userName)
        {
            return _context.Users.Where(x => x.UserName == userName).Single();
        }
    }
}
