using LearningCenter.Infra.Contract;
using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infra.Repository;

public class UserRepository : IUserRepository
{
    private readonly LearningCenterContext _learningCenterContext;

    public UserRepository(LearningCenterContext learningCenterContext)
    {
        _learningCenterContext = learningCenterContext;
    }
    
    public async Task<List<User>> GetUsers()
    {
        var result = await _learningCenterContext.User.ToListAsync();
        return result;
    }
    
    public async Task<User> GetUserById(int id)
    {
        var user = await _learningCenterContext.User.SingleOrDefaultAsync(x => x.Id == id);
        if(user== null)
        {
            throw new NullReferenceException("User not exiest...!!!");
        }
        return user;
    }

    public async Task<User> GetUserByEmail(string email)
    {
        var user = await _learningCenterContext.User.FirstOrDefaultAsync(x => x.Email == email);
        return user;
    }

    public async Task<int> AddUser(User user)
    {
        await _learningCenterContext.User.AddAsync(user);
        return await _learningCenterContext.SaveChangesAsync();
    }

    public async Task<int> UpdateUser(User user)
    {
        _learningCenterContext.User.Update(user);
        return await _learningCenterContext.SaveChangesAsync();
    }

    public async Task<int> DeleteUser(int id)
    {
        var user = await _learningCenterContext.User.SingleOrDefaultAsync(x =>x.Id == id);
        _learningCenterContext.User.Remove(user);
        return await _learningCenterContext.SaveChangesAsync();
    }

}
