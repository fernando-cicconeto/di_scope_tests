namespace DIScopeTests;

public class ScopedService : IDisposable
{
	public ScopedService()
	{
		Console.WriteLine("Scoped service is created");
	}

	public void Dispose()
	{
		Console.WriteLine("Scoped service is disposed");
	}
}
