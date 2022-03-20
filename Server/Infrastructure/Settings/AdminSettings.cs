namespace Infrastructure.Settings
{
	public class AdminSettings : object
	{
		//public const string KeyName = "AdminSettings";

		//public static readonly string KeyName = "AdminSettings";

		public static readonly string KeyName = nameof(AdminSettings);

		public AdminSettings() : base()
		{
		}

		public int Age { get; set; }

		public bool IsActive { get; set; }

		public decimal Salary { get; set; }

		public string? FullName { get; set; }

		public string[]? FavoriteColors { get; set; }

	}
}
