
using Microsoft.AspNetCore.Mvc;
using Month2.DTO;
using Month2.Helper;
using Month2.IServiceRBAC;
using Month2.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Month2.ServiceRBAC
{
    public class RoleModelService : ApplicationService, IRoleService
    {
        //   : CrudAppService<MyRoleModel, RoleModelDto, int, PagedAndSortedResultRequestDto, CreateUpDateRoleModelDto>,
        private readonly IRepository<MyRoleModel, int> repository;

        public RoleModelService(IRepository<MyRoleModel, int> _repository)
        {
            repository = _repository;
        }
        
        //添加
        [HttpPost,Route("PostRoleModel")]
        public async Task<DataResult<int>> AddAsync(RoleModelDto roles)
        {
            try
            {
                var data = ObjectMapper.Map<RoleModelDto, MyRoleModel>(roles);
                await repository.InsertAsync(data);

                return new DataResult<int>
                {
                    
                    Message = "成功",
                    TypeCode = HelperEnum.HttpCode.成功
                };
            }
            catch (Exception)
            {
                return new DataResult<int>
                {
                    Message = "添加成功",
                    TypeCode = HelperEnum.HttpCode.服务器内部错误
                };
            }
        }


        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("GetRoleModel")]
        public async Task<DataResult<List<RoleModelDto>>> PageListSelect(int PageIndex,int PagePsize)
        {
            try
            {
                
                List<MyRoleModel> list = await repository.GetListAsync();
                int total = list.Count();
                var data = ObjectMapper.Map<List<MyRoleModel>, List<RoleModelDto>>(list);
                data = data.Skip((PageIndex - 1) * PagePsize).Take(PagePsize).ToList();
                return new DataResult<List<RoleModelDto>>
                {
                    Result = data,
                    Total=total,
                    Message = "显示成功",
                    TypeCode = HelperEnum.HttpCode.成功
                };
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}


