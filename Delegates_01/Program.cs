using System.Diagnostics;
using System.Threading.Tasks;

namespace Delegates_01
{
    public class Program
    {
        static void Main(string[] args)
        {
			int size = 100;
			Task[] tasks = new Task[size];
			for (int i = 0; i < size; i++)
			{
				tasks[i] = Task.Run(() => MemoryCache.Create());
			}
			Task.WaitAll(tasks);
		}
	}
}

public class MemoryCache
{
	private static int i = 0;
	private static MemoryCache _instance;
	private MemoryCache()
	{
		Debug.WriteLine($"MemoryCache {i++}");
	}
	public static MemoryCache Create()
	{
		return _instance ?? (_instance = new MemoryCache());
	}
}

