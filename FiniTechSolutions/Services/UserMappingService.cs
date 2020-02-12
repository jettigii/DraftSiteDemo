using FiniTechSolutions.Interfaces;
using System.Collections.Concurrent;

namespace FiniTechSolutions.Services
{
    public class UserMappingService<UserType> : IUserMappingService<UserType>
    {
        private ConcurrentDictionary<string, UserType> Connections { get; set; }

        public UserMappingService()
        {
            Connections = new ConcurrentDictionary<string, UserType>();
        }

        public bool Add(string connectionString, UserType user)
        {
            return Connections.TryAdd(connectionString, user);
        }

        public UserType Get(string connectionString)
        {
            Connections.TryGetValue(connectionString, out var user);
            return user;
        }

        public bool Remove(string connectionString)
        {
            return Connections.TryRemove(connectionString, out var user);
        }
    }
}
