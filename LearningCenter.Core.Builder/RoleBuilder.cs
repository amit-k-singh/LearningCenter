using LearningCenter.Core.Domain.RequestModel;
using LearningCenter.Infra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Core.Builder
{
    public class RoleBuilder
    {
        public static Role Build(RoleRequestModel role) 
        {
            return new Role(role.Name);
        }
    }
}
