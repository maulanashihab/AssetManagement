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
    public class RegenciesController : ApiController
    {
        readonly IRegencyService _iRegencyService;
        public RegenciesController() { }
        public RegenciesController(IRegencyService iRegencyService)
        {
            _iRegencyService = iRegencyService;
        }
        public HttpResponseMessage GetRegency()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data not Found");
            var get = _iRegencyService.Get();
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetRegency(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found");
            var get = _iRegencyService.Get(id);
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage InsertRegency(RegencyVM regencyVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong");
            var result = _iRegencyService.Insert(regencyVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Success Add");
            }
            return message;
        }
    }
}