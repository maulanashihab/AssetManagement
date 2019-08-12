using BusinessLogic.Services.Interfaces;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class EmployeesController : ApiController
    {
        readonly IEmployeeService _iEmployeeService;
        public EmployeesController() { }
        public EmployeesController(IEmployeeService iEmployeeService)
        {
            _iEmployeeService = iEmployeeService;
        }
        public HttpResponseMessage GetEmployee()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found");
            var get = _iEmployeeService.Get();
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetEmployee(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iEmployeeService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage InsertEmployee(EmployeeVM employeeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong");
            var result = _iEmployeeService.Insert(employeeVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Success Add");
            }
            return message;
        }
    }
}