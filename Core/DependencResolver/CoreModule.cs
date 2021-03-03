using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencResolver
{
    public class CoreModule : ICoreModule  //Uygulama düzeyinde servis bağımlılıklarımızı çözümleyeceğimiz yer
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache(); //hazır helen bir injection;arkaplanda hazır bir ICacheManager instance ı oluşturur
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();

        }
    }
}
