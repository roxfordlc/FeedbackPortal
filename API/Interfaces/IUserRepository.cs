using System;
using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{
    void Update(User user);
    void AddUser(User user);
    Task<bool> UserExists(string username);
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserByIdAsnyc(int id);
    Task<User?> GetUserByUsernameAsync(string username);



}
