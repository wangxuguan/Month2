
using Month2.DTO;
using Month2.IServiceRBAC;
using Month2.RBAC;
using Month2.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace Month2.ServiceRBAC
{
    public class UserModelService : CrudAppService<MyUserModel, UserModelDto, int, PagedAndSortedResultRequestDto, CreateUpDateUserModelDto>, IUserService
    {
        private readonly IRepository<MyUserModel, int> userModels;

        public UserModelService(IRepository<MyUserModel, int> _userModels) : base(_userModels)
        {
            userModels = _userModels;
        }




    }
}
