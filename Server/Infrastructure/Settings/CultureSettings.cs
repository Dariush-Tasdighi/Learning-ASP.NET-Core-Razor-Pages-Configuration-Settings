namespace Infrastructure.Settings
{
	public class CultureSettings : object
	{
		public CultureSettings() : base()
		{
		}

		public string? DefaultCulture { get; set; }

		public string[]? SupportedCultures { get; set; }
	}
}
