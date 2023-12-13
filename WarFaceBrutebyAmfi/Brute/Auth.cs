using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using HardwareIdLib;
using Microsoft.Win32;
using SkinSoft.VisualStyler;
using SkinSoft.VisualStyler.Licensing;

namespace Brute
{
	// Token: 0x02000002 RID: 2
	public partial class Auth : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		public Auth()
		{
			if (this.VIFPIWFKCSVJMNAZLTFWY() || Auth.BCQOYPADLDVBANMKZJCNBP())
			{
				Environment.Exit(0);
			}
			this.AATCQEVSSBSIYRQUKFXXZD = new System.Timers.Timer();
			this.AATCQEVSSBSIYRQUKFXXZD.Interval = 3000.0;
			this.AATCQEVSSBSIYRQUKFXXZD.Start();
			this.ROWCFMGCREGXYQUVHVWNWU();
			this.ZURPMNMRJSQCGIDRXILJHO.Text = Auth.GetHwid();
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\SGC by Amfi_CRACKED");
			if (registryKey != null)
			{
				try
				{
					this.QKEPQEPUMZAQBYGWGVLZC.Text = (string)registryKey.GetValue("Skype");
				}
				catch
				{
				}
			}
			if (this.QKEPQEPUMZAQBYGWGVLZC.Text.Length > 3)
			{
				this.ZVFYMASJADMAVJOJSJIHGV.Enabled = false;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002140 File Offset: 0x00000340
		private bool VIFPIWFKCSVJMNAZLTFWY()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						string text = managementBaseObject["Manufacturer"].ToString().ToLower();
						if (text == "microsoft corporation" || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002230 File Offset: 0x00000430
		public static bool procIsRunning(string process)
		{
			foreach (Process process2 in Process.GetProcesses())
			{
				if (process2.ProcessName == process)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002274 File Offset: 0x00000474
		private static bool BCQOYPADLDVBANMKZJCNBP()
		{
			return Auth.procIsRunning("VBoxService");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002298 File Offset: 0x00000498
		private void JZLQOIJUQRQHLDPBVHGNOD(object sender, EventArgs e)
		{
			base.Hide();
			new Register().Show(this);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022AC File Offset: 0x000004AC
		private void RZBJUOJRCNELJINNARKM(object sender, EventArgs e)
		{
			if (this.QKEPQEPUMZAQBYGWGVLZC.Text.Length >= 3)
			{
				this.IUXJXJXMPQBYYEDJDRSAIP();
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022D8 File Offset: 0x000004D8
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

		// Token: 0x06000009 RID: 9 RVA: 0x00002378 File Offset: 0x00000578
		public static string GetMotherBoardID()
		{
			string text = string.Empty;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator();
			enumerator.MoveNext();
			text = enumerator.Current.Properties["SerialNumber"].Value.ToString();
			enumerator.Current.Properties.GetEnumerator();
			if (string.IsNullOrEmpty(text))
			{
				text = "0";
			}
			return text;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023F4 File Offset: 0x000005F4
		public static string GetHwid()
		{
			string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
			managementObject.Get();
			string str2 = managementObject["VolumeSerialNumber"].ToString();
			string text = HardwareId.Bios.GetBiosSerial() + HardwareId.Proccesor.GetProcessorId() + str2 + Auth.GetMotherBoardID();
			string text2 = string.Empty;
			foreach (char c in text)
			{
				text2 += (c ^ '\a' ^ '\u0003');
			}
			return Auth.MD5(Auth.MD5(text2) + "WarFacebyAmfi");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024B4 File Offset: 0x000006B4
		private void IUXJXJXMPQBYYEDJDRSAIP()
		{
			this.FLYPSZJXCWNAIHFPGTPXLP();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024C8 File Offset: 0x000006C8
		private void FLYPSZJXCWNAIHFPGTPXLP()
		{
			base.Hide();
			this.AATCQEVSSBSIYRQUKFXXZD.Stop();
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\SGC by Amfi_CRACKED");
				registryKey.SetValue("Skype", this.QKEPQEPUMZAQBYGWGVLZC.Text.Trim());
				registryKey.Close();
			}
			catch
			{
			}
			MainForm mainForm = new MainForm(this.QKEPQEPUMZAQBYGWGVLZC.Text.Trim());
			mainForm.InitializeComponent();
			mainForm.Show();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002550 File Offset: 0x00000750
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

		// Token: 0x0600000E RID: 14 RVA: 0x0000261C File Offset: 0x0000081C
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

		// Token: 0x0600000F RID: 15 RVA: 0x0000269C File Offset: 0x0000089C
		private string ZQHQFRTHUYHCOJRGLEMVOH(string ZESWUMIEEUPAATVDXHTWZM, int JOGZDUYKGBDGZHHZHASRG)
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(ZESWUMIEEUPAATVDXHTWZM, JOGZDUYKGBDGZHHZHASRG);
			string result = tcpClient.Client.RemoteEndPoint.ToString().Replace(":" + JOGZDUYKGBDGZHHZHASRG.ToString(), string.Empty);
			tcpClient.Close();
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000026EC File Offset: 0x000008EC
		private void BEHLPKFMACSREIAFPFDXQN(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000026F0 File Offset: 0x000008F0
		private void VRWMNFCNMGTJHRDFVDIDXJ(object sender, EventArgs e)
		{
			if (this.QKEPQEPUMZAQBYGWGVLZC.Text.Length > 3)
			{
				this.IUXJXJXMPQBYYEDJDRSAIP();
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000274C File Offset: 0x0000094C
		private void ROWCFMGCREGXYQUVHVWNWU()
		{
			this.MOZABQMOQVTAIXNZAJULQB = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Auth));
			this.VNYQLZZJVMKGQULUFLINQE = new Label();
			this.ZURPMNMRJSQCGIDRXILJHO = new TextBox();
			this.OLKBFYULXIGVXZPPHLFRF = new Label();
			this.QKEPQEPUMZAQBYGWGVLZC = new TextBox();
			this.AKAZHAVILPOIACKWLVTUH = new Button();
			this.ZVFYMASJADMAVJOJSJIHGV = new Button();
			this.VXULTBFBPQGQVTSOGIOZJD = new VisualStyler(this.MOZABQMOQVTAIXNZAJULQB);
			((ISupportInitialize)this.VXULTBFBPQGQVTSOGIOZJD).BeginInit();
			base.SuspendLayout();
			this.VNYQLZZJVMKGQULUFLINQE.AutoSize = true;
			this.VNYQLZZJVMKGQULUFLINQE.FlatStyle = FlatStyle.Flat;
			this.VNYQLZZJVMKGQULUFLINQE.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.VNYQLZZJVMKGQULUFLINQE.ForeColor = SystemColors.ControlText;
			this.VNYQLZZJVMKGQULUFLINQE.Location = new Point(12, 12);
			this.VNYQLZZJVMKGQULUFLINQE.Name = "label1";
			this.VNYQLZZJVMKGQULUFLINQE.Size = new Size(132, 13);
			this.VNYQLZZJVMKGQULUFLINQE.TabIndex = 0;
			this.VNYQLZZJVMKGQULUFLINQE.Text = "Уникальный ключ:";
			this.ZURPMNMRJSQCGIDRXILJHO.Location = new Point(154, 9);
			this.ZURPMNMRJSQCGIDRXILJHO.Name = "hwidBox";
			this.ZURPMNMRJSQCGIDRXILJHO.ReadOnly = true;
			this.ZURPMNMRJSQCGIDRXILJHO.Size = new Size(195, 20);
			this.ZURPMNMRJSQCGIDRXILJHO.TabIndex = 1;
			this.ZURPMNMRJSQCGIDRXILJHO.TabStop = false;
			this.ZURPMNMRJSQCGIDRXILJHO.TextAlign = HorizontalAlignment.Center;
			this.OLKBFYULXIGVXZPPHLFRF.AutoSize = true;
			this.OLKBFYULXIGVXZPPHLFRF.FlatStyle = FlatStyle.Flat;
			this.OLKBFYULXIGVXZPPHLFRF.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.OLKBFYULXIGVXZPPHLFRF.ForeColor = SystemColors.ControlText;
			this.OLKBFYULXIGVXZPPHLFRF.Location = new Point(12, 37);
			this.OLKBFYULXIGVXZPPHLFRF.Name = "label2";
			this.OLKBFYULXIGVXZPPHLFRF.Size = new Size(92, 13);
			this.OLKBFYULXIGVXZPPHLFRF.TabIndex = 2;
			this.OLKBFYULXIGVXZPPHLFRF.Text = "Skype логин:";
			this.QKEPQEPUMZAQBYGWGVLZC.ForeColor = SystemColors.ControlText;
			this.QKEPQEPUMZAQBYGWGVLZC.Location = new Point(154, 34);
			this.QKEPQEPUMZAQBYGWGVLZC.Name = "skypeBox";
			this.QKEPQEPUMZAQBYGWGVLZC.Size = new Size(195, 20);
			this.QKEPQEPUMZAQBYGWGVLZC.TabIndex = 3;
			this.QKEPQEPUMZAQBYGWGVLZC.TabStop = false;
			this.QKEPQEPUMZAQBYGWGVLZC.TextAlign = HorizontalAlignment.Center;
			this.QKEPQEPUMZAQBYGWGVLZC.Text = "PC-RET";
			this.QKEPQEPUMZAQBYGWGVLZC.TextChanged += this.BEHLPKFMACSREIAFPFDXQN;
			this.AKAZHAVILPOIACKWLVTUH.FlatStyle = FlatStyle.Flat;
			this.AKAZHAVILPOIACKWLVTUH.ForeColor = Color.Green;
			this.AKAZHAVILPOIACKWLVTUH.Location = new Point(15, 62);
			this.AKAZHAVILPOIACKWLVTUH.Name = "button1";
			this.AKAZHAVILPOIACKWLVTUH.Size = new Size(133, 29);
			this.AKAZHAVILPOIACKWLVTUH.TabIndex = 4;
			this.AKAZHAVILPOIACKWLVTUH.TabStop = false;
			this.AKAZHAVILPOIACKWLVTUH.Text = "Авторизироваться";
			this.AKAZHAVILPOIACKWLVTUH.UseVisualStyleBackColor = true;
			this.AKAZHAVILPOIACKWLVTUH.Click += this.RZBJUOJRCNELJINNARKM;
			this.ZVFYMASJADMAVJOJSJIHGV.FlatStyle = FlatStyle.Flat;
			this.ZVFYMASJADMAVJOJSJIHGV.ForeColor = Color.Green;
			this.ZVFYMASJADMAVJOJSJIHGV.Location = new Point(154, 62);
			this.ZVFYMASJADMAVJOJSJIHGV.Name = "button2";
			this.ZVFYMASJADMAVJOJSJIHGV.Size = new Size(195, 29);
			this.ZVFYMASJADMAVJOJSJIHGV.TabIndex = 5;
			this.ZVFYMASJADMAVJOJSJIHGV.TabStop = false;
			this.ZVFYMASJADMAVJOJSJIHGV.Text = "Регистрация программы";
			this.ZVFYMASJADMAVJOJSJIHGV.UseVisualStyleBackColor = true;
			this.ZVFYMASJADMAVJOJSJIHGV.Click += this.JZLQOIJUQRQHLDPBVHGNOD;
			this.VXULTBFBPQGQVTSOGIOZJD.License = (VisualStylerLicense)componentResourceManager.GetObject("visualStyler1.License");
			this.VXULTBFBPQGQVTSOGIOZJD.LoadVisualStyle(null, "Aqunaox (Shallow2).vssf");
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(353, 96);
			base.Controls.Add(this.ZVFYMASJADMAVJOJSJIHGV);
			base.Controls.Add(this.AKAZHAVILPOIACKWLVTUH);
			base.Controls.Add(this.QKEPQEPUMZAQBYGWGVLZC);
			base.Controls.Add(this.OLKBFYULXIGVXZPPHLFRF);
			base.Controls.Add(this.ZURPMNMRJSQCGIDRXILJHO);
			base.Controls.Add(this.VNYQLZZJVMKGQULUFLINQE);
			base.FormBorderStyle = FormBorderStyle.Fixed3D;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Auth";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Авторизация Warface - Брутфорс\\Чекер";
			base.Shown += this.VRWMNFCNMGTJHRDFVDIDXJ;
			((ISupportInitialize)this.VXULTBFBPQGQVTSOGIOZJD).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C98 File Offset: 0x00000E98
		[CompilerGenerated]
		private static char QRYOLOGESBWZRWWGJGHBOK(char FZUNSIZQQGBKIZQSKYRRL)
		{
			return FZUNSIZQQGBKIZQSKYRRL ^ '\u0003';
		}

		// Token: 0x04000001 RID: 1
		private System.Timers.Timer AATCQEVSSBSIYRQUKFXXZD;

		// Token: 0x04000003 RID: 3
		private Label VNYQLZZJVMKGQULUFLINQE;

		// Token: 0x04000004 RID: 4
		private TextBox ZURPMNMRJSQCGIDRXILJHO;

		// Token: 0x04000005 RID: 5
		private Label OLKBFYULXIGVXZPPHLFRF;

		// Token: 0x04000006 RID: 6
		private TextBox QKEPQEPUMZAQBYGWGVLZC;

		// Token: 0x04000007 RID: 7
		private Button AKAZHAVILPOIACKWLVTUH;

		// Token: 0x04000008 RID: 8
		private Button ZVFYMASJADMAVJOJSJIHGV;

		// Token: 0x04000009 RID: 9
		private VisualStyler VXULTBFBPQGQVTSOGIOZJD;

		// Token: 0x0400000A RID: 10
		[CompilerGenerated]
		private static Func<char, char> LWEFZJUAALHVONXTVFQGOI;
	}
}
