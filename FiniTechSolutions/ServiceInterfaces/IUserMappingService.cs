namespace FiniTechSolutions.Interfaces
{
    public interface IUserMappingService<UserType>
    {
        bool Add(string connectionString, UserType user);

        UserType Get(string connectionString);

        bool Remove(string connectionString);
    }
}
