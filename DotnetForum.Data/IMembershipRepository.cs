using DotnetForum.Data.Models;

namespace DotnetForum.Data
{
    public interface IMembershipRepository
    {
        Member GetUserByName(string userName);
    }
}
