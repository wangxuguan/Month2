
using Month2.DTO;
using Month2.Verification;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace Month2.IServiceRBAC
{
    public interface IUserService : ICrudAppService<UserModelDto, int, PagedAndSortedResultRequestDto, CreateUpDateUserModelDto>
    {


    }
}
