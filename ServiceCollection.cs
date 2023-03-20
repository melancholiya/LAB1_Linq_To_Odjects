using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LAB1
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IDBContext, DataList>();
            services.AddTransient<IRequests, Requests>();
            services.AddTransient<IOutput, Output>();
            services.AddTransient<IRun, Run>();

            return services;
        }
    }
}
