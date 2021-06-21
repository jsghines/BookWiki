
using BookWiki.Domain;
using BookWiki.Helpers.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace BookWiki
{
    public static class DependencyInjectExtension
    {
        /// <summary>
        /// dependency inject
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyInject(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<Category>();
            services.AddScoped<UserService>();
        }
    }
}