using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Infra.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public User() 
        {
            
        }
        public User(string name, DateTime dob, int age, long phone, string address, string email, string password)
        {
            Name = name;
            Dob = dob;
            Age = age;
            Phone = phone;
            Address = address;
            Email = email;
            Password = password;
        }
    }

}
