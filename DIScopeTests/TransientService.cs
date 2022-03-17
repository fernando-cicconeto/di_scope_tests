namespace DIScopeTests;

public class TransientService : IDisposable
{
	public TransientService()
	{
		Console.WriteLine("Transient service is created");
	}

	public void Dispose()
	{
		Console.WriteLine("Transient service is disposed");
	}
}
