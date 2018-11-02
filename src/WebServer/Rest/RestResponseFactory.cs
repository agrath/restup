using System;
using Restup.Webserver.Models.Contracts;
using Restup.Webserver.Models.Schemas;
using Windows.Web.Http;

namespace Restup.Webserver.Rest
{
    internal class RestResponseFactory
    {
        private readonly BadRequestResponse _badRequestResponse;

        internal RestResponseFactory()
        {
            _badRequestResponse = new BadRequestResponse();
        }

        internal IRestResponse CreateBadRequest()
        {
            return _badRequestResponse;
        }

        internal IRestResponse CreateInternalServerErrorResponse(Exception ex)
        {
            return new InternalServerErrorResponse(ex);
        }
    }

    public class InternalServerErrorResponse : RestResponse, IContentRestResponse
    {
        private Exception exception;
        public object ContentData => exception != null ? exception.ToString() : "No error detail available";
        public InternalServerErrorResponse(Exception ex) : base((int)HttpStatusCode.InternalServerError, null)
        {
            exception = ex;
        }

       
    }
}
