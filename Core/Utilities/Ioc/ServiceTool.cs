using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Ioc
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        //Diyor ki burada .netin servis koleksiyonunu al ve onları build et. 
        //bu kod webapı de yada autofac de olusturdugumuz ınjectıonları olusturmamıza yarıyor.
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
