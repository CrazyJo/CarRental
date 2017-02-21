using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;
using CarRental.Data;
using CarRental.Services.Entities;
using CarRental.Services.Infra;

namespace CarRental.Services
{
    public interface IUserService
    {
        Task<RegistrationResult> Register(User user);
        Task<AuthResult> Login(string userName, string password);
    }

    public class UserService : IUserService
    {
        public CarRentalModelContainer Database { get; set; }

        public UserService()
        {
            Database = new CarRentalModelContainer();
        }

        public async Task<RegistrationResult> Register(User user)
        {
            var res = new RegistrationResult();
            try
            {
                var person = Map(user);

                Database.People.Add(person);
                Database.AuthInfoes.Add(person.AuthInfo);
                await Database.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
            }
            return res;
        }

        Person Map(User user)
        {
            var newP = new Person
            {
                FirsName = user.FirstName,
                LastName = user.LastName,
                AuthInfo = new AuthInfo {Password = user.Password, UserName = user.UserName}
            };
            return newP;
        }

        public async Task<AuthResult> Login(string userName, string password)
        {
            var res = new AuthResult { SignInStatus = SignInStatus.Failure };

            try
            {
                var authInfo = await Database.AuthInfoes
                    .Include(r => r.Person)
                    .Include(p => p.Role)
                    .FirstOrDefaultAsync(r =>
                    r.UserName.Equals(userName, StringComparison.CurrentCultureIgnoreCase) &&
                    r.Password.Equals(password, StringComparison.CurrentCultureIgnoreCase));
                if (authInfo == null) return res;

                var domainM = Map(authInfo);
                res.User = domainM;
                res.SignInStatus = SignInStatus.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return res;
        }

        private User Map(AuthInfo authInfo)
        {
            return new User
            {
                FirstName = authInfo.Person.FirsName,
                LastName = authInfo.Person.LastName,
                Password = authInfo.Password,
                UserName = authInfo.UserName,
                Role = authInfo.Role,
                Id = authInfo.Id
            };
        }
    }
}
