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
    public class ReligionsController : ApiController
    {
        readonly IReligionService _iReligionService;
        public ReligionsController() { }
        public ReligionsController(IReligionService iReligionService)
        {
            _iReligionService = iReligionService;
        }
        public HttpResponseMessage GetReligion()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found");
            var get = _iReligionService.Get();
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetReligion(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iReligionService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage InsertReligion(ReligionVM religionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong");
            var result = _iReligionService.Insert(religionVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Success Add");
            }
            return message;
        }
    }
    
    }