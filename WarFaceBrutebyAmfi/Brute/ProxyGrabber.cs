using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using xNet.Net;

namespace Brute
{
	// Token: 0x0200000F RID: 15
	public partial class ProxyGrabber : Form
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00006B58 File Offset: 0x00004D58
		public ProxyGrabber()
		{
			if (ProxyGrabber.LWEFZJUAALHVONXTVFQGOI == null)
			{
				ProxyGrabber.LWEFZJUAALHVONXTVFQGOI = new ThreadExceptionEventHandler(ProxyGrabber.QWYKZUOZPQOGTTUNWUDTQO);
			}
			Application.ThreadException += ProxyGrabber.LWEFZJUAALHVONXTVFQGOI;
			this.ROWCFMGCREGXYQUVHVWNWU();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006BB8 File Offset: 0x00004DB8
		private void ORLSFQNULBDHGJLCIWHNAD(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006BBC File Offset: 0x00004DBC
		private void RPERDWUKHVSQXYBFQDRSG(object sender, FormClosingEventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006BC4 File Offset: 0x00004DC4
		private void QFSNQMYPACBOPGYCQVREYF(object sender, EventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006BC8 File Offset: 0x00004DC8
		private void EMGEDFAZTULYZFSJBSGQLP(object sender, EventArgs e)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006BCC File Offset: 0x00004DCC
		private void GNSMYKOIBMVLQDGBRIZJVX(object sender, EventArgs e)
		{
			base.Height = 240;
			base.Width = 145;
			this.CYLXNLWRVGMNMZFDECIFJV.Visible = true;
			this.DAXOMITYZMJMTCXXPIAAMC.Visible = true;
			this.QBWZTDJTVRLWGYSSVCHLTD.Width = 131;
			this.QBWZTDJTVRLWGYSSVCHLTD.Height = 170;
			this.GQIFDAYGLGIRXOVWKVYTH.Visible = true;
			if (this.EJDODWVQEMBEHJMPKRRIGZ.Checked)
			{
				this.CYLXNLWRVGMNMZFDECIFJV.PasswordChar = '*';
				this.CYLXNLWRVGMNMZFDECIFJV.Text = "741607401";
			}
			else
			{
				this.CYLXNLWRVGMNMZFDECIFJV.Clear();
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006C70 File Offset: 0x00004E70
		private void ROWCFMGCREGXYQUVHVWNWU()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProxyGrabber));
			this.AJQOXTRRQTQXKMEXUBGZTV = new GroupBox();
			this.ENIECBKFPKZMEUUVUFTPIO = new RichTextBox();
			this.KWXLMFYYTUDQPTWUBRONA = new Button();
			this.QBWZTDJTVRLWGYSSVCHLTD = new GroupBox();
			this.CJGHRNTNQROVCDMZCIPAPF = new RadioButton();
			this.DAXOMITYZMJMTCXXPIAAMC = new Label();
			this.CYLXNLWRVGMNMZFDECIFJV = new TextBox();
			this.EJDODWVQEMBEHJMPKRRIGZ = new RadioButton();
			this.DQMWMUKLJKOSDABJNWPAI = new RadioButton();
			this.SZSZQWHGGGAZBSWHGCIHZP = new NumericUpDown();
			this.BCSGOPBAAFCCKETPHTSQXN = new Label();
			this.QIAMGTNNSUGVLTUIIRCAMQ = new GroupBox();
			this.PTDHITZQMFWPKNIHZKJOUX = new RichTextBox();
			this.GQIFDAYGLGIRXOVWKVYTH = new ComboBox();
			this.AJQOXTRRQTQXKMEXUBGZTV.SuspendLayout();
			this.QBWZTDJTVRLWGYSSVCHLTD.SuspendLayout();
			((ISupportInitialize)this.SZSZQWHGGGAZBSWHGCIHZP).BeginInit();
			this.QIAMGTNNSUGVLTUIIRCAMQ.SuspendLayout();
			base.SuspendLayout();
			this.AJQOXTRRQTQXKMEXUBGZTV.Controls.Add(this.ENIECBKFPKZMEUUVUFTPIO);
			this.AJQOXTRRQTQXKMEXUBGZTV.FlatStyle = FlatStyle.Flat;
			this.AJQOXTRRQTQXKMEXUBGZTV.Location = new Point(299, 2);
			this.AJQOXTRRQTQXKMEXUBGZTV.Name = "groupBox1";
			this.AJQOXTRRQTQXKMEXUBGZTV.Size = new Size(178, 201);
			this.AJQOXTRRQTQXKMEXUBGZTV.TabIndex = 21;
			this.AJQOXTRRQTQXKMEXUBGZTV.TabStop = false;
			this.AJQOXTRRQTQXKMEXUBGZTV.Text = "Ссылки :";
			this.AJQOXTRRQTQXKMEXUBGZTV.Enter += this.QFSNQMYPACBOPGYCQVREYF;
			this.ENIECBKFPKZMEUUVUFTPIO.BackColor = SystemColors.ControlLightLight;
			this.ENIECBKFPKZMEUUVUFTPIO.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.ENIECBKFPKZMEUUVUFTPIO.Location = new Point(6, 15);
			this.ENIECBKFPKZMEUUVUFTPIO.Name = "ssylbox";
			this.ENIECBKFPKZMEUUVUFTPIO.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
			this.ENIECBKFPKZMEUUVUFTPIO.Size = new Size(166, 180);
			this.ENIECBKFPKZMEUUVUFTPIO.TabIndex = 1;
			this.ENIECBKFPKZMEUUVUFTPIO.Text = componentResourceManager.GetString("ssylbox.Text");
			this.KWXLMFYYTUDQPTWUBRONA.FlatStyle = FlatStyle.Flat;
			this.KWXLMFYYTUDQPTWUBRONA.Location = new Point(3, 174);
			this.KWXLMFYYTUDQPTWUBRONA.Name = "start";
			this.KWXLMFYYTUDQPTWUBRONA.Size = new Size(131, 29);
			this.KWXLMFYYTUDQPTWUBRONA.TabIndex = 20;
			this.KWXLMFYYTUDQPTWUBRONA.Text = "Сграбить";
			this.KWXLMFYYTUDQPTWUBRONA.UseVisualStyleBackColor = true;
			this.KWXLMFYYTUDQPTWUBRONA.Click += this.PHLCOQRMHLMCNIFXDLAGHP;
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.CJGHRNTNQROVCDMZCIPAPF);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.EJDODWVQEMBEHJMPKRRIGZ);
			this.QBWZTDJTVRLWGYSSVCHLTD.Controls.Add(this.DQMWMUKLJKOSDABJNWPAI);
			this.QBWZTDJTVRLWGYSSVCHLTD.FlatStyle = FlatStyle.Flat;
			this.QBWZTDJTVRLWGYSSVCHLTD.Location = new Point(3, 2);
			this.QBWZTDJTVRLWGYSSVCHLTD.Name = "groupBox2";
			this.QBWZTDJTVRLWGYSSVCHLTD.Size = new Size(131, 76);
			this.QBWZTDJTVRLWGYSSVCHLTD.TabIndex = 19;
			this.QBWZTDJTVRLWGYSSVCHLTD.TabStop = false;
			this.QBWZTDJTVRLWGYSSVCHLTD.Text = "Настройки";
			this.QBWZTDJTVRLWGYSSVCHLTD.Enter += this.EMGEDFAZTULYZFSJBSGQLP;
			this.CJGHRNTNQROVCDMZCIPAPF.AutoSize = true;
			this.CJGHRNTNQROVCDMZCIPAPF.FlatStyle = FlatStyle.Flat;
			this.CJGHRNTNQROVCDMZCIPAPF.Location = new Point(5, 50);
			this.CJGHRNTNQROVCDMZCIPAPF.Name = "grabb_ssyl";
			this.CJGHRNTNQROVCDMZCIPAPF.Size = new Size(89, 17);
			this.CJGHRNTNQROVCDMZCIPAPF.TabIndex = 11;
			this.CJGHRNTNQROVCDMZCIPAPF.Text = "По ссылкам";
			this.CJGHRNTNQROVCDMZCIPAPF.UseVisualStyleBackColor = true;
			this.CJGHRNTNQROVCDMZCIPAPF.CheckedChanged += this.WOCKBUDWKVCKORPWUJEJU;
			this.DAXOMITYZMJMTCXXPIAAMC.AutoSize = true;
			this.DAXOMITYZMJMTCXXPIAAMC.FlatStyle = FlatStyle.Flat;
			this.DAXOMITYZMJMTCXXPIAAMC.Location = new Point(12, 81);
			this.DAXOMITYZMJMTCXXPIAAMC.Name = "keylabels";
			this.DAXOMITYZMJMTCXXPIAAMC.Size = new Size(98, 13);
			this.DAXOMITYZMJMTCXXPIAAMC.TabIndex = 3;
			this.DAXOMITYZMJMTCXXPIAAMC.Text = "Ключ активации";
			this.CYLXNLWRVGMNMZFDECIFJV.BackColor = SystemColors.ButtonFace;
			this.CYLXNLWRVGMNMZFDECIFJV.Location = new Point(8, 98);
			this.CYLXNLWRVGMNMZFDECIFJV.Name = "keybox";
			this.CYLXNLWRVGMNMZFDECIFJV.PasswordChar = '*';
			this.CYLXNLWRVGMNMZFDECIFJV.Size = new Size(122, 22);
			this.CYLXNLWRVGMNMZFDECIFJV.TabIndex = 2;
			this.EJDODWVQEMBEHJMPKRRIGZ.AutoSize = true;
			this.EJDODWVQEMBEHJMPKRRIGZ.FlatStyle = FlatStyle.Flat;
			this.EJDODWVQEMBEHJMPKRRIGZ.Location = new Point(5, 33);
			this.EJDODWVQEMBEHJMPKRRIGZ.Name = "hideme";
			this.EJDODWVQEMBEHJMPKRRIGZ.Size = new Size(77, 17);
			this.EJDODWVQEMBEHJMPKRRIGZ.TabIndex = 1;
			this.EJDODWVQEMBEHJMPKRRIGZ.Text = "hideme.ru";
			this.EJDODWVQEMBEHJMPKRRIGZ.UseVisualStyleBackColor = true;
			this.EJDODWVQEMBEHJMPKRRIGZ.CheckedChanged += this.GNSMYKOIBMVLQDGBRIZJVX;
			this.DQMWMUKLJKOSDABJNWPAI.AutoSize = true;
			this.DQMWMUKLJKOSDABJNWPAI.FlatStyle = FlatStyle.Flat;
			this.DQMWMUKLJKOSDABJNWPAI.Location = new Point(5, 16);
			this.DQMWMUKLJKOSDABJNWPAI.Name = "bestproxy";
			this.DQMWMUKLJKOSDABJNWPAI.Size = new Size(102, 17);
			this.DQMWMUKLJKOSDABJNWPAI.TabIndex = 0;
			this.DQMWMUKLJKOSDABJNWPAI.Text = "best-proxies.ru";
			this.DQMWMUKLJKOSDABJNWPAI.UseVisualStyleBackColor = true;
			this.DQMWMUKLJKOSDABJNWPAI.CheckedChanged += this.MZSPQOKIBEIVOQUGUEBYWW;
			this.SZSZQWHGGGAZBSWHGCIHZP.BackColor = SystemColors.ButtonFace;
			this.SZSZQWHGGGAZBSWHGCIHZP.Location = new Point(82, 151);
			NumericUpDown szszqwhgggazbswhgcihzp = this.SZSZQWHGGGAZBSWHGCIHZP;
			int[] array = new int[4];
			array[0] = 10000;
			szszqwhgggazbswhgcihzp.Maximum = new decimal(array);
			NumericUpDown szszqwhgggazbswhgcihzp2 = this.SZSZQWHGGGAZBSWHGCIHZP;
			array = new int[4];
			array[0] = 100;
			szszqwhgggazbswhgcihzp2.Minimum = new decimal(array);
			this.SZSZQWHGGGAZBSWHGCIHZP.Name = "time_outBox";
			this.SZSZQWHGGGAZBSWHGCIHZP.Size = new Size(48, 22);
			this.SZSZQWHGGGAZBSWHGCIHZP.TabIndex = 9;
			this.SZSZQWHGGGAZBSWHGCIHZP.TextAlign = HorizontalAlignment.Center;
			NumericUpDown szszqwhgggazbswhgcihzp3 = this.SZSZQWHGGGAZBSWHGCIHZP;
			array = new int[4];
			array[0] = 3000;
			szszqwhgggazbswhgcihzp3.Value = new decimal(array);
			this.BCSGOPBAAFCCKETPHTSQXN.AutoSize = true;
			this.BCSGOPBAAFCCKETPHTSQXN.Location = new Point(5, 153);
			this.BCSGOPBAAFCCKETPHTSQXN.Name = "speedml";
			this.BCSGOPBAAFCCKETPHTSQXN.Size = new Size(63, 13);
			this.BCSGOPBAAFCCKETPHTSQXN.TabIndex = 8;
			this.BCSGOPBAAFCCKETPHTSQXN.Text = "С-сть в мс:";
			this.QIAMGTNNSUGVLTUIIRCAMQ.Controls.Add(this.PTDHITZQMFWPKNIHZKJOUX);
			this.QIAMGTNNSUGVLTUIIRCAMQ.FlatStyle = FlatStyle.Flat;
			this.QIAMGTNNSUGVLTUIIRCAMQ.Location = new Point(136, 2);
			this.QIAMGTNNSUGVLTUIIRCAMQ.Name = "goodsgroup";
			this.QIAMGTNNSUGVLTUIIRCAMQ.Size = new Size(163, 201);
			this.QIAMGTNNSUGVLTUIIRCAMQ.TabIndex = 18;
			this.QIAMGTNNSUGVLTUIIRCAMQ.TabStop = false;
			this.QIAMGTNNSUGVLTUIIRCAMQ.Text = "Найденные прокси :";
			this.QIAMGTNNSUGVLTUIIRCAMQ.Enter += this.ORLSFQNULBDHGJLCIWHNAD;
			this.PTDHITZQMFWPKNIHZKJOUX.BackColor = SystemColors.ControlLightLight;
			this.PTDHITZQMFWPKNIHZKJOUX.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.PTDHITZQMFWPKNIHZKJOUX.Location = new Point(6, 16);
			this.PTDHITZQMFWPKNIHZKJOUX.Name = "goodsproxybox";
			this.PTDHITZQMFWPKNIHZKJOUX.ReadOnly = true;
			this.PTDHITZQMFWPKNIHZKJOUX.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
			this.PTDHITZQMFWPKNIHZKJOUX.Size = new Size(151, 179);
			this.PTDHITZQMFWPKNIHZKJOUX.TabIndex = 0;
			this.PTDHITZQMFWPKNIHZKJOUX.Text = "";
			this.GQIFDAYGLGIRXOVWKVYTH.FormattingEnabled = true;
			this.GQIFDAYGLGIRXOVWKVYTH.Items.AddRange(new object[]
			{
				"Http/s",
				"Socks4",
				"Socks5"
			});
			this.GQIFDAYGLGIRXOVWKVYTH.Location = new Point(8, 129);
			this.GQIFDAYGLGIRXOVWKVYTH.Name = "typeBox";
			this.GQIFDAYGLGIRXOVWKVYTH.Size = new Size(122, 21);
			this.GQIFDAYGLGIRXOVWKVYTH.TabIndex = 22;
			this.GQIFDAYGLGIRXOVWKVYTH.Text = "Http/s";
			base.ClientSize = new Size(486, 209);
			base.Controls.Add(this.GQIFDAYGLGIRXOVWKVYTH);
			base.Controls.Add(this.DAXOMITYZMJMTCXXPIAAMC);
			base.Controls.Add(this.BCSGOPBAAFCCKETPHTSQXN);
			base.Controls.Add(this.CYLXNLWRVGMNMZFDECIFJV);
			base.Controls.Add(this.SZSZQWHGGGAZBSWHGCIHZP);
			base.Controls.Add(this.AJQOXTRRQTQXKMEXUBGZTV);
			base.Controls.Add(this.KWXLMFYYTUDQPTWUBRONA);
			base.Controls.Add(this.QBWZTDJTVRLWGYSSVCHLTD);
			base.Controls.Add(this.QIAMGTNNSUGVLTUIIRCAMQ);
			this.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			base.FormBorderStyle = FormBorderStyle.Fixed3D;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ProxyGrabber";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Proxy Grabber";
			base.FormClosing += this.RPERDWUKHVSQXYBFQDRSG;
			base.Load += this.TIBLFDPEETOGWOZXBUJSX;
			this.AJQOXTRRQTQXKMEXUBGZTV.ResumeLayout(false);
			this.QBWZTDJTVRLWGYSSVCHLTD.ResumeLayout(false);
			this.QBWZTDJTVRLWGYSSVCHLTD.PerformLayout();
			((ISupportInitialize)this.SZSZQWHGGGAZBSWHGCIHZP).EndInit();
			this.QIAMGTNNSUGVLTUIIRCAMQ.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000076E8 File Offset: 0x000058E8
		private void PHLCOQRMHLMCNIFXDLAGHP(object sender, EventArgs e)
		{
			using (HttpRequest httpRequest = new HttpRequest())
			{
				httpRequest.Cookies = new CookieDictionary(false);
				httpRequest.AllowAutoRedirect = false;
				try
				{
					string str = DateTime.Now.ToString("HH_mm");
					if (this.EJDODWVQEMBEHJMPKRRIGZ.Checked)
					{
						httpRequest.AddParam("c", this.CYLXNLWRVGMNMZFDECIFJV.Text);
						httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
						HttpResponse httpResponse = httpRequest.Post("https://hideme.ru/login");
						if (httpResponse.StatusCode == HttpStatusCode.Found)
						{
							string text = "hs";
							if (this.GQIFDAYGLGIRXOVWKVYTH.SelectedIndex == 1)
							{
								text = "4";
							}
							else if (this.GQIFDAYGLGIRXOVWKVYTH.SelectedIndex == 2)
							{
								text = "5";
							}
							string text2 = httpRequest.Get(string.Concat(new object[]
							{
								"http://hideme.ru/api/proxylist.txt?maxtime=",
								this.SZSZQWHGGGAZBSWHGCIHZP.Value,
								"&type=",
								text,
								"&out=plain&lang=ru"
							}), null).ToString();
							this.PTDHITZQMFWPKNIHZKJOUX.AppendText(text2);
							File.AppendAllText("HideMe[" + str + text + "].txt", text2);
							MessageBox.Show(this, "Успешно спарсили прокси.", "Прокси граббер", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Hide();
						}
						else
						{
							MessageBox.Show(this, "Не верно введен премиум ключ.", "Прокси граббер", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							base.Hide();
						}
					}
					else if (this.DQMWMUKLJKOSDABJNWPAI.Checked)
					{
						string text = "https,http";
						if (this.GQIFDAYGLGIRXOVWKVYTH.SelectedIndex == 1)
						{
							text = "socks4";
						}
						else if (this.GQIFDAYGLGIRXOVWKVYTH.SelectedIndex == 2)
						{
							text = "socks4,socks5";
						}
						string address = string.Concat(new object[]
						{
							"http://api.best-proxies.ru/feeds/proxylist.txt?key=",
							this.CYLXNLWRVGMNMZFDECIFJV.Text,
							"&limit=0&type=" + text + "&level=1,2"
						});
						string text3 = httpRequest.Get(address, null).ToString();
						if (text3.Contains("Ошибка авторизации:"))
						{
							MessageBox.Show(this, "Не верно введен премиум ключ.", "Прокси граббер", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							base.Hide();
						}
						else
						{
							this.PTDHITZQMFWPKNIHZKJOUX.AppendText(text3);
							File.AppendAllText("best-proxies[" + str + text + "].txt", text3);
							MessageBox.Show(this, "Успешно спарсили прокси.", "Прокси граббер", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.MTMNQQJLLZHQJBNMDMJGP(this.CYLXNLWRVGMNMZFDECIFJV.Text);
							base.Hide();
						}
					}
					else if (this.CJGHRNTNQROVCDMZCIPAPF.Checked)
					{
						string text4 = string.Empty;
						int i = 0;
						while (i < this.ENIECBKFPKZMEUUVUFTPIO.Lines.Count<string>())
						{
							string text3 = string.Empty;
							try
							{
								text3 = httpRequest.Get(this.ENIECBKFPKZMEUUVUFTPIO.Lines[i], null).ToString();
								goto IL_342;
							}
							catch
							{
								goto IL_342;
							}
							IEnumerator enumerator;
							try
							{
								IL_2EE:
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									Match match = (Match)obj;
									text4 = text4 + match.Value + "\r\n";
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
							i++;
							continue;
							IL_342:
							enumerator = Regex.Matches(text3, "\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}:\\d{1,5}").GetEnumerator();
							goto IL_2EE;
						}
						this.PTDHITZQMFWPKNIHZKJOUX.AppendText(text4);
						File.AppendAllText("Граббинг по ссылкам[" + str + "].txt", text4);
						MessageBox.Show(this, "Успешно спарсили прокси.", "Прокси граббер", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						base.Hide();
					}
				}
				catch
				{
					MessageBox.Show(this, "Произошла неизвестная ошибка.", "Прокси граббер", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					base.Hide();
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007B1C File Offset: 0x00005D1C
		private void MTMNQQJLLZHQJBNMDMJGP(string ZQYIFLJHPOQOCPHCDJIGAR)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\WF by Amfi");
				registryKey.SetValue("BestProxy", ZQYIFLJHPOQOCPHCDJIGAR);
				registryKey.Close();
			}
			catch
			{
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007B64 File Offset: 0x00005D64
		private void OXZORFCYLVEZHDGGCCBXI()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\WF by Amfi");
			if (registryKey != null)
			{
				try
				{
					string text = (string)registryKey.GetValue("BestProxy");
					this.CYLXNLWRVGMNMZFDECIFJV.Text = text;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007BC0 File Offset: 0x00005DC0
		private void WOCKBUDWKVCKORPWUJEJU(object sender, EventArgs e)
		{
			base.Height = 240;
			base.Width = 492;
			this.DAXOMITYZMJMTCXXPIAAMC.Visible = false;
			this.CYLXNLWRVGMNMZFDECIFJV.Visible = false;
			this.QBWZTDJTVRLWGYSSVCHLTD.Width = 131;
			this.QBWZTDJTVRLWGYSSVCHLTD.Height = 170;
			this.CYLXNLWRVGMNMZFDECIFJV.PasswordChar = '\0';
			this.GQIFDAYGLGIRXOVWKVYTH.Visible = false;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007C34 File Offset: 0x00005E34
		private void MZSPQOKIBEIVOQUGUEBYWW(object sender, EventArgs e)
		{
			base.Height = 240;
			base.Width = 145;
			this.CYLXNLWRVGMNMZFDECIFJV.Visible = true;
			this.DAXOMITYZMJMTCXXPIAAMC.Visible = true;
			this.QBWZTDJTVRLWGYSSVCHLTD.Width = 131;
			this.QBWZTDJTVRLWGYSSVCHLTD.Height = 170;
			this.CYLXNLWRVGMNMZFDECIFJV.PasswordChar = '\0';
			this.GQIFDAYGLGIRXOVWKVYTH.Visible = true;
			this.CYLXNLWRVGMNMZFDECIFJV.Text = "Введите ключ";
			this.OXZORFCYLVEZHDGGCCBXI();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007CC0 File Offset: 0x00005EC0
		private void TIBLFDPEETOGWOZXBUJSX(object sender, EventArgs e)
		{
			base.Size = new Size(144, 112);
			this.CYLXNLWRVGMNMZFDECIFJV.Visible = false;
			this.DAXOMITYZMJMTCXXPIAAMC.Visible = false;
			this.GQIFDAYGLGIRXOVWKVYTH.Visible = false;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[CompilerGenerated]
		private static void QWYKZUOZPQOGTTUNWUDTQO(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message);
		}

		// Token: 0x04000069 RID: 105
		private RadioButton DQMWMUKLJKOSDABJNWPAI;

		// Token: 0x0400006B RID: 107
		private GroupBox QIAMGTNNSUGVLTUIIRCAMQ;

		// Token: 0x0400006C RID: 108
		private RichTextBox PTDHITZQMFWPKNIHZKJOUX;

		// Token: 0x0400006D RID: 109
		private RadioButton CJGHRNTNQROVCDMZCIPAPF;

		// Token: 0x0400006E RID: 110
		private GroupBox AJQOXTRRQTQXKMEXUBGZTV;

		// Token: 0x0400006F RID: 111
		private GroupBox QBWZTDJTVRLWGYSSVCHLTD;

		// Token: 0x04000070 RID: 112
		private RadioButton EJDODWVQEMBEHJMPKRRIGZ;

		// Token: 0x04000071 RID: 113
		private TextBox CYLXNLWRVGMNMZFDECIFJV;

		// Token: 0x04000072 RID: 114
		private Label DAXOMITYZMJMTCXXPIAAMC;

		// Token: 0x04000073 RID: 115
		private Label BCSGOPBAAFCCKETPHTSQXN;

		// Token: 0x04000074 RID: 116
		private RichTextBox ENIECBKFPKZMEUUVUFTPIO;

		// Token: 0x04000075 RID: 117
		private Button KWXLMFYYTUDQPTWUBRONA;

		// Token: 0x04000076 RID: 118
		private ComboBox GQIFDAYGLGIRXOVWKVYTH;

		// Token: 0x04000077 RID: 119
		private NumericUpDown SZSZQWHGGGAZBSWHGCIHZP;

		// Token: 0x04000078 RID: 120
		[CompilerGenerated]
		private static ThreadExceptionEventHandler LWEFZJUAALHVONXTVFQGOI;
	}
}
