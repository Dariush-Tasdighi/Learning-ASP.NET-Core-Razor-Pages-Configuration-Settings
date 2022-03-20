namespace Server.Pages
{
	public class IndexModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public IndexModel
			(Microsoft.Extensions.Configuration.IConfiguration configuration) : base()
		{
			Configuration = configuration;

			AdminEmailAddress1 =
				Configuration
				.GetSection(key: "Admin")
				.GetSection(key: "EmailAddress").Value;

			AdminEmailAddress2 =
				Configuration
				.GetSection(key: "Admin:EmailAddress").Value;
		}

		public string AdminEmailAddress1 { get; set; }

		public string AdminEmailAddress2 { get; set; }

		private Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

		public void OnGet()
		{
		}
	}
}
