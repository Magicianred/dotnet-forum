using System;
using DotnetForum.Models;

namespace DotnetForum.Contracts.Repository
{
    public interface IMembershipRepository
    {
        User GetUserByName(string userName);
    }
}
