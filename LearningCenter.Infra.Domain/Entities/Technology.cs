using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter.Infra.Domain.Entities
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Technology() { }

        public Technology(string name)
        {
            Name= name;
        }
    }
}
