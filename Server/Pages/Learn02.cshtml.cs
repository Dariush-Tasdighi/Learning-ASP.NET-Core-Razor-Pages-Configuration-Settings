namespace Server.Pages
{
	public class Learn02Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn02Model(Microsoft.Extensions.Options
			.IOptions<Infrastructure.Settings.AdminSettings> adminSettingsOptions) : base()
		{
			AdminSettings =
				adminSettingsOptions.Value;
		}

		public Infrastructure.Settings.AdminSettings AdminSettings { get; }

		public void OnGet()
		{
		}
	}
}
