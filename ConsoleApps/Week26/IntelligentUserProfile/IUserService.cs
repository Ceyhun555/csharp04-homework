using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentUserProfile
{
    internal interface IUserService
    {
        User CreateProfile();
        void AnalyzeBio(User user);
        void DisplayProfile(User user);
    }
}
