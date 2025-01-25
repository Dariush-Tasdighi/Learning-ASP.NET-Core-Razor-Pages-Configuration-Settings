namespace Infrastructure.Settings;

public class ApplicationSettings : object
{
	public ApplicationSettings() : base()
	{
	}

	public string? ActivationKey { get; set; }

	public CultureSettings? CultureSettings { get; set; }
}
