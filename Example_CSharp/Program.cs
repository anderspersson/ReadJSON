using System.Text.Json;

namespace main
{
	class Example_Csharp
	{

		public static void Main()
		{
			string json = File.ReadAllText("data.json");

			Data? jsonData = JsonSerializer.Deserialize<Data>(json);

			System.Console.WriteLine($"Program Name: {jsonData?.name}");

			jsonData?.dependencies?.ForEach(x => System.Console.WriteLine($"Name {x.name}"));

		}
	}
}

