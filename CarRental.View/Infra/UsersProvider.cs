using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Infra
{
    public class UsersProvider : GridValueProvider<User, UserViewModel>
    {
        public IUserService UserService { get; set; }

        public UsersProvider(IUserService userService, DataGridView dataGridView) : base(dataGridView)
        {
            UserService = userService;
        }

        protected override IEnumerable<UserViewModel> Convert(IEnumerable<User> domainModel)
        {
            return Mapper.Map<IEnumerable<UserViewModel>>(domainModel);
        }

        protected override async Task<IEnumerable<User>> GetDomainModel()
        {
            return await UserService.GetAll();
        }
    }
}
