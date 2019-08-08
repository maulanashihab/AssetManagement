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
    public class CategoriesController : ApiController
    {
        readonly ICategoryService _iCategoryService;
        public CategoriesController(ICategoryService iCategoryService)
        {
            _iCategoryService = iCategoryService;
        }
        public CategoriesController() { }
        public HttpResponseMessage GetCategories()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iCategoryService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetCategory(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iCategoryService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        [HttpPut]
        public HttpResponseMessage UpdateCategory(int id, CategoryVM categoryVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iCategoryService.Update(id, categoryVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        public HttpResponseMessage InsertCategory(CategoryVM categoryVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = _iCategoryService.Insert(categoryVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteCategory(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iCategoryService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}