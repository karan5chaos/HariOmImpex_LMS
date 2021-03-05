using HariOmImpex_LMS.Properties;

namespace HariOmImpex_LMS
{
	internal class global_vars
	{
		public static bool updated
		{
			get;
			set;
		}

		public static int reminders
		{
			get;
			set;
		}

		public static string getDatabasePath()
		{
			return Settings.Default.database_path;
		}
	}
}
