
using Month2.DTO;
using Month2.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Month2.IServiceRBAC
{
    public interface IRoleService : IApplicationService
       // ICrudAppService<RoleModelDto, int, PagedAndSortedResultRequestDto, CreateUpDateRoleModelDto>
    {
            public Task<DataResult<int>>    AddAsync(RoleModelDto roleModelDto);

        public Task<DataResult<List<RoleModelDto>>> PageListSelect(int PageIndex, int PagePsize);
    }




}
