namespace Infrastructure.Settings;

public class MyAdminSettings : object
{
	public MyAdminSettings() : base()
	{
	}

	public int Age { get; set; }

	public bool IsActive { get; set; }

	public decimal Salary { get; set; }

	public string? FullName { get; set; }

	public string[]? FavoriteColors { get; set; }
}
