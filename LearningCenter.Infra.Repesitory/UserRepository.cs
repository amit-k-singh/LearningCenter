using LearningCenter.Infra.Domain.Context;
using LearningCenter.Infra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Infra.Repesitory;

public class UserRepository
{
    private readonly MyDbContext _myDbContext;

    public UserRepository(MyDbContext myDbContext)
    {
        _myDbContext = myDbContext;
    }

    public async Task<int> AddUser(Users users)
    {
        await _myDbContext.Users.AddAsync(users);
        return await _myDbContext.SaveChangesAsync();
    }
}
