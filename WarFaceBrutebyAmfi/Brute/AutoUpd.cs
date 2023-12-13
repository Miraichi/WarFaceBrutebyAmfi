using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using SkinSoft.VisualStyler;
using SkinSoft.VisualStyler.Licensing;

namespace Brute
{
	// Token: 0x02000003 RID: 3
	public partial class AutoUpd : Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002CAC File Offset: 0x00000EAC
		public AutoUpd()
		{
			base.ShowInTaskbar = false;
			this.ROWCFMGCREGXYQUVHVWNWU();
			this.TWJDQPAWBOPOJEWMHKUWZH();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002CD0 File Offset: 0x00000ED0
		private void TWJDQPAWBOPOJEWMHKUWZH()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			this.ZIBDPTNSHPNWDSJGKEYOLL = Path.Combine(directoryName, "update.exe");
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1667.0 Safari/537.36");
			webClient.DownloadFileCompleted += this.UEOACYYEAHFRTTPEKFSCPS;
			webClient.DownloadProgressChanged += this.SISJERCKQSPPJDIVTRTDA;
			webClient.DownloadFileAsync(new Uri("http://dl.dropbox.com/s/y7cslqgftdh1h5h/Steam%20Checker%20by%20Amfi.exe"), this.ZIBDPTNSHPNWDSJGKEYOLL);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002D54 File Offset: 0x00000F54
		private void SISJERCKQSPPJDIVTRTDA(object sender, DownloadProgressChangedEventArgs e)
		{
			this.FCEXFLSYDHBAKZZFKIZWB.Value = e.ProgressPercentage;
			this.OLKBFYULXIGVXZPPHLFRF.Text = e.ProgressPercentage.ToString();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D8C File Offset: 0x00000F8C
		private void UEOACYYEAHFRTTPEKFSCPS(object sender, AsyncCompletedEventArgs e)
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
			string text = "~.bat";
			string value = string.Format("@echo off{0}:loop{0}del \"{1}\"{0}if exist \"{1}\" goto loop{0}rename \"{3}\" \"{1}\"{0}del {2}{0}{1}", new object[]
			{
				Environment.NewLine,
				fileName,
				text,
				this.ZIBDPTNSHPNWDSJGKEYOLL
			});
			using (StreamWriter streamWriter = new StreamWriter(text, false))
			{
				streamWriter.Write(value);
			}
			Process.Start(text);
			Environment.Exit(0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002E5C File Offset: 0x0000105C
		private void ROWCFMGCREGXYQUVHVWNWU()
		{
			this.MOZABQMOQVTAIXNZAJULQB = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AutoUpd));
			this.FCEXFLSYDHBAKZZFKIZWB = new ProgressBar();
			this.VNYQLZZJVMKGQULUFLINQE = new Label();
			this.OLKBFYULXIGVXZPPHLFRF = new Label();
			this.WJYJJTGOZUHKOHQRDDGJTS = new Label();
			this.VXULTBFBPQGQVTSOGIOZJD = new VisualStyler(this.MOZABQMOQVTAIXNZAJULQB);
			((ISupportInitialize)this.VXULTBFBPQGQVTSOGIOZJD).BeginInit();
			base.SuspendLayout();
			this.FCEXFLSYDHBAKZZFKIZWB.Location = new Point(8, 30);
			this.FCEXFLSYDHBAKZZFKIZWB.Name = "progressBar1";
			this.FCEXFLSYDHBAKZZFKIZWB.Size = new Size(261, 23);
			this.FCEXFLSYDHBAKZZFKIZWB.TabIndex = 0;
			this.VNYQLZZJVMKGQULUFLINQE.AutoSize = true;
			this.VNYQLZZJVMKGQULUFLINQE.FlatStyle = FlatStyle.Flat;
			this.VNYQLZZJVMKGQULUFLINQE.Location = new Point(21, 7);
			this.VNYQLZZJVMKGQULUFLINQE.Name = "label1";
			this.VNYQLZZJVMKGQULUFLINQE.Size = new Size(195, 13);
			this.VNYQLZZJVMKGQULUFLINQE.TabIndex = 1;
			this.VNYQLZZJVMKGQULUFLINQE.Text = "Подождите, загружаю обновление ...";
			this.OLKBFYULXIGVXZPPHLFRF.AutoSize = true;
			this.OLKBFYULXIGVXZPPHLFRF.BackColor = Color.Transparent;
			this.OLKBFYULXIGVXZPPHLFRF.ForeColor = SystemColors.ControlText;
			this.OLKBFYULXIGVXZPPHLFRF.Location = new Point(220, 7);
			this.OLKBFYULXIGVXZPPHLFRF.Name = "label2";
			this.OLKBFYULXIGVXZPPHLFRF.Size = new Size(13, 13);
			this.OLKBFYULXIGVXZPPHLFRF.TabIndex = 2;
			this.OLKBFYULXIGVXZPPHLFRF.Text = "0";
			this.WJYJJTGOZUHKOHQRDDGJTS.AutoSize = true;
			this.WJYJJTGOZUHKOHQRDDGJTS.BackColor = Color.Transparent;
			this.WJYJJTGOZUHKOHQRDDGJTS.FlatStyle = FlatStyle.Flat;
			this.WJYJJTGOZUHKOHQRDDGJTS.ForeColor = SystemColors.ControlText;
			this.WJYJJTGOZUHKOHQRDDGJTS.Location = new Point(241, 7);
			this.WJYJJTGOZUHKOHQRDDGJTS.Name = "label3";
			this.WJYJJTGOZUHKOHQRDDGJTS.Size = new Size(15, 13);
			this.WJYJJTGOZUHKOHQRDDGJTS.TabIndex = 3;
			this.WJYJJTGOZUHKOHQRDDGJTS.Text = "%";
			this.VXULTBFBPQGQVTSOGIOZJD.License = (VisualStylerLicense)componentResourceManager.GetObject("visualStyler1.License");
			this.VXULTBFBPQGQVTSOGIOZJD.LoadVisualStyle(null, "Kupo XP 2 Dark Blue (Normal).vssf");
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(275, 58);
			base.ControlBox = false;
			base.Controls.Add(this.WJYJJTGOZUHKOHQRDDGJTS);
			base.Controls.Add(this.OLKBFYULXIGVXZPPHLFRF);
			base.Controls.Add(this.VNYQLZZJVMKGQULUFLINQE);
			base.Controls.Add(this.FCEXFLSYDHBAKZZFKIZWB);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AutoUpd";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "AutoUpdate System SGC by Amfi";
			base.TopMost = true;
			((ISupportInitialize)this.VXULTBFBPQGQVTSOGIOZJD).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000B RID: 11
		private string ZIBDPTNSHPNWDSJGKEYOLL;

		// Token: 0x0400000D RID: 13
		private ProgressBar FCEXFLSYDHBAKZZFKIZWB;

		// Token: 0x0400000E RID: 14
		private Label VNYQLZZJVMKGQULUFLINQE;

		// Token: 0x0400000F RID: 15
		private Label OLKBFYULXIGVXZPPHLFRF;

		// Token: 0x04000010 RID: 16
		private Label WJYJJTGOZUHKOHQRDDGJTS;

		// Token: 0x04000011 RID: 17
		private VisualStyler VXULTBFBPQGQVTSOGIOZJD;
	}
}
