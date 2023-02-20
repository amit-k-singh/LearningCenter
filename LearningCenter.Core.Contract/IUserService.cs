using LearningCenter.Core.Domain.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Core.Contract
{
    public interface IUserService
    {
        Task AddUserAsync(UserRequestModel userRequestModel);
    }
}
