using System;
namespace AccountOwner.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                   builder => builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntergration(this IServiceCollection services)
        {
            services.ConfigureCors<IISOptions>(Base64FormattingOptions =>
            {

            });
        }
    }
}
