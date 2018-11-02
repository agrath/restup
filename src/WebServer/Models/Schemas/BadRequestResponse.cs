using Windows.Web.Http;

namespace Restup.Webserver.Models.Schemas
{
    internal class BadRequestResponse : StatusOnlyResponse
    {
        internal BadRequestResponse() : base((int)HttpStatusCode.BadRequest) { }
    }
}
