using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Group { get; private set; }
        public string ID { get; private set; }
        public string TestName { get; private set; }
        public List<Input> AllData { get; set; } = new List<Input>();
        public List<Input> PreferedData { get; set; } = new List<Input>();
        public User(string name, string lastname, string group, string id,string testname)
        {
            Name = name;
            LastName = lastname;
            Group = group;
            ID = id;
            TestName = testname;
        }
    }
}
