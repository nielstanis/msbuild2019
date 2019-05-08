using System;
using JKang.IpcServiceFramework;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace PDFService
{
    class Program
    {
        static void Main(string[] args)
        {
            // configure DI
            IServiceCollection services = ConfigureServices(new ServiceCollection());

            // build and run service host
            new IpcServiceHostBuilder(services.BuildServiceProvider())
                .AddNamedPipeEndpoint<IPDFService>(name: "endpoint", pipeName: "generatePDF")
                .Build()
                .Run();
        }

        private static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            return services
                .AddIpc(builder =>
                {
                    builder
                        .AddNamedPipe(options =>
                        {
                            options.ThreadCount = 2;
                        })
                        .AddService<IPDFService, PDFGenerator>();
                });
        }
        
    }
}
