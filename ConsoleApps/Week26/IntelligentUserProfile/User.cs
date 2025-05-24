using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentUserProfile
{
    public class User
    {
        public DateTime BirthDate { get; set; }
        public string Bio { get; set; }
        public int Age => BirthDate.GetAge();
    }
}
