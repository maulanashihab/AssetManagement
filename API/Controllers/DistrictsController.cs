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
    public class DistrictsController : ApiController
    {
        readonly IDistrictService _iDistrictService;
        public DistrictsController() { }
        public DistrictsController(IDistrictService iDistrictService)
        {
            _iDistrictService = iDistrictService;
        }
        public HttpResponseMessage GetDistrict()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found");
            var get = _iDistrictService.Get();
            if(get!= null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetDistrict(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iDistrictService.Get(id);
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage InsertDistrict(DistrictVM districtVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong");
            var result = _iDistrictService.Insert(districtVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Success Add");
            }
            return message;
        }
    }
}