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
                var person = Mapper.Map<Person>(user);
                //var authInfo = Mapper.Map<AuthInfo>(user);
                //var role = await Database.Roles.FirstAsync(dbRole => user.Roles.Any(uR => ((int)uR).Equals((int)dbRole.Name)));
                //var persRole = new PersonRole { AuthInfo = authInfo, Role = role };
                //person.AuthInfo = authInfo;

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

                var domainM = Mapper.Map<User>(authInfo);
                res.User = domainM;
                res.SignInStatus = SignInStatus.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return res;
        }
    }
}
