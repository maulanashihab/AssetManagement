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
    public class DepartmentsController : ApiController
    {
        readonly IDepartmentService _iDepartmentService;
        public DepartmentsController() { }
        public DepartmentsController(IDepartmentService iDepartmentService)
        {
            _iDepartmentService = iDepartmentService;
        }
        public HttpResponseMessage GetRegency()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data not Found");
            var get = _iDepartmentService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetRegency(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found");
            var get = _iDepartmentService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage InsertRegency(DepartmentVM departmentVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong");
            var result = _iDepartmentService.Insert(departmentVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Success Add");
            }
            return message;
        }
    }
}