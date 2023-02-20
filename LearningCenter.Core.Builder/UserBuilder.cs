using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Infra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Core.Builder
{
    public class UserBuilder
    {
        public static User Build(UserRequestModel user)
        {
            return new User(user.Name, user.Dob, user.Age, user.Phone, user.Address, user.Email, user.Password);
        }
    }
}
