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
    public class SuppliersController : ApiController
    {
        readonly ISupplierService _iSupplierService;
        public SuppliersController(ISupplierService iSupplierService)
        {
            _iSupplierService = iSupplierService;
        }
        public SuppliersController() { }
        public HttpResponseMessage GetSuppliers()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iSupplierService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage GetSupplier(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iSupplierService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        [HttpPut]
        public HttpResponseMessage UpdateSupplier(int id, SupplierVM supplierVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iSupplierService.Update(id, supplierVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        public HttpResponseMessage InsertSupplier(SupplierVM supplierVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = _iSupplierService.Insert(supplierVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteSupplier(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iSupplierService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}