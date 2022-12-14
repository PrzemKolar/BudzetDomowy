using BudzetDomowy.ApplicationServices.API.Domain;
using BudzetDomowy.ApplicationServices.API.Domain.ErrorHandling;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.CompilerServices;

namespace BudzetDomowy.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        protected readonly IMediator mediator;

        public ApiControllerBase(IMediator mediator)
        {
            this.mediator = mediator;
        }

        protected async Task<IActionResult> HandleRequest<TRequest,TResponse>(TRequest request)
            where TRequest : IRequest<TResponse>
            where TResponse : ErrorResponseBase
        {
            if(!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState.Where(x => x.Value.Errors.Any()).Select(x => new { property = x.Key, errors = x.Value.Errors }));
            }

            var response = await this.mediator.Send(request);

            if(response.Error != null)
            { 
                return this.ErrorResponse(response.Error);
            }

            return this.Ok(response);
        }

        private IActionResult ErrorResponse(ErrorModel errorModel)
        {
            var httpCode = GetHttpStatusCode(errorModel.Error);
            return StatusCode((int)httpCode, errorModel);
        }

        private static HttpStatusCode GetHttpStatusCode(string errorType)
        {
            switch(errorType)
            {
                case ErrorType.NotFound:
                    return HttpStatusCode.NotFound;
                case ErrorType.InternalSeverError:
                    return HttpStatusCode.InternalServerError;
                case ErrorType.Unauthorized:
                    return HttpStatusCode.Unauthorized;
                case ErrorType.RequestTooLarge:
                    return HttpStatusCode.RequestEntityTooLarge;
                case ErrorType.UnsupportedMediaType:
                    return HttpStatusCode.UnsupportedMediaType;
                case ErrorType.UnsupportedMethod:
                    return HttpStatusCode.MethodNotAllowed;
                case ErrorType.TooManyReqeusts:
                    return HttpStatusCode.TooManyRequests;
                default:
                    return HttpStatusCode.BadRequest;
            }
        }
    }
}
