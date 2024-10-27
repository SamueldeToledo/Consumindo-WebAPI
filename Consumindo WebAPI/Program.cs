using Consumindo_WebAPI.Interface;
using Consumindo_WebAPI.Repository;
using Consumindo_WebAPI.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private readonly IAdviceService _Advice;

    public Program(IAdviceService advice)
    {
        _Advice = advice;
    }

    private static void Main(string[] args)
    {
        //Cria como se fosse uma program mas dentro do console
        var host = Host.CreateDefaultBuilder(args)
          .ConfigureServices((context, services) =>
          {
              services.AddTransient<IAdviceService, AdviceService>();
              services.AddTransient<IAdvice, AdviceRepository>();
          })
          .Build();

        //Aqui eu utilizo a minha instância de Advice
        var myService = host.Services.GetRequiredService<IAdviceService>();

        Console.WriteLine(myService.AdviceServiceGet());

    }
}