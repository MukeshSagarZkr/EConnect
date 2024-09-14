using EConnect.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EConnect.BAL.Interfaces
{
    public interface ILoginService
    {
        IEnumerable<Login> GetAllLogins();
        Login? GetLoginById(int id);
        void AddLogin(Login login);
        void UpdateLogin(Login login);
        void DeleteLogin(int id);
        Login? GetLoginByName(string name);
        IEnumerable<Login> GetAllActiveLogins();
        IEnumerable<Login> GetAllActiveLoginsByCompanyId(string id);
    }
}

