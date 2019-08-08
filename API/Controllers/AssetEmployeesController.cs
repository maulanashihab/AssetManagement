using BusineesLogic.Services.Interfaces;
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
    public class AssetEmployeesController : ApiController
    {
        readonly IAssetEmployeeService _iAssetEmployeeService;
        public AssetEmployeesController(IAssetEmployeeService iAssetEmployeeService)
        {
            _iAssetEmployeeService = iAssetEmployeeService;
        }
        public AssetEmployeesController() { }
        public HttpResponseMessage GetAssetEmployees()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iAssetEmployeeService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetAssetEmployee(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iAssetEmployeeService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        [HttpPut]
        public HttpResponseMessage UpdateAssetEmployee(int id, AssetEmployeeVM assetEmployeeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iAssetEmployeeService.Update(id, assetEmployeeVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        public HttpResponseMessage InsertAssetEmployee(AssetEmployeeVM assetEmployeeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = _iAssetEmployeeService.Insert(assetEmployeeVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteAssetEmployee(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iAssetEmployeeService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}