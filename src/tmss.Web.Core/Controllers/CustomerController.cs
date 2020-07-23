using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tmss.ICustomerServices;
using tmss.ICustomerServices.Dto;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace tmss.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CustomerController : tmssControllerBase
    {
        private readonly ICustomerService cusService;

        public CustomerController(ICustomerService _cusService)
        {
            cusService = _cusService;
        }
        [HttpGet]
        public ActionResult Index(GetCustomerInput input)
        {
            var output = cusService.GetListCustomer(input);
            var model = ObjectMapper.Map<IndexViewModels>(output);
            return View(model);
        }

    }


    [AutoMapFrom(typeof(ListResultDto<CustomerListDto>))]
    public class IndexViewModels : ListResultDto<CustomerListDto>
    {

    }
}
