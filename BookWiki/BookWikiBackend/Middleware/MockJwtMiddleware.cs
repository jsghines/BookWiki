using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Helpers
{
    /*
        This is mock middleware meant to represent the work an authentication provider would do
    */
    public class MockJwtMiddleware
    {
        private readonly RequestDelegate _next;

        public MockJwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            attachUserToContext(context);

            await _next(context);
        }

        private void attachUserToContext(HttpContext context)
        {
            try
            {
                context.Items["User"] = "jhines";
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }
        }
    }
}