using System;
using System.Linq;
using BookWiki.Helpers.Constants;
using Microsoft.AspNetCore.Http;

namespace BookWiki.Helpers.Services
{
    public class UserService
    {
        private IHttpContextAccessor Context { get; set; }
        private const string UserIdKey = "UserId";
        public UserService(IHttpContextAccessor context)
        {
            this.Context = context;
        }
        
        public Guid GetUserId()
        {
            
            var userIdFromContext = (string)this.Context.HttpContext.Items.FirstOrDefault(x => x.Key as string == UserIdKey).Value;
            Guid userId;
            var userIdIsValidGuid = Guid.TryParse(userIdFromContext, out userId); 
            if(!userIdIsValidGuid)
            {
                throw new UnauthorizedAccessException(ErrorMessaging.InvalidIdException);
            }
            return userId; 
        }
    }
}