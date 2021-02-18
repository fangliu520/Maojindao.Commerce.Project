using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MJD.Cormmerce.AuthenticationCenter.Model;

namespace MJD.Cormmerce.AuthenticationCenter.Utility
{
    public interface ICustomJWTService
    {
        string GetToken(string UserName, string password, User user);
    }
}
