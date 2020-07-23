using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using tmss.ICustomerServices.Dto;

namespace tmss.ICustomerServices
{
    public interface ICustomerService : IApplicationService
    {
        ListResultDto<CustomerListDto> GetListCustomer(GetCustomerInput input);
    }
}
