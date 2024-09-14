using EConnect.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EConnect.DAL.Repository
{
	public class LoginRespository : ILoginRepository
	{
		private readonly EConnectDbContext _context;

		public LoginRespository(EConnectDbContext context)
		{
			_context = context;
		}
		public void AddLogin(Login login)
		{
			_context.Logins.Add(login);
			_context.SaveChanges();
		}

		public void DeleteLogin(int id)
		{
			var user = _context.Logins.Find(id);
			if (user != null)
			{
				_context.Logins.Remove(user);
				_context.SaveChanges();
			}
		}

		public IEnumerable<Login> GetAllActiveLogins()
		{
			return _context.Logins.Where(p => p.IsActive == true).ToList();
		}

		public IEnumerable<Login> GetAllActiveLoginsByCompanyId(string id)
		{
			return _context.Logins.Where(p => p.Company == id).ToList();
		}

		public IEnumerable<Login> GetAllLogins()
		{
			return _context.Logins.ToList();
		}

		public Login? GetLoginById(int id)
		{
			Login? login = _context.Logins.Where(p => p.LoginId == id).FirstOrDefault();
			return login;
		}

		public Login? GetLoginByName(string name)
		{
			Login? login = _context.Logins.Where(p => p.Login1 == name).FirstOrDefault();
			return login;
		}

		public void UpdateLogin(Login login)
		{
			_context.Logins.Update(login);
			_context.SaveChanges();
		}
	}
}
