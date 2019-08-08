using BusineesLogic.Services.Interfaces;
using Common.Repositories.Interfaces;
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
    public class ActionsController : ApiController
    {
        readonly IActionService _iActionService;
        public ActionsController(IActionService iActionService)
        {
            _iActionService = iActionService;
        }
        public ActionsController() { }
        public HttpResponseMessage GetActions()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iActionService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetAction(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iActionService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        [HttpPut]
        public HttpResponseMessage UpdateAction(int id, ActionVM actionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iActionService.Update(id, actionVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        public HttpResponseMessage InsertAction(ActionVM actionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = _iActionService.Insert(actionVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteAction(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iActionService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}