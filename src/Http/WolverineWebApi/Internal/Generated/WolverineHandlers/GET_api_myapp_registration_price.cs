// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_api_myapp_registration_price
    public class GET_api_myapp_registration_price : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_api_myapp_registration_price(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            int numberOfMembers = default;
            int.TryParse(httpContext.Request.Query["numberOfMembers"], System.Globalization.CultureInfo.InvariantCulture, out numberOfMembers);
            
            // The actual HTTP request handler execution
            var decimalValue_response = WolverineWebApi.Bugs.MyAppLandingEndpoint.GetRegistrationPrice(numberOfMembers);

            // Writing the response body to JSON because this was the first 'return variable' in the method signature
            await WriteJsonAsync(httpContext, decimalValue_response);
        }

    }

    // END: GET_api_myapp_registration_price
    
    
}

