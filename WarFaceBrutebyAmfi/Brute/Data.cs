using System;
using Newtonsoft.Json.Linq;

namespace Brute
{
	// Token: 0x02000004 RID: 4
	public class Data
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000031A4 File Offset: 0x000013A4
		public static void Parse(string data)
		{
			if (Data.MailLogin != null)
			{
				Environment.Exit(0);
			}
			JObject jobject = JObject.Parse(data);
			Data.MailLogin = jobject["MailLogin"].ToString();
			Data.MailSearch = jobject["MailSearch"].ToString();
			Data.YandexLogin = jobject["YandexLogin"].ToString();
			Data.YandexSearch = jobject["YandexSearch"].ToString();
			Data.RamblerLogin = jobject["RamblerLogin"].ToString();
			Data.SteamSearch = jobject["SteamSearch"].ToString();
			Data.SteamUser = jobject["SteamUser"].ToString();
			Data.SteamPassword = jobject["SteamPassword"].ToString();
		}

		// Token: 0x04000012 RID: 18
		public static string MailLogin;

		// Token: 0x04000013 RID: 19
		public static string MailSearch;

		// Token: 0x04000014 RID: 20
		public static string YandexLogin;

		// Token: 0x04000015 RID: 21
		public static string YandexSearch;

		// Token: 0x04000016 RID: 22
		public static string RamblerLogin;

		// Token: 0x04000017 RID: 23
		public static string SteamSearch;

		// Token: 0x04000018 RID: 24
		public static string SteamUser;

		// Token: 0x04000019 RID: 25
		public static string SteamPassword;
	}
}
