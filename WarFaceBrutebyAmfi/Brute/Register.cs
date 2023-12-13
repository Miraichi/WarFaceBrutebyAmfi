using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using SkinSoft.VisualStyler;
using xNet.Net;

namespace Brute
{
	// Token: 0x02000010 RID: 16
	public partial class Register : Form
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00007D0C File Offset: 0x00005F0C
		public Register()
		{
			if (Register.LWEFZJUAALHVONXTVFQGOI == null)
			{
				Register.LWEFZJUAALHVONXTVFQGOI = new ThreadExceptionEventHandler(Register.QWYKZUOZPQOGTTUNWUDTQO);
			}
			Application.ThreadException += Register.LWEFZJUAALHVONXTVFQGOI;
			this.ROWCFMGCREGXYQUVHVWNWU();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00007D3C File Offset: 0x00005F3C
		private void ROWCFMGCREGXYQUVHVWNWU()
		{
			this.MOZABQMOQVTAIXNZAJULQB = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Register));
			this.EOHQKZANYPAHGROWSSUUDI = new TextBox();
			this.VNYQLZZJVMKGQULUFLINQE = new Label();
			this.ZVFYMASJADMAVJOJSJIHGV = new Button();
			this.OLKBFYULXIGVXZPPHLFRF = new Label();
			this.WJYJJTGOZUHKOHQRDDGJTS = new Label();
			this.VXULTBFBPQGQVTSOGIOZJD = new VisualStyler(this.MOZABQMOQVTAIXNZAJULQB);
			this.QKEPQEPUMZAQBYGWGVLZC = new TextBox();
			this.PRVDJRIAYLHLYXRKQIOHNE = new Label();
			this.ETDRBSYIOQKJUABAZTRYFC = new Button();
			this.TWQHZDTMDYQUVDLDZZRTOL = new TextBox();
			this.LGJJXZIVZXXZPSIXEDKQX = new Label();
			((ISupportInitialize)this.VXULTBFBPQGQVTSOGIOZJD).BeginInit();
			base.SuspendLayout();
			this.EOHQKZANYPAHGROWSSUUDI.BackColor = SystemColors.Window;
			this.EOHQKZANYPAHGROWSSUUDI.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.EOHQKZANYPAHGROWSSUUDI.ForeColor = SystemColors.ControlText;
			this.EOHQKZANYPAHGROWSSUUDI.Location = new Point(199, 10);
			this.EOHQKZANYPAHGROWSSUUDI.MaxLength = 19;
			this.EOHQKZANYPAHGROWSSUUDI.Name = "keyBox";
			this.EOHQKZANYPAHGROWSSUUDI.Size = new Size(192, 21);
			this.EOHQKZANYPAHGROWSSUUDI.TabIndex = 1;
			this.EOHQKZANYPAHGROWSSUUDI.TabStop = false;
			this.EOHQKZANYPAHGROWSSUUDI.TextAlign = HorizontalAlignment.Center;
			this.EOHQKZANYPAHGROWSSUUDI.TextChanged += this.OCXEZCCWVCRSCAEADAVKQP;
			this.VNYQLZZJVMKGQULUFLINQE.AutoSize = true;
			this.VNYQLZZJVMKGQULUFLINQE.FlatStyle = FlatStyle.Flat;
			this.VNYQLZZJVMKGQULUFLINQE.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.VNYQLZZJVMKGQULUFLINQE.ForeColor = SystemColors.ControlText;
			this.VNYQLZZJVMKGQULUFLINQE.Location = new Point(12, 13);
			this.VNYQLZZJVMKGQULUFLINQE.Name = "label1";
			this.VNYQLZZJVMKGQULUFLINQE.Size = new Size(142, 13);
			this.VNYQLZZJVMKGQULUFLINQE.TabIndex = 2;
			this.VNYQLZZJVMKGQULUFLINQE.Text = "Введите ваш ключ : ";
			this.ZVFYMASJADMAVJOJSJIHGV.FlatStyle = FlatStyle.Flat;
			this.ZVFYMASJADMAVJOJSJIHGV.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.ZVFYMASJADMAVJOJSJIHGV.ForeColor = Color.Green;
			this.ZVFYMASJADMAVJOJSJIHGV.Location = new Point(183, 95);
			this.ZVFYMASJADMAVJOJSJIHGV.Name = "button2";
			this.ZVFYMASJADMAVJOJSJIHGV.Size = new Size(208, 27);
			this.ZVFYMASJADMAVJOJSJIHGV.TabIndex = 5;
			this.ZVFYMASJADMAVJOJSJIHGV.TabStop = false;
			this.ZVFYMASJADMAVJOJSJIHGV.Text = "Закрыть окно регистрации";
			this.ZVFYMASJADMAVJOJSJIHGV.UseVisualStyleBackColor = true;
			this.ZVFYMASJADMAVJOJSJIHGV.Click += this.JZLQOIJUQRQHLDPBVHGNOD;
			this.OLKBFYULXIGVXZPPHLFRF.AutoSize = true;
			this.OLKBFYULXIGVXZPPHLFRF.FlatStyle = FlatStyle.Flat;
			this.OLKBFYULXIGVXZPPHLFRF.Location = new Point(14, 133);
			this.OLKBFYULXIGVXZPPHLFRF.Name = "label2";
			this.OLKBFYULXIGVXZPPHLFRF.Size = new Size(121, 13);
			this.OLKBFYULXIGVXZPPHLFRF.TabIndex = 6;
			this.OLKBFYULXIGVXZPPHLFRF.Text = "Версия программы : ?";
			this.WJYJJTGOZUHKOHQRDDGJTS.AutoSize = true;
			this.WJYJJTGOZUHKOHQRDDGJTS.FlatStyle = FlatStyle.Flat;
			this.WJYJJTGOZUHKOHQRDDGJTS.Location = new Point(182, 133);
			this.WJYJJTGOZUHKOHQRDDGJTS.Name = "label3";
			this.WJYJJTGOZUHKOHQRDDGJTS.Size = new Size(182, 13);
			this.WJYJJTGOZUHKOHQRDDGJTS.TabIndex = 7;
			this.WJYJJTGOZUHKOHQRDDGJTS.Text = "Актуальная версия программы : ?";
			this.VXULTBFBPQGQVTSOGIOZJD.License = null;
			this.VXULTBFBPQGQVTSOGIOZJD.LoadVisualStyle("Office2007 (Blue).vssf");
			this.QKEPQEPUMZAQBYGWGVLZC.ForeColor = SystemColors.ControlText;
			this.QKEPQEPUMZAQBYGWGVLZC.Location = new Point(199, 37);
			this.QKEPQEPUMZAQBYGWGVLZC.MaxLength = 50;
			this.QKEPQEPUMZAQBYGWGVLZC.Name = "skypeBox";
			this.QKEPQEPUMZAQBYGWGVLZC.Size = new Size(192, 20);
			this.QKEPQEPUMZAQBYGWGVLZC.TabIndex = 9;
			this.QKEPQEPUMZAQBYGWGVLZC.TabStop = false;
			this.QKEPQEPUMZAQBYGWGVLZC.TextAlign = HorizontalAlignment.Center;
			this.QKEPQEPUMZAQBYGWGVLZC.TextChanged += this.BEHLPKFMACSREIAFPFDXQN;
			this.PRVDJRIAYLHLYXRKQIOHNE.AutoSize = true;
			this.PRVDJRIAYLHLYXRKQIOHNE.FlatStyle = FlatStyle.Flat;
			this.PRVDJRIAYLHLYXRKQIOHNE.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.PRVDJRIAYLHLYXRKQIOHNE.ForeColor = SystemColors.ControlText;
			this.PRVDJRIAYLHLYXRKQIOHNE.Location = new Point(12, 40);
			this.PRVDJRIAYLHLYXRKQIOHNE.Name = "label4";
			this.PRVDJRIAYLHLYXRKQIOHNE.Size = new Size(186, 13);
			this.PRVDJRIAYLHLYXRKQIOHNE.TabIndex = 10;
			this.PRVDJRIAYLHLYXRKQIOHNE.Text = "Введите ваш скайп логин : ";
			this.ETDRBSYIOQKJUABAZTRYFC.FlatStyle = FlatStyle.Flat;
			this.ETDRBSYIOQKJUABAZTRYFC.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.ETDRBSYIOQKJUABAZTRYFC.ForeColor = Color.Green;
			this.ETDRBSYIOQKJUABAZTRYFC.Location = new Point(6, 95);
			this.ETDRBSYIOQKJUABAZTRYFC.Name = "button3";
			this.ETDRBSYIOQKJUABAZTRYFC.Size = new Size(171, 27);
			this.ETDRBSYIOQKJUABAZTRYFC.TabIndex = 12;
			this.ETDRBSYIOQKJUABAZTRYFC.TabStop = false;
			this.ETDRBSYIOQKJUABAZTRYFC.Text = "Зарегистрироваться !";
			this.ETDRBSYIOQKJUABAZTRYFC.UseVisualStyleBackColor = true;
			this.ETDRBSYIOQKJUABAZTRYFC.Click += this.JGBDVCDJFBUDZLFWRHXUOS;
			this.TWQHZDTMDYQUVDLDZZRTOL.ForeColor = SystemColors.ControlText;
			this.TWQHZDTMDYQUVDLDZZRTOL.Location = new Point(199, 63);
			this.TWQHZDTMDYQUVDLDZZRTOL.MaxLength = 30;
			this.TWQHZDTMDYQUVDLDZZRTOL.Name = "payinfobox";
			this.TWQHZDTMDYQUVDLDZZRTOL.Size = new Size(192, 20);
			this.TWQHZDTMDYQUVDLDZZRTOL.TabIndex = 13;
			this.TWQHZDTMDYQUVDLDZZRTOL.TabStop = false;
			this.TWQHZDTMDYQUVDLDZZRTOL.TextAlign = HorizontalAlignment.Center;
			this.LGJJXZIVZXXZPSIXEDKQX.AutoSize = true;
			this.LGJJXZIVZXXZPSIXEDKQX.FlatStyle = FlatStyle.Flat;
			this.LGJJXZIVZXXZPSIXEDKQX.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.LGJJXZIVZXXZPSIXEDKQX.ForeColor = SystemColors.ControlText;
			this.LGJJXZIVZXXZPSIXEDKQX.Location = new Point(12, 66);
			this.LGJJXZIVZXXZPSIXEDKQX.Name = "label5";
			this.LGJJXZIVZXXZPSIXEDKQX.Size = new Size(165, 13);
			this.LGJJXZIVZXXZPSIXEDKQX.TabIndex = 14;
			this.LGJJXZIVZXXZPSIXEDKQX.Text = "Введите ваш кошелек : ";
			base.ClientSize = new Size(395, 151);
			base.ControlBox = false;
			base.Controls.Add(this.LGJJXZIVZXXZPSIXEDKQX);
			base.Controls.Add(this.TWQHZDTMDYQUVDLDZZRTOL);
			base.Controls.Add(this.ETDRBSYIOQKJUABAZTRYFC);
			base.Controls.Add(this.PRVDJRIAYLHLYXRKQIOHNE);
			base.Controls.Add(this.QKEPQEPUMZAQBYGWGVLZC);
			base.Controls.Add(this.WJYJJTGOZUHKOHQRDDGJTS);
			base.Controls.Add(this.OLKBFYULXIGVXZPPHLFRF);
			base.Controls.Add(this.ZVFYMASJADMAVJOJSJIHGV);
			base.Controls.Add(this.VNYQLZZJVMKGQULUFLINQE);
			base.Controls.Add(this.EOHQKZANYPAHGROWSSUUDI);
			base.FormBorderStyle = FormBorderStyle.Fixed3D;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Register";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Регистрация WarFace Brute&Checker by Amfi [xTc inc. Soft]";
			base.FormClosing += this.PXILYRLWCCDMFKBAIFEWEQ;
			base.Load += this.VIIHILQPZAJRGIBBGYJWCN;
			((ISupportInitialize)this.VXULTBFBPQGQVTSOGIOZJD).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008580 File Offset: 0x00006780
		private string HEVZCOPDBGLIEZDHLMBXH(string PTWFVZGJBYXFYWTZSMPVJ)
		{
			string text = string.Empty;
			foreach (char c in PTWFVZGJBYXFYWTZSMPVJ)
			{
				text += (c ^ '\u0001');
			}
			return text;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000085C8 File Offset: 0x000067C8
		private string ZQHQFRTHUYHCOJRGLEMVOH(string ZESWUMIEEUPAATVDXHTWZM, int JOGZDUYKGBDGZHHZHASRG)
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(ZESWUMIEEUPAATVDXHTWZM, JOGZDUYKGBDGZHHZHASRG);
			string result = tcpClient.Client.RemoteEndPoint.ToString().Replace(":" + JOGZDUYKGBDGZHHZHASRG.ToString(), string.Empty);
			tcpClient.Close();
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008618 File Offset: 0x00006818
		private LoopStream QNSWXOHKKRRXAGIAVBXJIC(Stream GOHGMXNALOGTYTNZESNPDF)
		{
			WaveStream sourceStream = new Mp3FileReader(GOHGMXNALOGTYTNZESNPDF);
			return new LoopStream(sourceStream);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008634 File Offset: 0x00006834
		private void VIIHILQPZAJRGIBBGYJWCN(object sender, EventArgs e)
		{
			this.LNFBLVNAAIISUQFAOQZSDS();
			try
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("ActivationSong.mp3");
				LoopStream waveProvider = this.QNSWXOHKKRRXAGIAVBXJIC(manifestResourceStream);
				this.UJRCISLAFKSFARZMDIORGB = new WaveOut();
				this.UJRCISLAFKSFARZMDIORGB.Init(waveProvider);
				this.UJRCISLAFKSFARZMDIORGB.Play();
			}
			catch
			{
			}
			try
			{
				string b = this.ZQHQFRTHUYHCOJRGLEMVOH("amfi-network.ru", 80);
				string a = this.ZQHQFRTHUYHCOJRGLEMVOH("winmskhost2.ispserver.com", 443);
				if (a != b)
				{
					Application.Exit();
				}
			}
			catch (Exception)
			{
				Application.Exit();
			}
			base.ControlBox = false;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000086E8 File Offset: 0x000068E8
		public static string MD5(string password)
		{
			byte[] bytes = Encoding.Default.GetBytes(password);
			string result;
			try
			{
				byte[] array = new MD5CryptoServiceProvider().ComputeHash(bytes);
				string text = "";
				foreach (byte b in array)
				{
					if (b < 16)
					{
						text = text + "0" + b.ToString("x");
					}
					else
					{
						text += b.ToString("x");
					}
				}
				result = text;
			}
			catch
			{
				throw;
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008788 File Offset: 0x00006988
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

		// Token: 0x06000076 RID: 118 RVA: 0x000088A4 File Offset: 0x00006AA4
		private void LNFBLVNAAIISUQFAOQZSDS()
		{
			try
			{
				HttpRequest httpRequest = new HttpRequest();
				string version = httpRequest.Get("http://amfi-network.ru/WarFaceVersion.php", null).ToString();
				Version version2 = Assembly.GetExecutingAssembly().GetName().Version;
				Version arg = new Version(version);
				this.OLKBFYULXIGVXZPPHLFRF.Text = "Версия программы : " + version2;
				this.WJYJJTGOZUHKOHQRDDGJTS.Text = "Актуальная версия программы : " + arg;
			}
			catch
			{
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008924 File Offset: 0x00006B24
		private void JZLQOIJUQRQHLDPBVHGNOD(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000892C File Offset: 0x00006B2C
		private void PXILYRLWCCDMFKBAIFEWEQ(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (this.UJRCISLAFKSFARZMDIORGB != null)
				{
					this.UJRCISLAFKSFARZMDIORGB.Stop();
					this.UJRCISLAFKSFARZMDIORGB.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008970 File Offset: 0x00006B70
		private void JDQUXJBRPKHZGNLQAHVJP(object sender, LinkClickedEventArgs e)
		{
			Process.Start(e.LinkText);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00008980 File Offset: 0x00006B80
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

		// Token: 0x0600007B RID: 123 RVA: 0x00008A4C File Offset: 0x00006C4C
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

		// Token: 0x0600007C RID: 124 RVA: 0x00008ACC File Offset: 0x00006CCC
		private void JGBDVCDJFBUDZLFWRHXUOS(object sender, EventArgs e)
		{
			if (this.QKEPQEPUMZAQBYGWGVLZC.Text.Length < 3 || this.EOHQKZANYPAHGROWSSUUDI.Text.Length < 16 || this.TWQHZDTMDYQUVDLDZZRTOL.Text.Length < 7)
			{
				MessageBox.Show("Ошибка регистрации", "WarFace by Amfi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				try
				{
					string b = this.ZQHQFRTHUYHCOJRGLEMVOH("amfi-network.ru", 80);
					string a = this.ZQHQFRTHUYHCOJRGLEMVOH("winmskhost2.ispserver.com", 443);
					if (a != b)
					{
						throw new Exception("Не удалось загрузить информацию с сервера.");
					}
					string text = Register.FDDXMTRZEPLCDBPQYBMSMH(256);
					HttpRequest httpRequest = new HttpRequest();
					httpRequest.AddHeader("User-Agent", "WarFaceLic/1.0");
					httpRequest.AddParam("h", Auth.GetHwid());
					httpRequest.AddParam("d", text);
					httpRequest.AddParam("s", this.QKEPQEPUMZAQBYGWGVLZC.Text.Trim());
					httpRequest.AddParam("k", this.EOHQKZANYPAHGROWSSUUDI.Text.Trim());
					httpRequest.AddParam("i", this.TWQHZDTMDYQUVDLDZZRTOL.Text.Trim());
					HttpResponse httpResponse = httpRequest.Post("http://amfi-network.ru/warface/Register.aspx");
					string text2 = httpResponse.ToString();
					if (!httpResponse.Headers.ContainsKey("X-Powered-By"))
					{
						throw new Exception("Не удалось загрузить информацию с сервера.");
					}
					text2 = Register.IXJWWHOQSOBNKBHBQFHDUQ(text2, text, 256);
					if (text2.Contains("Register successful"))
					{
						MessageBox.Show("Успешно зарегестрировались", "WarFace by Amfi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						base.Owner.Show();
						base.Close();
					}
					else if (text2.Contains("Skype already exists"))
					{
						MessageBox.Show("Пользователь с таким скайпом уже существует", "WarFace by Amfi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else if (text2.Contains("Key not found"))
					{
						MessageBox.Show("Неправильный ключ активации", "WarFace by Amfi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Критическая ошибка. Сообщение - " + ex.Message, "WarFace by Amfi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008D08 File Offset: 0x00006F08
		private void BEHLPKFMACSREIAFPFDXQN(object sender, EventArgs e)
		{
			this.QKEPQEPUMZAQBYGWGVLZC.Text = Regex.Replace(this.QKEPQEPUMZAQBYGWGVLZC.Text, "[^a-zA-Z0-9-]", "");
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008D30 File Offset: 0x00006F30
		private void OCXEZCCWVCRSCAEADAVKQP(object sender, EventArgs e)
		{
			this.EOHQKZANYPAHGROWSSUUDI.Text = Regex.Replace(this.EOHQKZANYPAHGROWSSUUDI.Text, "[^a-zA-Z0-9-]", "");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008D58 File Offset: 0x00006F58
		[CompilerGenerated]
		private static void QWYKZUOZPQOGTTUNWUDTQO(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message);
		}

		// Token: 0x04000079 RID: 121
		private Label VNYQLZZJVMKGQULUFLINQE;

		// Token: 0x0400007A RID: 122
		private Button ZVFYMASJADMAVJOJSJIHGV;

		// Token: 0x0400007B RID: 123
		private IContainer MOZABQMOQVTAIXNZAJULQB;

		// Token: 0x0400007C RID: 124
		private Label OLKBFYULXIGVXZPPHLFRF;

		// Token: 0x0400007D RID: 125
		private Label WJYJJTGOZUHKOHQRDDGJTS;

		// Token: 0x0400007E RID: 126
		private VisualStyler VXULTBFBPQGQVTSOGIOZJD;

		// Token: 0x0400007F RID: 127
		private TextBox QKEPQEPUMZAQBYGWGVLZC;

		// Token: 0x04000080 RID: 128
		private Label PRVDJRIAYLHLYXRKQIOHNE;

		// Token: 0x04000081 RID: 129
		private Button ETDRBSYIOQKJUABAZTRYFC;

		// Token: 0x04000082 RID: 130
		private TextBox TWQHZDTMDYQUVDLDZZRTOL;

		// Token: 0x04000083 RID: 131
		private Label LGJJXZIVZXXZPSIXEDKQX;

		// Token: 0x04000084 RID: 132
		private TextBox EOHQKZANYPAHGROWSSUUDI;

		// Token: 0x04000085 RID: 133
		private WaveOut UJRCISLAFKSFARZMDIORGB;

		// Token: 0x04000086 RID: 134
		[CompilerGenerated]
		private static ThreadExceptionEventHandler LWEFZJUAALHVONXTVFQGOI;
	}
}
