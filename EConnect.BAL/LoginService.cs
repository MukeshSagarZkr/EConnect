using EConnect.BAL.Interfaces;
using EConnect.DAL.Models;
using EConnect.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EConnect.BAL
{
	public class LoginService : ILoginService
	{
		private readonly ILoginRepository _loginRepository;

		public LoginService(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}
		public void AddLogin(Login login)
		{
			_loginRepository.AddLogin(login);
		}

		public void DeleteLogin(int id)
		{
			_loginRepository.DeleteLogin(id);
		}

		public IEnumerable<Login> GetAllLogins()
		{
			return _loginRepository.GetAllLogins();
		}

		public Login? GetLoginById(int id)
		{
			return _loginRepository.GetLoginById(id);
		}

		public void UpdateLogin(Login login)
		{
			_loginRepository.UpdateLogin(login);
		}

		public Login? GetLoginByName(string name)
		{
			return _loginRepository.GetLoginByName(name);
		}
		public IEnumerable<Login> GetAllActiveLogins()
		{
			return _loginRepository.GetAllActiveLogins();
		}
		public IEnumerable<Login> GetAllActiveLoginsByCompanyId(string id)
		{
			return _loginRepository.GetAllActiveLoginsByCompanyId(id);
		}
	}
}
