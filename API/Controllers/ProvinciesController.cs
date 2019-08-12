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
    public class ProvinciesController : ApiController
    {
        readonly IProvinceService _iProvinceService;
        public ProvinciesController() { }
        public ProvinciesController(IProvinceService iProvinceService)
        {
            _iProvinceService = iProvinceService;
        }
        public HttpResponseMessage GetProvince()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data not Found");
            var get = _iProvinceService.Get();
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetProvince(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iProvinceService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message; 
        }
        public HttpResponseMessage InsertProvince(ProvinceVM provinceVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong");
            var result = _iProvinceService.Insert(provinceVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Success Add");
            }
            return message;
        }
    }

}