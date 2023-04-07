namespace main
{
	public class Data
	{
		public string? id { get; set; }
		public string? name { get; set; }
		public string? publisher { get; set; }
		public List<Dependencies>? dependencies { get; set; }

	}
	public class Dependencies
	{
		public string? id { get; set; }
		public string? publisher { get; set; }
		public string? name { get; set; }
		public string? version { get; set; }
	}
}




