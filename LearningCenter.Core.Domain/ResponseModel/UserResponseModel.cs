using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Core.Domain.ResponseModel
{
    public class UserResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
