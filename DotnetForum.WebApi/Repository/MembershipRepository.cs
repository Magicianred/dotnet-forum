using System;
using System.Linq;
using DotnetForum.Contracts.Repository;
using DotnetForum.WebApi.Database;
using DotnetForum.Models;

namespace DotnetForum.WebApi.Services
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly ForumDatabaseContext _context;

        public MembershipRepository(
            ForumDatabaseContext context)
        {
            _context = context;
        }

        public User GetUserByName(string userName)
        {
            return _context.Users.Where(x => x.UserName == userName).Single();
        }
    }
}
