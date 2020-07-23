using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tmss.Customers;
using tmss.ICustomerServices;
using tmss.ICustomerServices.Dto;

namespace tmss.CutomerServices
{
    public class CustomerService : tmssAppServiceBase, ICustomerService
    {
        private readonly IRepository<Customer> repository;

        public CustomerService(IRepository<Customer> _repo)
        {
            repository = _repo;
        }


        public ListResultDto<CustomerListDto> GetListCustomer(GetCustomerInput input)
        {
            var cutomers = repository
             .GetAll()
             .WhereIf(
                 !input.Filter.IsNullOrEmpty(),
                 p => p.CustName.Contains(input.Filter)
                 
             )
             .OrderBy(p => p.CustName)
             .ToList();

            return new ListResultDto<CustomerListDto>(ObjectMapper.Map<List<CustomerListDto>>(cutomers));
        }
    }
}
