using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infra.Repository;

public class UserRepository : IUserRepository
{
    private readonly MyDbContext _myDbContext;

    public UserRepository(MyDbContext myDbContext)
    {
        _myDbContext = myDbContext;
    }
    
    public async Task<List<User>> GetUsers()
    {
        var result = await _myDbContext.User.ToListAsync();
        return result;
    }
    
    public async Task<User> GetUserById(int id)
    {
        var user = await _myDbContext.User.SingleOrDefaultAsync(x => x.Id == id);
        if(user== null)
        {
            throw new NullReferenceException("User not exiest...!!!");
        }
        return user;
    }

    public async Task<int> AddUser(User user)
    {
        await _myDbContext.User.AddAsync(user);
        return await _myDbContext.SaveChangesAsync();
    }

    public async Task<int> UpdateUser(User user)
    {
        _myDbContext.User.Update(user);
        return await _myDbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteUser(int id)
    {
        var user = await _myDbContext.User.SingleOrDefaultAsync(x =>x.Id == id);
        _myDbContext.User.Remove(user);
        return await _myDbContext.SaveChangesAsync();
    }

}
