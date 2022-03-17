using DIScopeTests;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection serviceCollection = new();

serviceCollection.AddTransient<TransientService>();
serviceCollection.AddScoped<ScopedService>();
serviceCollection.AddSingleton<SingletonService>();

IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

Console.WriteLine("-- Start of first scope");
using (IServiceScope serviceScope = serviceProvider.CreateScope())
{
	serviceScope.ServiceProvider.GetRequiredService<TransientService>();
	serviceScope.ServiceProvider.GetRequiredService<TransientService>();

	serviceScope.ServiceProvider.GetRequiredService<ScopedService>();
	serviceScope.ServiceProvider.GetRequiredService<ScopedService>();

	serviceScope.ServiceProvider.GetRequiredService<SingletonService>();
	serviceScope.ServiceProvider.GetRequiredService<SingletonService>();
}
Console.WriteLine("-- End of first scope");

Console.WriteLine("-- Start of second scope");
using (IServiceScope serviceScope = serviceProvider.CreateScope())
{
	serviceScope.ServiceProvider.GetRequiredService<TransientService>();
	serviceScope.ServiceProvider.GetRequiredService<TransientService>();

	serviceScope.ServiceProvider.GetRequiredService<ScopedService>();
	serviceScope.ServiceProvider.GetRequiredService<ScopedService>();

	serviceScope.ServiceProvider.GetRequiredService<SingletonService>();
	serviceScope.ServiceProvider.GetRequiredService<SingletonService>();
}
Console.WriteLine("-- End of second scope");
