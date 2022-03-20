namespace Server.Pages
{
	public class Learn05Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn05Model(Microsoft.Extensions.Options.IOptions
			<Infrastructure.Settings.ApplicationSettings> applicationSettingsOptions) : base()
		{
			ApplicationSettings =
				applicationSettingsOptions.Value;
		}

		public Infrastructure.Settings.ApplicationSettings ApplicationSettings { get; }

		public void OnGet()
		{
		}
	}
}
