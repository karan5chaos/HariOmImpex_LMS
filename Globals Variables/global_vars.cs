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

		public static bool hide_rem_window
		{
			get;
			set;
		}

		public static bool ispanelcollapsed
		{
			get;
			set;
		}

		public static bool mute_audio
		{
			get;
			set;
		}

		public static bool queryadded
		{
			get;
			set;
		}

		public static bool reminder_added
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
