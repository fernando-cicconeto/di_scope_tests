namespace DIScopeTests;

public class SingletonService : IDisposable
{
	public SingletonService()
	{
		Console.WriteLine("Singleton service is created");
	}

	public void Dispose()
	{
		Console.WriteLine("Singleton service is disposed");
	}
}
